namespace SmartHeatStationServiceV2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemNotHideTuoPan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemhide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEixt = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConnectServer = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelServerName = new System.Windows.Forms.TextBox();
            this.labelDataBaseName = new System.Windows.Forms.TextBox();
            this.labelUidName = new System.Windows.Forms.TextBox();
            this.labelPwdName = new System.Windows.Forms.TextBox();
            this.labelServerName_ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDataBaseName_ = new System.Windows.Forms.Label();
            this.labelUidName_ = new System.Windows.Forms.Label();
            this.labelPwdName_ = new System.Windows.Forms.Label();
            this.panelSqlServer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelSqlServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("宋体", 12F);
            this.labelStatus.Location = new System.Drawing.Point(12, 32);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(88, 16);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "连接数据库";
            this.labelStatus.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(9, 405);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(379, 141);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Location = new System.Drawing.Point(9, 552);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(379, 136);
            this.textBox2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 56);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(379, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "托管到后台运行";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "智慧换热站";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNotHideTuoPan,
            this.toolStripMenuItemExitApplication});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // toolStripMenuItemNotHideTuoPan
            // 
            this.toolStripMenuItemNotHideTuoPan.Name = "toolStripMenuItemNotHideTuoPan";
            this.toolStripMenuItemNotHideTuoPan.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemNotHideTuoPan.Text = "还原";
            this.toolStripMenuItemNotHideTuoPan.Click += new System.EventHandler(this.toolStripMenuItemNotHideTuoPan_Click);
            // 
            // toolStripMenuItemExitApplication
            // 
            this.toolStripMenuItemExitApplication.Name = "toolStripMenuItemExitApplication";
            this.toolStripMenuItemExitApplication.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemExitApplication.Text = "退出";
            this.toolStripMenuItemExitApplication.Click += new System.EventHandler(this.toolStripMenuItemExitApplication_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.设置ToolStripMenuItem1,
            this.说明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemhide,
            this.toolStripMenuItemEixt});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "系统";
            // 
            // toolStripMenuItemhide
            // 
            this.toolStripMenuItemhide.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolStripMenuItemhide.Name = "toolStripMenuItemhide";
            this.toolStripMenuItemhide.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemhide.Text = "最小化";
            this.toolStripMenuItemhide.Click += new System.EventHandler(this.toolStripMenuItemhide_Click);
            // 
            // toolStripMenuItemEixt
            // 
            this.toolStripMenuItemEixt.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolStripMenuItemEixt.Name = "toolStripMenuItemEixt";
            this.toolStripMenuItemEixt.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemEixt.Text = "退出";
            this.toolStripMenuItemEixt.Click += new System.EventHandler(this.toolStripMenuItemEixt_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemConnectServer});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "操作";
            // 
            // ToolStripMenuItemConnectServer
            // 
            this.ToolStripMenuItemConnectServer.BackColor = System.Drawing.SystemColors.Highlight;
            this.ToolStripMenuItemConnectServer.Name = "ToolStripMenuItemConnectServer";
            this.ToolStripMenuItemConnectServer.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItemConnectServer.Text = "连接数据库";
            this.ToolStripMenuItemConnectServer.Click += new System.EventHandler(this.ToolStripMenuItemConnectServer_Click);
            // 
            // 设置ToolStripMenuItem1
            // 
            this.设置ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAuto});
            this.设置ToolStripMenuItem1.Name = "设置ToolStripMenuItem1";
            this.设置ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem1.Text = "设置";
            // 
            // ToolStripMenuItemAuto
            // 
            this.ToolStripMenuItemAuto.BackColor = System.Drawing.SystemColors.Highlight;
            this.ToolStripMenuItemAuto.Checked = true;
            this.ToolStripMenuItemAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItemAuto.Name = "ToolStripMenuItemAuto";
            this.ToolStripMenuItemAuto.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItemAuto.Text = "自动连接";
            this.ToolStripMenuItemAuto.Click += new System.EventHandler(this.ToolStripMenuItemAuto_Click);
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.说明ToolStripMenuItem.Text = "说明";
            this.说明ToolStripMenuItem.Click += new System.EventHandler(this.说明ToolStripMenuItem_Click);
            // 
            // labelServerName
            // 
            this.labelServerName.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelServerName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelServerName.Location = new System.Drawing.Point(106, 3);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.labelServerName.Size = new System.Drawing.Size(285, 23);
            this.labelServerName.TabIndex = 1;
            this.labelServerName.Text = ".";
            // 
            // labelDataBaseName
            // 
            this.labelDataBaseName.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelDataBaseName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDataBaseName.Location = new System.Drawing.Point(106, 30);
            this.labelDataBaseName.Name = "labelDataBaseName";
            this.labelDataBaseName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.labelDataBaseName.Size = new System.Drawing.Size(285, 23);
            this.labelDataBaseName.TabIndex = 1;
            this.labelDataBaseName.Text = ".";
            // 
            // labelUidName
            // 
            this.labelUidName.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelUidName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUidName.Location = new System.Drawing.Point(106, 57);
            this.labelUidName.Name = "labelUidName";
            this.labelUidName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.labelUidName.Size = new System.Drawing.Size(285, 23);
            this.labelUidName.TabIndex = 1;
            this.labelUidName.Text = "sa";
            // 
            // labelPwdName
            // 
            this.labelPwdName.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelPwdName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPwdName.Location = new System.Drawing.Point(106, 84);
            this.labelPwdName.Name = "labelPwdName";
            this.labelPwdName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.labelPwdName.Size = new System.Drawing.Size(285, 23);
            this.labelPwdName.TabIndex = 1;
            this.labelPwdName.Text = "123";
            // 
            // labelServerName_
            // 
            this.labelServerName_.AutoSize = true;
            this.labelServerName_.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelServerName_.Location = new System.Drawing.Point(12, 3);
            this.labelServerName_.Name = "labelServerName_";
            this.labelServerName_.Size = new System.Drawing.Size(90, 22);
            this.labelServerName_.TabIndex = 0;
            this.labelServerName_.Text = "服务器名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(256, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "智慧换热站";
            // 
            // labelDataBaseName_
            // 
            this.labelDataBaseName_.AutoSize = true;
            this.labelDataBaseName_.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDataBaseName_.Location = new System.Drawing.Point(11, 30);
            this.labelDataBaseName_.Name = "labelDataBaseName_";
            this.labelDataBaseName_.Size = new System.Drawing.Size(90, 22);
            this.labelDataBaseName_.TabIndex = 0;
            this.labelDataBaseName_.Text = "数据库名称";
            // 
            // labelUidName_
            // 
            this.labelUidName_.AutoSize = true;
            this.labelUidName_.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUidName_.Location = new System.Drawing.Point(42, 57);
            this.labelUidName_.Name = "labelUidName_";
            this.labelUidName_.Size = new System.Drawing.Size(58, 22);
            this.labelUidName_.TabIndex = 0;
            this.labelUidName_.Text = "用户名";
            // 
            // labelPwdName_
            // 
            this.labelPwdName_.AutoSize = true;
            this.labelPwdName_.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPwdName_.Location = new System.Drawing.Point(58, 84);
            this.labelPwdName_.Name = "labelPwdName_";
            this.labelPwdName_.Size = new System.Drawing.Size(42, 22);
            this.labelPwdName_.TabIndex = 0;
            this.labelPwdName_.Text = "密码";
            // 
            // panelSqlServer
            // 
            this.panelSqlServer.Controls.Add(this.labelServerName);
            this.panelSqlServer.Controls.Add(this.labelServerName_);
            this.panelSqlServer.Controls.Add(this.labelDataBaseName_);
            this.panelSqlServer.Controls.Add(this.labelUidName_);
            this.panelSqlServer.Controls.Add(this.labelPwdName_);
            this.panelSqlServer.Controls.Add(this.labelPwdName);
            this.panelSqlServer.Controls.Add(this.labelDataBaseName);
            this.panelSqlServer.Controls.Add(this.labelUidName);
            this.panelSqlServer.Location = new System.Drawing.Point(0, 85);
            this.panelSqlServer.Name = "panelSqlServer";
            this.panelSqlServer.Size = new System.Drawing.Size(403, 116);
            this.panelSqlServer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(4, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "系统/最小化：最小化到托盘\r\n系统/退出：退出软件\r\n操作/连接数据库：连接数据库并向云服务器上传数据\r\n设置/自动连接：打开软件是否自动连接数据库";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.ControlBox = false;
            this.Controls.Add(this.panelSqlServer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStatus);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智慧换热站";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSqlServer.ResumeLayout(false);
            this.panelSqlServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNotHideTuoPan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExitApplication;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemhide;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEixt;
        private System.Windows.Forms.TextBox labelServerName;
        private System.Windows.Forms.TextBox labelDataBaseName;
        private System.Windows.Forms.TextBox labelUidName;
        private System.Windows.Forms.TextBox labelPwdName;
        private System.Windows.Forms.Label labelServerName_;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConnectServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDataBaseName_;
        private System.Windows.Forms.Label labelUidName_;
        private System.Windows.Forms.Label labelPwdName_;
        private System.Windows.Forms.Panel panelSqlServer;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAuto;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

