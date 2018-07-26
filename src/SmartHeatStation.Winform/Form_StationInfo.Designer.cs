namespace 流量计检定上位机
{
    partial class Form_StationInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupTimeShow = new CCWin.SkinControl.SkinGroupBox();
            this.labelTime = new CCWin.SkinControl.SkinLabel();
            this.btnClose = new CCWin.SkinControl.SkinButton();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label10 = new CCWin.SkinControl.SkinLabel();
            this.label9 = new CCWin.SkinControl.SkinLabel();
            this.label8 = new CCWin.SkinControl.SkinLabel();
            this.label11 = new CCWin.SkinControl.SkinLabel();
            this.label7 = new CCWin.SkinControl.SkinLabel();
            this.label6 = new CCWin.SkinControl.SkinLabel();
            this.label5 = new CCWin.SkinControl.SkinLabel();
            this.label4 = new CCWin.SkinControl.SkinLabel();
            this.label3 = new CCWin.SkinControl.SkinLabel();
            this.label2 = new CCWin.SkinControl.SkinLabel();
            this.label1 = new CCWin.SkinControl.SkinLabel();
            this.label0 = new CCWin.SkinControl.SkinLabel();
            this.textBox0 = new CCWin.SkinControl.SkinTextBox();
            this.textBox1 = new CCWin.SkinControl.SkinTextBox();
            this.textBox2 = new CCWin.SkinControl.SkinTextBox();
            this.textBox3 = new CCWin.SkinControl.SkinTextBox();
            this.textBox4 = new CCWin.SkinControl.SkinTextBox();
            this.textBox5 = new CCWin.SkinControl.SkinTextBox();
            this.textBox6 = new CCWin.SkinControl.SkinTextBox();
            this.textBox7 = new CCWin.SkinControl.SkinTextBox();
            this.textBox8 = new CCWin.SkinControl.SkinTextBox();
            this.textBox9 = new CCWin.SkinControl.SkinTextBox();
            this.textBox10 = new CCWin.SkinControl.SkinTextBox();
            this.textBox11 = new CCWin.SkinControl.SkinTextBox();
            this.groupTimeShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTimeShow
            // 
            this.groupTimeShow.BackColor = System.Drawing.Color.Transparent;
            this.groupTimeShow.BorderColor = System.Drawing.Color.Black;
            this.groupTimeShow.Controls.Add(this.labelTime);
            this.groupTimeShow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupTimeShow.ForeColor = System.Drawing.Color.Indigo;
            this.groupTimeShow.Location = new System.Drawing.Point(7, 8);
            this.groupTimeShow.Name = "groupTimeShow";
            this.groupTimeShow.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.groupTimeShow.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.groupTimeShow.Size = new System.Drawing.Size(216, 66);
            this.groupTimeShow.TabIndex = 33;
            this.groupTimeShow.TabStop = false;
            this.groupTimeShow.Text = "时间显示";
            this.groupTimeShow.TitleBorderColor = System.Drawing.Color.Black;
            this.groupTimeShow.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupTimeShow.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.BorderColor = System.Drawing.Color.White;
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelTime.Location = new System.Drawing.Point(5, 33);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(196, 22);
            this.labelTime.TabIndex = 27;
            this.labelTime.Text = "System.DateTime.Now";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClose.DownBack = null;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(238, 41);
            this.btnClose.MouseBack = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormlBack = null;
            this.btnClose.Size = new System.Drawing.Size(384, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "确定";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(11, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 28);
            this.label10.TabIndex = 36;
            this.label10.Text = "泵4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(11, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 28);
            this.label9.TabIndex = 38;
            this.label9.Text = "泵3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.BorderColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(11, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 28);
            this.label8.TabIndex = 39;
            this.label8.Text = "泵2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(11, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 28);
            this.label11.TabIndex = 41;
            this.label11.Text = "泵5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(11, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 28);
            this.label7.TabIndex = 42;
            this.label7.Text = "泵1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(11, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 28);
            this.label6.TabIndex = 43;
            this.label6.Text = "泵0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "流量热量表";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(11, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "总调节阀参数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 28);
            this.label3.TabIndex = 46;
            this.label3.Text = "水箱进水阀参数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(11, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 47;
            this.label2.Text = "供水压力下限值";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "供水压力上限值";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.BorderColor = System.Drawing.Color.White;
            this.label0.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label0.Location = new System.Drawing.Point(11, 83);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(159, 28);
            this.label0.TabIndex = 49;
            this.label0.Text = "供水压力当前值";
            // 
            // textBox0
            // 
            this.textBox0.BackColor = System.Drawing.Color.Transparent;
            this.textBox0.DownBack = null;
            this.textBox0.Icon = null;
            this.textBox0.IconIsButton = false;
            this.textBox0.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox0.IsPasswordChat = '\0';
            this.textBox0.IsSystemPasswordChar = false;
            this.textBox0.Lines = new string[] {
        "skinTextBox1"};
            this.textBox0.Location = new System.Drawing.Point(218, 82);
            this.textBox0.Margin = new System.Windows.Forms.Padding(0);
            this.textBox0.MaxLength = 32767;
            this.textBox0.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox0.MouseBack = null;
            this.textBox0.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox0.Multiline = false;
            this.textBox0.Name = "textBox0";
            this.textBox0.NormlBack = null;
            this.textBox0.Padding = new System.Windows.Forms.Padding(5);
            this.textBox0.ReadOnly = false;
            this.textBox0.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox0.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox0.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox0.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox0.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox0.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox0.SkinTxt.Name = "BaseText";
            this.textBox0.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox0.SkinTxt.TabIndex = 0;
            this.textBox0.SkinTxt.Text = "skinTextBox1";
            this.textBox0.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox0.SkinTxt.WaterText = "";
            this.textBox0.TabIndex = 50;
            this.textBox0.Text = "skinTextBox1";
            this.textBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox0.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox0.WaterText = "";
            this.textBox0.WordWrap = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.DownBack = null;
            this.textBox1.Icon = null;
            this.textBox1.IconIsButton = false;
            this.textBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox1.IsPasswordChat = '\0';
            this.textBox1.IsSystemPasswordChar = false;
            this.textBox1.Lines = new string[] {
        "skinTextBox1"};
            this.textBox1.Location = new System.Drawing.Point(218, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 32767;
            this.textBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox1.MouseBack = null;
            this.textBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.NormlBack = null;
            this.textBox1.Padding = new System.Windows.Forms.Padding(5);
            this.textBox1.ReadOnly = false;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox1.SkinTxt.Name = "BaseText";
            this.textBox1.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox1.SkinTxt.TabIndex = 0;
            this.textBox1.SkinTxt.Text = "skinTextBox1";
            this.textBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox1.SkinTxt.WaterText = "";
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "skinTextBox1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox1.WaterText = "";
            this.textBox1.WordWrap = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Transparent;
            this.textBox2.DownBack = null;
            this.textBox2.Icon = null;
            this.textBox2.IconIsButton = false;
            this.textBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox2.IsPasswordChat = '\0';
            this.textBox2.IsSystemPasswordChar = false;
            this.textBox2.Lines = new string[] {
        "skinTextBox1"};
            this.textBox2.Location = new System.Drawing.Point(218, 139);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.MaxLength = 32767;
            this.textBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox2.MouseBack = null;
            this.textBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.NormlBack = null;
            this.textBox2.Padding = new System.Windows.Forms.Padding(5);
            this.textBox2.ReadOnly = false;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox2.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox2.SkinTxt.Name = "BaseText";
            this.textBox2.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox2.SkinTxt.TabIndex = 0;
            this.textBox2.SkinTxt.Text = "skinTextBox1";
            this.textBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox2.SkinTxt.WaterText = "";
            this.textBox2.TabIndex = 50;
            this.textBox2.Text = "skinTextBox1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox2.WaterText = "";
            this.textBox2.WordWrap = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Transparent;
            this.textBox3.DownBack = null;
            this.textBox3.Icon = null;
            this.textBox3.IconIsButton = false;
            this.textBox3.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox3.IsPasswordChat = '\0';
            this.textBox3.IsSystemPasswordChar = false;
            this.textBox3.Lines = new string[] {
        "skinTextBox1"};
            this.textBox3.Location = new System.Drawing.Point(218, 167);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.MaxLength = 32767;
            this.textBox3.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox3.MouseBack = null;
            this.textBox3.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox3.Multiline = false;
            this.textBox3.Name = "textBox3";
            this.textBox3.NormlBack = null;
            this.textBox3.Padding = new System.Windows.Forms.Padding(5);
            this.textBox3.ReadOnly = false;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox3.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox3.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox3.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox3.SkinTxt.Name = "BaseText";
            this.textBox3.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox3.SkinTxt.TabIndex = 0;
            this.textBox3.SkinTxt.Text = "skinTextBox1";
            this.textBox3.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox3.SkinTxt.WaterText = "";
            this.textBox3.TabIndex = 50;
            this.textBox3.Text = "skinTextBox1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox3.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox3.WaterText = "";
            this.textBox3.WordWrap = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Transparent;
            this.textBox4.DownBack = null;
            this.textBox4.Icon = null;
            this.textBox4.IconIsButton = false;
            this.textBox4.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox4.IsPasswordChat = '\0';
            this.textBox4.IsSystemPasswordChar = false;
            this.textBox4.Lines = new string[] {
        "skinTextBox1"};
            this.textBox4.Location = new System.Drawing.Point(218, 195);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.MaxLength = 32767;
            this.textBox4.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox4.MouseBack = null;
            this.textBox4.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox4.Multiline = false;
            this.textBox4.Name = "textBox4";
            this.textBox4.NormlBack = null;
            this.textBox4.Padding = new System.Windows.Forms.Padding(5);
            this.textBox4.ReadOnly = false;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox4.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox4.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox4.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox4.SkinTxt.Name = "BaseText";
            this.textBox4.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox4.SkinTxt.TabIndex = 0;
            this.textBox4.SkinTxt.Text = "skinTextBox1";
            this.textBox4.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox4.SkinTxt.WaterText = "";
            this.textBox4.TabIndex = 50;
            this.textBox4.Text = "skinTextBox1";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox4.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox4.WaterText = "";
            this.textBox4.WordWrap = true;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Transparent;
            this.textBox5.DownBack = null;
            this.textBox5.Icon = null;
            this.textBox5.IconIsButton = false;
            this.textBox5.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox5.IsPasswordChat = '\0';
            this.textBox5.IsSystemPasswordChar = false;
            this.textBox5.Lines = new string[] {
        "skinTextBox1"};
            this.textBox5.Location = new System.Drawing.Point(218, 223);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0);
            this.textBox5.MaxLength = 32767;
            this.textBox5.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox5.MouseBack = null;
            this.textBox5.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox5.Multiline = false;
            this.textBox5.Name = "textBox5";
            this.textBox5.NormlBack = null;
            this.textBox5.Padding = new System.Windows.Forms.Padding(5);
            this.textBox5.ReadOnly = false;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox5.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox5.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox5.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox5.SkinTxt.Name = "BaseText";
            this.textBox5.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox5.SkinTxt.TabIndex = 0;
            this.textBox5.SkinTxt.Text = "skinTextBox1";
            this.textBox5.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox5.SkinTxt.WaterText = "";
            this.textBox5.TabIndex = 50;
            this.textBox5.Text = "skinTextBox1";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox5.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox5.WaterText = "";
            this.textBox5.WordWrap = true;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Transparent;
            this.textBox6.DownBack = null;
            this.textBox6.Icon = null;
            this.textBox6.IconIsButton = false;
            this.textBox6.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox6.IsPasswordChat = '\0';
            this.textBox6.IsSystemPasswordChar = false;
            this.textBox6.Lines = new string[] {
        "skinTextBox1"};
            this.textBox6.Location = new System.Drawing.Point(218, 251);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.MaxLength = 32767;
            this.textBox6.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox6.MouseBack = null;
            this.textBox6.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox6.Multiline = false;
            this.textBox6.Name = "textBox6";
            this.textBox6.NormlBack = null;
            this.textBox6.Padding = new System.Windows.Forms.Padding(5);
            this.textBox6.ReadOnly = false;
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox6.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox6.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox6.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox6.SkinTxt.Name = "BaseText";
            this.textBox6.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox6.SkinTxt.TabIndex = 0;
            this.textBox6.SkinTxt.Text = "skinTextBox1";
            this.textBox6.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox6.SkinTxt.WaterText = "";
            this.textBox6.TabIndex = 50;
            this.textBox6.Text = "skinTextBox1";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox6.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox6.WaterText = "";
            this.textBox6.WordWrap = true;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Transparent;
            this.textBox7.DownBack = null;
            this.textBox7.Icon = null;
            this.textBox7.IconIsButton = false;
            this.textBox7.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox7.IsPasswordChat = '\0';
            this.textBox7.IsSystemPasswordChar = false;
            this.textBox7.Lines = new string[] {
        "skinTextBox1"};
            this.textBox7.Location = new System.Drawing.Point(218, 279);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0);
            this.textBox7.MaxLength = 32767;
            this.textBox7.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox7.MouseBack = null;
            this.textBox7.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox7.Multiline = false;
            this.textBox7.Name = "textBox7";
            this.textBox7.NormlBack = null;
            this.textBox7.Padding = new System.Windows.Forms.Padding(5);
            this.textBox7.ReadOnly = false;
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox7.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox7.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox7.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox7.SkinTxt.Name = "BaseText";
            this.textBox7.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox7.SkinTxt.TabIndex = 0;
            this.textBox7.SkinTxt.Text = "skinTextBox1";
            this.textBox7.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox7.SkinTxt.WaterText = "";
            this.textBox7.TabIndex = 50;
            this.textBox7.Text = "skinTextBox1";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox7.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox7.WaterText = "";
            this.textBox7.WordWrap = true;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Transparent;
            this.textBox8.DownBack = null;
            this.textBox8.Icon = null;
            this.textBox8.IconIsButton = false;
            this.textBox8.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox8.IsPasswordChat = '\0';
            this.textBox8.IsSystemPasswordChar = false;
            this.textBox8.Lines = new string[] {
        "skinTextBox1"};
            this.textBox8.Location = new System.Drawing.Point(218, 307);
            this.textBox8.Margin = new System.Windows.Forms.Padding(0);
            this.textBox8.MaxLength = 32767;
            this.textBox8.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox8.MouseBack = null;
            this.textBox8.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox8.Multiline = false;
            this.textBox8.Name = "textBox8";
            this.textBox8.NormlBack = null;
            this.textBox8.Padding = new System.Windows.Forms.Padding(5);
            this.textBox8.ReadOnly = false;
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox8.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox8.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox8.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox8.SkinTxt.Name = "BaseText";
            this.textBox8.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox8.SkinTxt.TabIndex = 0;
            this.textBox8.SkinTxt.Text = "skinTextBox1";
            this.textBox8.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox8.SkinTxt.WaterText = "";
            this.textBox8.TabIndex = 50;
            this.textBox8.Text = "skinTextBox1";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox8.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox8.WaterText = "";
            this.textBox8.WordWrap = true;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Transparent;
            this.textBox9.DownBack = null;
            this.textBox9.Icon = null;
            this.textBox9.IconIsButton = false;
            this.textBox9.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox9.IsPasswordChat = '\0';
            this.textBox9.IsSystemPasswordChar = false;
            this.textBox9.Lines = new string[] {
        "skinTextBox1"};
            this.textBox9.Location = new System.Drawing.Point(218, 335);
            this.textBox9.Margin = new System.Windows.Forms.Padding(0);
            this.textBox9.MaxLength = 32767;
            this.textBox9.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox9.MouseBack = null;
            this.textBox9.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox9.Multiline = false;
            this.textBox9.Name = "textBox9";
            this.textBox9.NormlBack = null;
            this.textBox9.Padding = new System.Windows.Forms.Padding(5);
            this.textBox9.ReadOnly = false;
            this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox9.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox9.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox9.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox9.SkinTxt.Name = "BaseText";
            this.textBox9.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox9.SkinTxt.TabIndex = 0;
            this.textBox9.SkinTxt.Text = "skinTextBox1";
            this.textBox9.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox9.SkinTxt.WaterText = "";
            this.textBox9.TabIndex = 50;
            this.textBox9.Text = "skinTextBox1";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox9.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox9.WaterText = "";
            this.textBox9.WordWrap = true;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Transparent;
            this.textBox10.DownBack = null;
            this.textBox10.Icon = null;
            this.textBox10.IconIsButton = false;
            this.textBox10.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox10.IsPasswordChat = '\0';
            this.textBox10.IsSystemPasswordChar = false;
            this.textBox10.Lines = new string[] {
        "skinTextBox1"};
            this.textBox10.Location = new System.Drawing.Point(218, 363);
            this.textBox10.Margin = new System.Windows.Forms.Padding(0);
            this.textBox10.MaxLength = 32767;
            this.textBox10.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox10.MouseBack = null;
            this.textBox10.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox10.Multiline = false;
            this.textBox10.Name = "textBox10";
            this.textBox10.NormlBack = null;
            this.textBox10.Padding = new System.Windows.Forms.Padding(5);
            this.textBox10.ReadOnly = false;
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox10.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox10.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox10.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox10.SkinTxt.Name = "BaseText";
            this.textBox10.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox10.SkinTxt.TabIndex = 0;
            this.textBox10.SkinTxt.Text = "skinTextBox1";
            this.textBox10.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox10.SkinTxt.WaterText = "";
            this.textBox10.TabIndex = 50;
            this.textBox10.Text = "skinTextBox1";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox10.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox10.WaterText = "";
            this.textBox10.WordWrap = true;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Transparent;
            this.textBox11.DownBack = null;
            this.textBox11.Icon = null;
            this.textBox11.IconIsButton = false;
            this.textBox11.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox11.IsPasswordChat = '\0';
            this.textBox11.IsSystemPasswordChar = false;
            this.textBox11.Lines = new string[] {
        "skinTextBox1"};
            this.textBox11.Location = new System.Drawing.Point(218, 391);
            this.textBox11.Margin = new System.Windows.Forms.Padding(0);
            this.textBox11.MaxLength = 32767;
            this.textBox11.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox11.MouseBack = null;
            this.textBox11.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox11.Multiline = false;
            this.textBox11.Name = "textBox11";
            this.textBox11.NormlBack = null;
            this.textBox11.Padding = new System.Windows.Forms.Padding(5);
            this.textBox11.ReadOnly = false;
            this.textBox11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox11.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox11.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox11.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox11.SkinTxt.Name = "BaseText";
            this.textBox11.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox11.SkinTxt.TabIndex = 0;
            this.textBox11.SkinTxt.Text = "skinTextBox1";
            this.textBox11.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox11.SkinTxt.WaterText = "";
            this.textBox11.TabIndex = 50;
            this.textBox11.Text = "skinTextBox1";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox11.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox11.WaterText = "";
            this.textBox11.WordWrap = true;
            // 
            // Form_StationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1233, 705);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupTimeShow);
            this.Name = "Form_StationInfo";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupTimeShow.ResumeLayout(false);
            this.groupTimeShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinButton btnClose;
        private CCWin.SkinControl.SkinGroupBox groupTimeShow;
        private CCWin.SkinControl.SkinLabel labelTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private CCWin.SkinControl.SkinLabel label10;
        private CCWin.SkinControl.SkinLabel label9;
        private CCWin.SkinControl.SkinLabel label8;
        private CCWin.SkinControl.SkinLabel label11;
        private CCWin.SkinControl.SkinLabel label7;
        private CCWin.SkinControl.SkinLabel label6;
        private CCWin.SkinControl.SkinLabel label5;
        private CCWin.SkinControl.SkinLabel label4;
        private CCWin.SkinControl.SkinLabel label3;
        private CCWin.SkinControl.SkinLabel label2;
        private CCWin.SkinControl.SkinLabel label1;
        private CCWin.SkinControl.SkinLabel label0;
        private CCWin.SkinControl.SkinTextBox textBox0;
        private CCWin.SkinControl.SkinTextBox textBox1;
        private CCWin.SkinControl.SkinTextBox textBox2;
        private CCWin.SkinControl.SkinTextBox textBox3;
        private CCWin.SkinControl.SkinTextBox textBox4;
        private CCWin.SkinControl.SkinTextBox textBox5;
        private CCWin.SkinControl.SkinTextBox textBox6;
        private CCWin.SkinControl.SkinTextBox textBox7;
        private CCWin.SkinControl.SkinTextBox textBox8;
        private CCWin.SkinControl.SkinTextBox textBox9;
        private CCWin.SkinControl.SkinTextBox textBox10;
        private CCWin.SkinControl.SkinTextBox textBox11;
    }
}