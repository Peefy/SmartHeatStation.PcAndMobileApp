using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;

namespace 流量计检定上位机
{
    public partial class Form_Splash : CCWin.CCSkinMain
    {
        bool FirstFlag = true;

        public string[] loginMessage = { "登入成功", "用户名不存在",
            "密码错误", "锁定", "未激活",
            "冻结", "删除", "账户还未开通", "账户已过期", "" };

        public Form_Splash()
        {
            InitializeComponent();
            this.Cursor = Cursors.Default;
        }

        private void Form_Splash_Load(object sender, EventArgs e)
        {
            //labelVersion.Text = AppInfo.GetVersionInfo();
            labelAppName.Text = AppInfo.GetName();

            #region
            //读取注册表用户名跟密码
            RegistryKey rsg = null;
            //Registry.Users.CreateSubKey(LoginInfo.RegeditPathString);
            rsg = Registry.Users.CreateSubKey(LoginInfo.RegeditPathString);
            if (rsg.GetValue("first") != null) //读取失败返回null
            {
               FirstFlag = Convert.ToBoolean(rsg.GetValue("first"));
            }
            if (rsg.GetValue("issavepsd") != null) //读取失败返回null
            {
                this.chkSavePWD.Checked = Convert.ToBoolean(rsg.GetValue("issavepsd"));
            }
            if (rsg.GetValue("username") != null) //读取失败返回null
            {
                this.txbUserName.Text = rsg.GetValue("username").ToString();
            }
            if(this.chkSavePWD.Checked == true)
            {
                if (rsg.GetValue("password") != null) //读取失败返回null
                {
                    this.txbPassWord.Text = rsg.GetValue("password").ToString();
                    this.chkSavePWD.Checked = true;
                }
            }
            rsg.Close();
            #endregion

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var userName = this.txbUserName.Text;
            var passWord = this.txbPassWord.Text;
            var IsSavePWD = this.chkSavePWD.Checked;
            var errorId = 0;
            var isLogin = false;
            string[] infoList = { "1", "haiyabtx", "password", "2", "系统管理员", "2016-12-14", "2016-12-14" };

            #region 验证用户名和密码不能为空
            if (string.IsNullOrEmpty(userName))
            {
                DialogResult result;
                result = MessageBox.Show("用户名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    if (!this.prbLoading.ContainsFocus)
                    {
                        this.FindForm().Activate();
                    }
                    this.txbUserName.Focus();
                }
                return;
            }

            if (string.IsNullOrEmpty(passWord))
            {
                DialogResult result;
                result = MessageBox.Show("密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    if (!this.prbLoading.ContainsFocus)
                    {
                        this.FindForm().Activate();
                    }
                    this.txbPassWord.Focus();
                }
                return;
            }
            #endregion

            //登入判定
            //isLogin = WebClient.Login(userName, passWord, out errorId, out infoList);
            isLogin = LoginInfo.ClientLogin(userName, passWord, out errorId, out infoList,FirstFlag);
    
            if (isLogin)
            {
                FirstFlag = false;
                //登入成功
                #region 注册表写入用户名跟密码

                RegistryKey rsg = null;
                rsg = Registry.Users.OpenSubKey(LoginInfo.RegeditPathString, true);//true表示可以修改
                rsg.SetValue("username", userName);//写入注册表
                rsg.SetValue("password", passWord);//写入注册表
                rsg.SetValue("issavepsd", chkSavePWD.Checked);//写入注册表
                rsg.SetValue("first", FirstFlag);//写入注册表
                rsg.Close();
                #endregion
                btnLogIn.Enabled = false;
                btnLogOut.Enabled = false;
                RollingBar.Visible = true;
                RollingBar.StartRolling();
                Thread thread = new Thread(new ThreadStart(Send));
                thread.Start();
                LoginInfo.UserName = userName;
                LoginInfo.PassWord = passWord;
     
            }
            else
            {
                //登入失败
                var result = MessageBox.Show(string.Format("用户登入失败,{0}!", loginMessage[errorId]), "提示", MessageBoxButtons.OK);
                this.txbUserName.Focus();
            }
        }

        #region Loading 进度条
        private void Send()
        {
            int i = 0;
            while (i <= 50)
            {
                //显示进度 信息
                this.ShowPro(i);
                //循环发生文件
                //模拟的 
                i++; //模拟发送多少
                Thread.Sleep(40);
            }
            Thread.CurrentThread.Abort();
        }
        private delegate void ProgressBarShow(int i);
        private void ShowPro(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ProgressBarShow(ShowPro), value);

            }
            else
            {

                this.prbLoading.Value = value * 2;
                if (value == 50)
                {                       
                    ////跳转到内容页
                    new Form_Main().Show();
                    ////登陆窗体隐藏
                    this.Hide();
                }
            }

        }
        #endregion

        #region 客户区拖动窗体
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }
            base.WndProc(ref m);
        }
        #endregion

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();//退出整个应用程序。（无法退出单独开启的线程）
            Application.ExitThread();//释放所有线程　
        }
    }
}
