using System;
using System.Windows.Forms;

namespace 流量计检定上位机
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        private static ApplicationContext context;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();                       //样式设置
            Application.SetCompatibleTextRenderingDefault(false);   //样式设置
            //Form_Splash sp = new Form_Splash();                     //启动窗体
            //sp.Show();                                              //显示启动窗体
            //context = new ApplicationContext();
            //context.Tag = sp;                                       //装箱
            //Application.Idle += new EventHandler(Application_Idle); //注册程序运行空闲去执行主程序窗体相应初始化代码
            Application.Run(new Form_Splash());
        }
        private static void Application_Idle(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(Application_Idle);
            if (context.MainForm == null)
            {
                Form_Main mw = new Form_Main();
                context.MainForm = mw;
                mw.Init();                                  //主窗体要做的初始化事情在这里，该方法在主窗体里应该申明为public
                Form_Splash sp = (Form_Splash)context.Tag;  //拆箱
                mw.Show();                                  //启动主程序窗体
                sp.Close();                                 //关闭启动窗体
            }
        }
    }
}
