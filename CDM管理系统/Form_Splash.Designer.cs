namespace 流量计检定上位机
{
    partial class Form_Splash
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.SkinRollingBarThemeBase skinRollingBarThemeBase1 = new CCWin.SkinControl.SkinRollingBarThemeBase();
            this.labelAppName = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.btnLogIn = new CCWin.SkinControl.SkinButton();
            this.btnLogOut = new CCWin.SkinControl.SkinButton();
            this.chkSavePWD = new CCWin.SkinControl.SkinCheckBox();
            this.txbUserName = new CCWin.SkinControl.SkinTextBox();
            this.txbPassWord = new CCWin.SkinControl.SkinTextBox();
            this.RollingBar = new CCWin.SkinControl.SkinRollingBar();
            this.prbLoading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.BackColor = System.Drawing.Color.Transparent;
            this.labelAppName.BorderColor = System.Drawing.Color.White;
            this.labelAppName.Font = new System.Drawing.Font("楷体", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAppName.ForeColor = System.Drawing.Color.Indigo;
            this.labelAppName.Location = new System.Drawing.Point(164, 37);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(220, 35);
            this.labelAppName.TabIndex = 0;
            this.labelAppName.Text = "CDM管理系统";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.skinLabel2.ForeColor = System.Drawing.Color.Navy;
            this.skinLabel2.Location = new System.Drawing.Point(411, 227);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(148, 22);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "自动化研究所";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Purple;
            this.skinLabel4.Location = new System.Drawing.Point(137, 89);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(75, 28);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "用户名";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.Purple;
            this.skinLabel5.Location = new System.Drawing.Point(138, 119);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(72, 28);
            this.skinLabel5.TabIndex = 0;
            this.skinLabel5.Text = "密   码";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.BaseColor = System.Drawing.Color.Gray;
            this.btnLogIn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogIn.DownBack = null;
            this.btnLogIn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Purple;
            this.btnLogIn.Location = new System.Drawing.Point(256, 163);
            this.btnLogIn.MouseBack = null;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.NormlBack = null;
            this.btnLogIn.Size = new System.Drawing.Size(69, 28);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "登 陆";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BaseColor = System.Drawing.Color.Gray;
            this.btnLogOut.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogOut.DownBack = null;
            this.btnLogOut.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Purple;
            this.btnLogOut.Location = new System.Drawing.Point(331, 163);
            this.btnLogOut.MouseBack = null;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NormlBack = null;
            this.btnLogOut.Size = new System.Drawing.Size(64, 28);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "退 出";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // chkSavePWD
            // 
            this.chkSavePWD.AutoSize = true;
            this.chkSavePWD.BackColor = System.Drawing.Color.Transparent;
            this.chkSavePWD.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkSavePWD.DownBack = null;
            this.chkSavePWD.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.chkSavePWD.Location = new System.Drawing.Point(144, 165);
            this.chkSavePWD.MouseBack = null;
            this.chkSavePWD.Name = "chkSavePWD";
            this.chkSavePWD.NormlBack = null;
            this.chkSavePWD.SelectedDownBack = null;
            this.chkSavePWD.SelectedMouseBack = null;
            this.chkSavePWD.SelectedNormlBack = null;
            this.chkSavePWD.Size = new System.Drawing.Size(93, 25);
            this.chkSavePWD.TabIndex = 4;
            this.chkSavePWD.Text = "记住密码";
            this.chkSavePWD.UseVisualStyleBackColor = false;
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.Transparent;
            this.txbUserName.DownBack = null;
            this.txbUserName.Icon = null;
            this.txbUserName.IconIsButton = false;
            this.txbUserName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txbUserName.IsPasswordChat = '\0';
            this.txbUserName.IsSystemPasswordChar = false;
            this.txbUserName.Lines = new string[0];
            this.txbUserName.Location = new System.Drawing.Point(210, 89);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txbUserName.MaxLength = 32767;
            this.txbUserName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txbUserName.MouseBack = null;
            this.txbUserName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txbUserName.Multiline = false;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.NormlBack = null;
            this.txbUserName.Padding = new System.Windows.Forms.Padding(5);
            this.txbUserName.ReadOnly = false;
            this.txbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUserName.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txbUserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbUserName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txbUserName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txbUserName.SkinTxt.Name = "BaseText";
            this.txbUserName.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txbUserName.SkinTxt.TabIndex = 0;
            this.txbUserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txbUserName.SkinTxt.WaterText = "请输入用户名";
            this.txbUserName.TabIndex = 10;
            this.txbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbUserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txbUserName.WaterText = "请输入用户名";
            this.txbUserName.WordWrap = true;
            // 
            // txbPassWord
            // 
            this.txbPassWord.BackColor = System.Drawing.Color.Transparent;
            this.txbPassWord.DownBack = null;
            this.txbPassWord.Icon = null;
            this.txbPassWord.IconIsButton = false;
            this.txbPassWord.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txbPassWord.IsPasswordChat = '●';
            this.txbPassWord.IsSystemPasswordChar = true;
            this.txbPassWord.Lines = new string[0];
            this.txbPassWord.Location = new System.Drawing.Point(210, 119);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(0);
            this.txbPassWord.MaxLength = 32767;
            this.txbPassWord.MinimumSize = new System.Drawing.Size(28, 28);
            this.txbPassWord.MouseBack = null;
            this.txbPassWord.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txbPassWord.Multiline = false;
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.NormlBack = null;
            this.txbPassWord.Padding = new System.Windows.Forms.Padding(5);
            this.txbPassWord.ReadOnly = false;
            this.txbPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPassWord.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txbPassWord.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassWord.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPassWord.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txbPassWord.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txbPassWord.SkinTxt.Name = "BaseText";
            this.txbPassWord.SkinTxt.PasswordChar = '●';
            this.txbPassWord.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txbPassWord.SkinTxt.TabIndex = 0;
            this.txbPassWord.SkinTxt.UseSystemPasswordChar = true;
            this.txbPassWord.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txbPassWord.SkinTxt.WaterText = "请输入密码";
            this.txbPassWord.TabIndex = 10;
            this.txbPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPassWord.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txbPassWord.WaterText = "请输入密码";
            this.txbPassWord.WordWrap = true;
            // 
            // RollingBar
            // 
            this.RollingBar.Location = new System.Drawing.Point(210, 206);
            this.RollingBar.Name = "RollingBar";
            this.RollingBar.Radius2 = 24;
            this.RollingBar.Size = new System.Drawing.Size(97, 43);
            this.RollingBar.TabIndex = 11;
            this.RollingBar.TabStop = false;
            this.RollingBar.Visible = false;
            skinRollingBarThemeBase1.BackColor = System.Drawing.Color.Transparent;
            skinRollingBarThemeBase1.BaseColor = System.Drawing.Color.Red;
            skinRollingBarThemeBase1.DiamondColor = System.Drawing.Color.White;
            skinRollingBarThemeBase1.PenWidth = 2F;
            skinRollingBarThemeBase1.Radius1 = 10;
            skinRollingBarThemeBase1.Radius2 = 24;
            skinRollingBarThemeBase1.SpokeNum = 12;
            this.RollingBar.XTheme = skinRollingBarThemeBase1;
            // 
            // prbLoading
            // 
            this.prbLoading.BackColor = System.Drawing.Color.White;
            this.prbLoading.ForeColor = System.Drawing.Color.Red;
            this.prbLoading.Location = new System.Drawing.Point(241, 255);
            this.prbLoading.Name = "prbLoading";
            this.prbLoading.Size = new System.Drawing.Size(318, 6);
            this.prbLoading.TabIndex = 9;
            this.prbLoading.UseWaitCursor = true;
            this.prbLoading.Visible = false;
            // 
            // Form_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(558, 262);
            this.ControlBox = false;
            this.Controls.Add(this.RollingBar);
            this.Controls.Add(this.txbPassWord);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.prbLoading);
            this.Controls.Add(this.chkSavePWD);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel2);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Splash";
            this.Radius = 1;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.Form_Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel labelAppName;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinButton btnLogIn;
        private CCWin.SkinControl.SkinButton btnLogOut;
        private CCWin.SkinControl.SkinCheckBox chkSavePWD;
        private CCWin.SkinControl.SkinTextBox txbUserName;
        private CCWin.SkinControl.SkinTextBox txbPassWord;
        private CCWin.SkinControl.SkinRollingBar RollingBar;
        private System.Windows.Forms.ProgressBar prbLoading;
    }
}

