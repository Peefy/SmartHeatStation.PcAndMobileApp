namespace 流量计检定上位机
{
    partial class Form_FindData
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
            this.labelFindCount = new CCWin.SkinControl.SkinLabel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel13 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel19 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel20 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel21 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel22 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel23 = new CCWin.SkinControl.SkinLabel();
            this.Label一网 = new CCWin.SkinControl.SkinLabel();
            this.Label二网高区 = new CCWin.SkinControl.SkinLabel();
            this.Label二网中区 = new CCWin.SkinControl.SkinLabel();
            this.Label二网低区 = new CCWin.SkinControl.SkinLabel();
            this.Label水箱 = new CCWin.SkinControl.SkinLabel();
            this.Label水箱2 = new CCWin.SkinControl.SkinLabel();
            this.Label水箱进水阀 = new CCWin.SkinControl.SkinLabel();
            this.Label总调节阀 = new CCWin.SkinControl.SkinLabel();
            this.Label热量流量表 = new CCWin.SkinControl.SkinLabel();
            this.Label泵0 = new CCWin.SkinControl.SkinLabel();
            this.Label泵1 = new CCWin.SkinControl.SkinLabel();
            this.Label泵2 = new CCWin.SkinControl.SkinLabel();
            this.Label泵3 = new CCWin.SkinControl.SkinLabel();
            this.Label泵4 = new CCWin.SkinControl.SkinLabel();
            this.Label泵5 = new CCWin.SkinControl.SkinLabel();
            this.Label泵6 = new CCWin.SkinControl.SkinLabel();
            this.Label泵7 = new CCWin.SkinControl.SkinLabel();
            this.Label泵8 = new CCWin.SkinControl.SkinLabel();
            this.Label泵9 = new CCWin.SkinControl.SkinLabel();
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
            this.btnClose.Size = new System.Drawing.Size(161, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "确定";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelFindCount
            // 
            this.labelFindCount.AutoSize = true;
            this.labelFindCount.BackColor = System.Drawing.Color.Transparent;
            this.labelFindCount.BorderColor = System.Drawing.Color.White;
            this.labelFindCount.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFindCount.Location = new System.Drawing.Point(11, 81);
            this.labelFindCount.Name = "labelFindCount";
            this.labelFindCount.Size = new System.Drawing.Size(96, 28);
            this.labelFindCount.TabIndex = 1;
            this.labelFindCount.Text = "一网参数";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(11, 109);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(138, 28);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "二网高区参数";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(11, 137);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(138, 28);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "二网中区参数";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(11, 165);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(138, 28);
            this.skinLabel3.TabIndex = 1;
            this.skinLabel3.Text = "二网低区参数";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(11, 193);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(96, 28);
            this.skinLabel4.TabIndex = 1;
            this.skinLabel4.Text = "水箱参数";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(11, 221);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(109, 28);
            this.skinLabel5.TabIndex = 1;
            this.skinLabel5.Text = "水箱2参数";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(11, 249);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(159, 28);
            this.skinLabel6.TabIndex = 1;
            this.skinLabel6.Text = "水箱进水阀参数";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(11, 277);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(138, 28);
            this.skinLabel7.TabIndex = 1;
            this.skinLabel7.Text = "总调节阀参数";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(11, 305);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(117, 28);
            this.skinLabel8.TabIndex = 1;
            this.skinLabel8.Text = "流量热量表";
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(11, 333);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(46, 28);
            this.skinLabel9.TabIndex = 1;
            this.skinLabel9.Text = "泵0";
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(11, 361);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(46, 28);
            this.skinLabel10.TabIndex = 1;
            this.skinLabel10.Text = "泵1";
            // 
            // skinLabel11
            // 
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(11, 389);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(46, 28);
            this.skinLabel11.TabIndex = 1;
            this.skinLabel11.Text = "泵2";
            // 
            // skinLabel12
            // 
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.Location = new System.Drawing.Point(11, 417);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(46, 28);
            this.skinLabel12.TabIndex = 1;
            this.skinLabel12.Text = "泵3";
            // 
            // skinLabel13
            // 
            this.skinLabel13.AutoSize = true;
            this.skinLabel13.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel13.BorderColor = System.Drawing.Color.White;
            this.skinLabel13.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel13.Location = new System.Drawing.Point(11, 445);
            this.skinLabel13.Name = "skinLabel13";
            this.skinLabel13.Size = new System.Drawing.Size(46, 28);
            this.skinLabel13.TabIndex = 1;
            this.skinLabel13.Text = "泵4";
            // 
            // skinLabel19
            // 
            this.skinLabel19.AutoSize = true;
            this.skinLabel19.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel19.BorderColor = System.Drawing.Color.White;
            this.skinLabel19.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel19.Location = new System.Drawing.Point(11, 475);
            this.skinLabel19.Name = "skinLabel19";
            this.skinLabel19.Size = new System.Drawing.Size(46, 28);
            this.skinLabel19.TabIndex = 1;
            this.skinLabel19.Text = "泵5";
            // 
            // skinLabel20
            // 
            this.skinLabel20.AutoSize = true;
            this.skinLabel20.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel20.BorderColor = System.Drawing.Color.White;
            this.skinLabel20.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel20.Location = new System.Drawing.Point(11, 503);
            this.skinLabel20.Name = "skinLabel20";
            this.skinLabel20.Size = new System.Drawing.Size(46, 28);
            this.skinLabel20.TabIndex = 1;
            this.skinLabel20.Text = "泵6";
            // 
            // skinLabel21
            // 
            this.skinLabel21.AutoSize = true;
            this.skinLabel21.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel21.BorderColor = System.Drawing.Color.White;
            this.skinLabel21.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel21.Location = new System.Drawing.Point(11, 531);
            this.skinLabel21.Name = "skinLabel21";
            this.skinLabel21.Size = new System.Drawing.Size(46, 28);
            this.skinLabel21.TabIndex = 1;
            this.skinLabel21.Text = "泵7";
            // 
            // skinLabel22
            // 
            this.skinLabel22.AutoSize = true;
            this.skinLabel22.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel22.BorderColor = System.Drawing.Color.White;
            this.skinLabel22.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel22.Location = new System.Drawing.Point(11, 559);
            this.skinLabel22.Name = "skinLabel22";
            this.skinLabel22.Size = new System.Drawing.Size(46, 28);
            this.skinLabel22.TabIndex = 1;
            this.skinLabel22.Text = "泵8";
            // 
            // skinLabel23
            // 
            this.skinLabel23.AutoSize = true;
            this.skinLabel23.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel23.BorderColor = System.Drawing.Color.White;
            this.skinLabel23.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel23.Location = new System.Drawing.Point(11, 587);
            this.skinLabel23.Name = "skinLabel23";
            this.skinLabel23.Size = new System.Drawing.Size(46, 28);
            this.skinLabel23.TabIndex = 1;
            this.skinLabel23.Text = "泵9";
            // 
            // Label一网
            // 
            this.Label一网.AutoSize = true;
            this.Label一网.BackColor = System.Drawing.Color.Transparent;
            this.Label一网.BorderColor = System.Drawing.Color.White;
            this.Label一网.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label一网.Location = new System.Drawing.Point(179, 81);
            this.Label一网.Name = "Label一网";
            this.Label一网.Size = new System.Drawing.Size(96, 28);
            this.Label一网.TabIndex = 1;
            this.Label一网.Tag = "0";
            this.Label一网.Text = "一网参数";
            this.Label一网.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label二网高区
            // 
            this.Label二网高区.AutoSize = true;
            this.Label二网高区.BackColor = System.Drawing.Color.Transparent;
            this.Label二网高区.BorderColor = System.Drawing.Color.White;
            this.Label二网高区.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label二网高区.Location = new System.Drawing.Point(179, 109);
            this.Label二网高区.Name = "Label二网高区";
            this.Label二网高区.Size = new System.Drawing.Size(96, 28);
            this.Label二网高区.TabIndex = 1;
            this.Label二网高区.Tag = "1";
            this.Label二网高区.Text = "一网参数";
            this.Label二网高区.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label二网中区
            // 
            this.Label二网中区.AutoSize = true;
            this.Label二网中区.BackColor = System.Drawing.Color.Transparent;
            this.Label二网中区.BorderColor = System.Drawing.Color.White;
            this.Label二网中区.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label二网中区.Location = new System.Drawing.Point(179, 137);
            this.Label二网中区.Name = "Label二网中区";
            this.Label二网中区.Size = new System.Drawing.Size(96, 28);
            this.Label二网中区.TabIndex = 1;
            this.Label二网中区.Tag = "2";
            this.Label二网中区.Text = "一网参数";
            this.Label二网中区.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label二网低区
            // 
            this.Label二网低区.AutoSize = true;
            this.Label二网低区.BackColor = System.Drawing.Color.Transparent;
            this.Label二网低区.BorderColor = System.Drawing.Color.White;
            this.Label二网低区.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label二网低区.Location = new System.Drawing.Point(179, 165);
            this.Label二网低区.Name = "Label二网低区";
            this.Label二网低区.Size = new System.Drawing.Size(96, 28);
            this.Label二网低区.TabIndex = 1;
            this.Label二网低区.Tag = "3";
            this.Label二网低区.Text = "一网参数";
            this.Label二网低区.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label水箱
            // 
            this.Label水箱.AutoSize = true;
            this.Label水箱.BackColor = System.Drawing.Color.Transparent;
            this.Label水箱.BorderColor = System.Drawing.Color.White;
            this.Label水箱.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label水箱.Location = new System.Drawing.Point(179, 193);
            this.Label水箱.Name = "Label水箱";
            this.Label水箱.Size = new System.Drawing.Size(96, 28);
            this.Label水箱.TabIndex = 1;
            this.Label水箱.Tag = "4";
            this.Label水箱.Text = "一网参数";
            this.Label水箱.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label水箱2
            // 
            this.Label水箱2.AutoSize = true;
            this.Label水箱2.BackColor = System.Drawing.Color.Transparent;
            this.Label水箱2.BorderColor = System.Drawing.Color.White;
            this.Label水箱2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label水箱2.Location = new System.Drawing.Point(179, 221);
            this.Label水箱2.Name = "Label水箱2";
            this.Label水箱2.Size = new System.Drawing.Size(96, 28);
            this.Label水箱2.TabIndex = 1;
            this.Label水箱2.Tag = "5";
            this.Label水箱2.Text = "一网参数";
            this.Label水箱2.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label水箱进水阀
            // 
            this.Label水箱进水阀.AutoSize = true;
            this.Label水箱进水阀.BackColor = System.Drawing.Color.Transparent;
            this.Label水箱进水阀.BorderColor = System.Drawing.Color.White;
            this.Label水箱进水阀.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label水箱进水阀.Location = new System.Drawing.Point(179, 249);
            this.Label水箱进水阀.Name = "Label水箱进水阀";
            this.Label水箱进水阀.Size = new System.Drawing.Size(96, 28);
            this.Label水箱进水阀.TabIndex = 1;
            this.Label水箱进水阀.Tag = "6";
            this.Label水箱进水阀.Text = "一网参数";
            this.Label水箱进水阀.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label总调节阀
            // 
            this.Label总调节阀.AutoSize = true;
            this.Label总调节阀.BackColor = System.Drawing.Color.Transparent;
            this.Label总调节阀.BorderColor = System.Drawing.Color.White;
            this.Label总调节阀.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label总调节阀.Location = new System.Drawing.Point(179, 277);
            this.Label总调节阀.Name = "Label总调节阀";
            this.Label总调节阀.Size = new System.Drawing.Size(96, 28);
            this.Label总调节阀.TabIndex = 1;
            this.Label总调节阀.Tag = "7";
            this.Label总调节阀.Text = "一网参数";
            this.Label总调节阀.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label热量流量表
            // 
            this.Label热量流量表.AutoSize = true;
            this.Label热量流量表.BackColor = System.Drawing.Color.Transparent;
            this.Label热量流量表.BorderColor = System.Drawing.Color.White;
            this.Label热量流量表.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label热量流量表.Location = new System.Drawing.Point(179, 305);
            this.Label热量流量表.Name = "Label热量流量表";
            this.Label热量流量表.Size = new System.Drawing.Size(96, 28);
            this.Label热量流量表.TabIndex = 1;
            this.Label热量流量表.Tag = "8";
            this.Label热量流量表.Text = "一网参数";
            this.Label热量流量表.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label泵0
            // 
            this.Label泵0.AutoSize = true;
            this.Label泵0.BackColor = System.Drawing.Color.Transparent;
            this.Label泵0.BorderColor = System.Drawing.Color.White;
            this.Label泵0.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label泵0.Location = new System.Drawing.Point(179, 333);
            this.Label泵0.Name = "Label泵0";
            this.Label泵0.Size = new System.Drawing.Size(96, 28);
            this.Label泵0.TabIndex = 1;
            this.Label泵0.Tag = "9";
            this.Label泵0.Text = "一网参数";
            this.Label泵0.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label泵1
            // 
            this.Label泵1.AutoSize = true;
            this.Label泵1.BackColor = System.Drawing.Color.Transparent;
            this.Label泵1.BorderColor = System.Drawing.Color.White;
            this.Label泵1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label泵1.Location = new System.Drawing.Point(179, 361);
            this.Label泵1.Name = "Label泵1";
            this.Label泵1.Size = new System.Drawing.Size(96, 28);
            this.Label泵1.TabIndex = 1;
            this.Label泵1.Tag = "10";
            this.Label泵1.Text = "一网参数";
            this.Label泵1.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label泵2
            // 
            this.Label泵2.AutoSize = true;
            this.Label泵2.BackColor = System.Drawing.Color.Transparent;
            this.Label泵2.BorderColor = System.Drawing.Color.White;
            this.Label泵2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label泵2.Location = new System.Drawing.Point(179, 389);
            this.Label泵2.Name = "Label泵2";
            this.Label泵2.Size = new System.Drawing.Size(96, 28);
            this.Label泵2.TabIndex = 1;
            this.Label泵2.Tag = "11";
            this.Label泵2.Text = "一网参数";
            this.Label泵2.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label泵3
            // 
            this.Label泵3.AutoSize = true;
            this.Label泵3.BackColor = System.Drawing.Color.Transparent;
            this.Label泵3.BorderColor = System.Drawing.Color.White;
            this.Label泵3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label泵3.Location = new System.Drawing.Point(179, 417);
            this.Label泵3.Name = "Label泵3";
            this.Label泵3.Size = new System.Drawing.Size(96, 28);
            this.Label泵3.TabIndex = 1;
            this.Label泵3.Tag = "12";
            this.Label泵3.Text = "一网参数";
            this.Label泵3.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label泵4
            // 
            this.Label泵4.AutoSize = true;
            this.Label泵4.BackColor = System.Drawing.Color.Transparent;
            this.Label泵4.BorderColor = System.Drawing.Color.White;
            this.Label泵4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label泵4.Location = new System.Drawing.Point(179, 445);
            this.Label泵4.Name = "Label泵4";
            this.Label泵4.Size = new System.Drawing.Size(96, 28);
            this.Label泵4.TabIndex = 1;
            this.Label泵4.Tag = "13";
            this.Label泵4.Text = "一网参数";
            this.Label泵4.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label泵5
            // 
            this.Label泵5.AutoSize = true;
            this.Label泵5.BackColor = System.Drawing.Color.Transparent;
            this.Label泵5.BorderColor = System.Drawing.Color.White;
            this.Label泵5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label泵5.Location = new System.Drawing.Point(179, 475);
            this.Label泵5.Name = "Label泵5";
            this.Label泵5.Size = new System.Drawing.Size(96, 28);
            this.Label泵5.TabIndex = 1;
            this.Label泵5.Tag = "14";
            this.Label泵5.Text = "一网参数";
            this.Label泵5.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label泵6
            // 
            this.Label泵6.AutoSize = true;
            this.Label泵6.BackColor = System.Drawing.Color.Transparent;
            this.Label泵6.BorderColor = System.Drawing.Color.White;
            this.Label泵6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label泵6.Location = new System.Drawing.Point(179, 503);
            this.Label泵6.Name = "Label泵6";
            this.Label泵6.Size = new System.Drawing.Size(96, 28);
            this.Label泵6.TabIndex = 1;
            this.Label泵6.Tag = "15";
            this.Label泵6.Text = "一网参数";
            this.Label泵6.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label泵7
            // 
            this.Label泵7.AutoSize = true;
            this.Label泵7.BackColor = System.Drawing.Color.Transparent;
            this.Label泵7.BorderColor = System.Drawing.Color.White;
            this.Label泵7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label泵7.Location = new System.Drawing.Point(179, 531);
            this.Label泵7.Name = "Label泵7";
            this.Label泵7.Size = new System.Drawing.Size(96, 28);
            this.Label泵7.TabIndex = 1;
            this.Label泵7.Tag = "16";
            this.Label泵7.Text = "一网参数";
            this.Label泵7.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label泵8
            // 
            this.Label泵8.AutoSize = true;
            this.Label泵8.BackColor = System.Drawing.Color.Transparent;
            this.Label泵8.BorderColor = System.Drawing.Color.White;
            this.Label泵8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label泵8.Location = new System.Drawing.Point(179, 559);
            this.Label泵8.Name = "Label泵8";
            this.Label泵8.Size = new System.Drawing.Size(96, 28);
            this.Label泵8.TabIndex = 1;
            this.Label泵8.Tag = "17";
            this.Label泵8.Text = "一网参数";
            this.Label泵8.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Label泵9
            // 
            this.Label泵9.AutoSize = true;
            this.Label泵9.BackColor = System.Drawing.Color.Transparent;
            this.Label泵9.BorderColor = System.Drawing.Color.White;
            this.Label泵9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label泵9.Location = new System.Drawing.Point(179, 587);
            this.Label泵9.Name = "Label泵9";
            this.Label泵9.Size = new System.Drawing.Size(96, 28);
            this.Label泵9.TabIndex = 1;
            this.Label泵9.Tag = "18";
            this.Label泵9.Text = "一网参数";
            this.Label泵9.Click += new System.EventHandler(this.Label一网_Click);
            // 
            // Form_FindData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1233, 705);
            this.ControlBoxActive = System.Drawing.Color.Gray;
            this.ControlBoxDeactive = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.skinLabel23);
            this.Controls.Add(this.skinLabel22);
            this.Controls.Add(this.skinLabel13);
            this.Controls.Add(this.skinLabel21);
            this.Controls.Add(this.skinLabel12);
            this.Controls.Add(this.skinLabel11);
            this.Controls.Add(this.skinLabel20);
            this.Controls.Add(this.skinLabel19);
            this.Controls.Add(this.skinLabel10);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.Label泵9);
            this.Controls.Add(this.Label泵8);
            this.Controls.Add(this.Label泵7);
            this.Controls.Add(this.Label泵6);
            this.Controls.Add(this.Label泵5);
            this.Controls.Add(this.Label泵4);
            this.Controls.Add(this.Label泵3);
            this.Controls.Add(this.Label泵2);
            this.Controls.Add(this.Label泵1);
            this.Controls.Add(this.Label泵0);
            this.Controls.Add(this.Label热量流量表);
            this.Controls.Add(this.Label总调节阀);
            this.Controls.Add(this.Label水箱进水阀);
            this.Controls.Add(this.Label水箱2);
            this.Controls.Add(this.Label水箱);
            this.Controls.Add(this.Label二网低区);
            this.Controls.Add(this.Label二网中区);
            this.Controls.Add(this.Label二网高区);
            this.Controls.Add(this.Label一网);
            this.Controls.Add(this.labelFindCount);
            this.Controls.Add(this.groupTimeShow);
            this.Name = "Form_FindData";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FindData_FormClosed);
            this.Load += new System.EventHandler(this.Form_FindData_Load);
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
        private CCWin.SkinControl.SkinLabel labelFindCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private CCWin.SkinControl.SkinLabel skinLabel13;
        private CCWin.SkinControl.SkinLabel skinLabel19;
        private CCWin.SkinControl.SkinLabel skinLabel20;
        private CCWin.SkinControl.SkinLabel skinLabel21;
        private CCWin.SkinControl.SkinLabel skinLabel22;
        private CCWin.SkinControl.SkinLabel skinLabel23;
        private CCWin.SkinControl.SkinLabel Label一网;
        private CCWin.SkinControl.SkinLabel Label二网高区;
        private CCWin.SkinControl.SkinLabel Label二网中区;
        private CCWin.SkinControl.SkinLabel Label二网低区;
        private CCWin.SkinControl.SkinLabel Label水箱;
        private CCWin.SkinControl.SkinLabel Label水箱2;
        private CCWin.SkinControl.SkinLabel Label水箱进水阀;
        private CCWin.SkinControl.SkinLabel Label总调节阀;
        private CCWin.SkinControl.SkinLabel Label热量流量表;
        private CCWin.SkinControl.SkinLabel Label泵0;
        private CCWin.SkinControl.SkinLabel Label泵1;
        private CCWin.SkinControl.SkinLabel Label泵2;
        private CCWin.SkinControl.SkinLabel Label泵3;
        private CCWin.SkinControl.SkinLabel Label泵4;
        private CCWin.SkinControl.SkinLabel Label泵5;
        private CCWin.SkinControl.SkinLabel Label泵6;
        private CCWin.SkinControl.SkinLabel Label泵7;
        private CCWin.SkinControl.SkinLabel Label泵8;
        private CCWin.SkinControl.SkinLabel Label泵9;
    }
}