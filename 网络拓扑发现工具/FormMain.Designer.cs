namespace 网络拓扑发现工具
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为当前拓扑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_showall = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_timerCheck = new System.Windows.Forms.CheckBox();
            this.txt_xhinterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar_01 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_checkhostname = new System.Windows.Forms.CheckBox();
            this.cb_checkmac = new System.Windows.Forms.CheckBox();
            this.cb_ping = new System.Windows.Forms.CheckBox();
            this.txt_dnstimeout = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_icmptimeout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ipend = new System.Windows.Forms.TextBox();
            this.txt_ipstart = new System.Windows.Forms.TextBox();
            this.btn_startscan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel_draw = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.panel0001 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_sums = new System.Windows.Forms.Label();
            this.lbl_yellow = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.timer_ping = new System.Windows.Forms.Timer(this.components);
            this.uiRoundPanel2 = new 网络拓扑发现工具.UI.UIRoundPanel();
            this.uiRoundPanel1 = new 网络拓扑发现工具.UI.UIRoundPanel();
            this.urp_status = new 网络拓扑发现工具.UI.UIRoundPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel_draw.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel0001.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1239, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.另存为当前拓扑ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 另存为当前拓扑ToolStripMenuItem
            // 
            this.另存为当前拓扑ToolStripMenuItem.Name = "另存为当前拓扑ToolStripMenuItem";
            this.另存为当前拓扑ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.另存为当前拓扑ToolStripMenuItem.Text = "另存为当前拓扑";
            this.另存为当前拓扑ToolStripMenuItem.Click += new System.EventHandler(this.另存为当前拓扑ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于软件ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 关于软件ToolStripMenuItem
            // 
            this.关于软件ToolStripMenuItem.Name = "关于软件ToolStripMenuItem";
            this.关于软件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于软件ToolStripMenuItem.Text = "关于软件";
            this.关于软件ToolStripMenuItem.Click += new System.EventHandler(this.关于软件ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_showall);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.progressBar_01);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_ipend);
            this.panel1.Controls.Add(this.txt_ipstart);
            this.panel1.Controls.Add(this.btn_startscan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 69);
            this.panel1.TabIndex = 1;
            // 
            // cb_showall
            // 
            this.cb_showall.AutoSize = true;
            this.cb_showall.Location = new System.Drawing.Point(5, 39);
            this.cb_showall.Name = "cb_showall";
            this.cb_showall.Size = new System.Drawing.Size(72, 16);
            this.cb_showall.TabIndex = 7;
            this.cb_showall.Text = "显示所有";
            this.cb_showall.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_timerCheck);
            this.groupBox3.Controls.Add(this.txt_xhinterval);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(886, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 58);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "定时检测(ICMP Ping)";
            // 
            // cb_timerCheck
            // 
            this.cb_timerCheck.AutoSize = true;
            this.cb_timerCheck.Location = new System.Drawing.Point(9, 15);
            this.cb_timerCheck.Name = "cb_timerCheck";
            this.cb_timerCheck.Size = new System.Drawing.Size(48, 16);
            this.cb_timerCheck.TabIndex = 13;
            this.cb_timerCheck.Text = "启用";
            this.cb_timerCheck.UseVisualStyleBackColor = true;
            this.cb_timerCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_xhinterval
            // 
            this.txt_xhinterval.Location = new System.Drawing.Point(80, 31);
            this.txt_xhinterval.Name = "txt_xhinterval";
            this.txt_xhinterval.Size = new System.Drawing.Size(53, 21);
            this.txt_xhinterval.TabIndex = 12;
            this.txt_xhinterval.Text = "5000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "间隔(ms)：";
            // 
            // progressBar_01
            // 
            this.progressBar_01.Location = new System.Drawing.Point(278, 49);
            this.progressBar_01.Name = "progressBar_01";
            this.progressBar_01.Size = new System.Drawing.Size(112, 10);
            this.progressBar_01.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_checkhostname);
            this.groupBox2.Controls.Add(this.cb_checkmac);
            this.groupBox2.Controls.Add(this.cb_ping);
            this.groupBox2.Controls.Add(this.txt_dnstimeout);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_icmptimeout);
            this.groupBox2.Location = new System.Drawing.Point(396, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 59);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // cb_checkhostname
            // 
            this.cb_checkhostname.AutoSize = true;
            this.cb_checkhostname.Location = new System.Drawing.Point(371, 12);
            this.cb_checkhostname.Name = "cb_checkhostname";
            this.cb_checkhostname.Size = new System.Drawing.Size(96, 16);
            this.cb_checkhostname.TabIndex = 11;
            this.cb_checkhostname.Text = "检查HostName";
            this.cb_checkhostname.UseVisualStyleBackColor = true;
            // 
            // cb_checkmac
            // 
            this.cb_checkmac.AutoSize = true;
            this.cb_checkmac.Checked = true;
            this.cb_checkmac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_checkmac.Location = new System.Drawing.Point(254, 34);
            this.cb_checkmac.Name = "cb_checkmac";
            this.cb_checkmac.Size = new System.Drawing.Size(90, 16);
            this.cb_checkmac.TabIndex = 10;
            this.cb_checkmac.Text = "检查MAC地址";
            this.cb_checkmac.UseVisualStyleBackColor = true;
            // 
            // cb_ping
            // 
            this.cb_ping.AutoSize = true;
            this.cb_ping.Checked = true;
            this.cb_ping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ping.Location = new System.Drawing.Point(254, 12);
            this.cb_ping.Name = "cb_ping";
            this.cb_ping.Size = new System.Drawing.Size(102, 16);
            this.cb_ping.TabIndex = 9;
            this.cb_ping.Text = "进行ICMP Ping";
            this.cb_ping.UseVisualStyleBackColor = true;
            // 
            // txt_dnstimeout
            // 
            this.txt_dnstimeout.Location = new System.Drawing.Point(173, 32);
            this.txt_dnstimeout.Name = "txt_dnstimeout";
            this.txt_dnstimeout.Size = new System.Drawing.Size(53, 21);
            this.txt_dnstimeout.TabIndex = 8;
            this.txt_dnstimeout.Text = "400";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNS 反查计算机名超时(ms)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "ICMP 超时时间(ms)：";
            // 
            // txt_icmptimeout
            // 
            this.txt_icmptimeout.Location = new System.Drawing.Point(173, 10);
            this.txt_icmptimeout.Name = "txt_icmptimeout";
            this.txt_icmptimeout.Size = new System.Drawing.Size(53, 21);
            this.txt_icmptimeout.TabIndex = 5;
            this.txt_icmptimeout.Text = "1000";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP地址段：";
            // 
            // txt_ipend
            // 
            this.txt_ipend.Location = new System.Drawing.Point(87, 36);
            this.txt_ipend.Name = "txt_ipend";
            this.txt_ipend.Size = new System.Drawing.Size(184, 21);
            this.txt_ipend.TabIndex = 2;
            this.txt_ipend.Text = "192.168.1.254";
            // 
            // txt_ipstart
            // 
            this.txt_ipstart.Location = new System.Drawing.Point(87, 9);
            this.txt_ipstart.Name = "txt_ipstart";
            this.txt_ipstart.Size = new System.Drawing.Size(184, 21);
            this.txt_ipstart.TabIndex = 1;
            this.txt_ipstart.Text = "192.168.1.1";
            // 
            // btn_startscan
            // 
            this.btn_startscan.Location = new System.Drawing.Point(278, 9);
            this.btn_startscan.Name = "btn_startscan";
            this.btn_startscan.Size = new System.Drawing.Size(112, 34);
            this.btn_startscan.TabIndex = 0;
            this.btn_startscan.Text = "开始扫描";
            this.btn_startscan.UseVisualStyleBackColor = true;
            this.btn_startscan.Click += new System.EventHandler(this.btn_startscan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 437);
            this.panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel0001);
            this.splitContainer1.Size = new System.Drawing.Size(1239, 437);
            this.splitContainer1.SplitterDistance = 1064;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel_draw);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel5);
            this.splitContainer2.Size = new System.Drawing.Size(1064, 437);
            this.splitContainer2.SplitterDistance = 287;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel_draw
            // 
            this.panel_draw.BackColor = System.Drawing.Color.White;
            this.panel_draw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_draw.Controls.Add(this.flowLayoutPanel_1);
            this.panel_draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_draw.Location = new System.Drawing.Point(0, 0);
            this.panel_draw.Name = "panel_draw";
            this.panel_draw.Size = new System.Drawing.Size(1064, 287);
            this.panel_draw.TabIndex = 2;
            // 
            // flowLayoutPanel_1
            // 
            this.flowLayoutPanel_1.AutoScroll = true;
            this.flowLayoutPanel_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_1.Name = "flowLayoutPanel_1";
            this.flowLayoutPanel_1.Size = new System.Drawing.Size(1062, 285);
            this.flowLayoutPanel_1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1064, 146);
            this.panel5.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_log);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运行日志";
            // 
            // rtb_log
            // 
            this.rtb_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_log.Location = new System.Drawing.Point(3, 17);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.Size = new System.Drawing.Size(1056, 124);
            this.rtb_log.TabIndex = 0;
            this.rtb_log.Text = "";
            // 
            // panel0001
            // 
            this.panel0001.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel0001.Controls.Add(this.label6);
            this.panel0001.Controls.Add(this.lbl_sums);
            this.panel0001.Controls.Add(this.lbl_yellow);
            this.panel0001.Controls.Add(this.lbl_green);
            this.panel0001.Controls.Add(this.uiRoundPanel2);
            this.panel0001.Controls.Add(this.uiRoundPanel1);
            this.panel0001.Controls.Add(this.lbl_red);
            this.panel0001.Controls.Add(this.urp_status);
            this.panel0001.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel0001.Location = new System.Drawing.Point(0, 0);
            this.panel0001.Name = "panel0001";
            this.panel0001.Size = new System.Drawing.Size(171, 437);
            this.panel0001.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "共计：";
            // 
            // lbl_sums
            // 
            this.lbl_sums.AutoSize = true;
            this.lbl_sums.Location = new System.Drawing.Point(80, 160);
            this.lbl_sums.Name = "lbl_sums";
            this.lbl_sums.Size = new System.Drawing.Size(29, 12);
            this.lbl_sums.TabIndex = 5;
            this.lbl_sums.Text = "0 台";
            // 
            // lbl_yellow
            // 
            this.lbl_yellow.AutoSize = true;
            this.lbl_yellow.Location = new System.Drawing.Point(79, 86);
            this.lbl_yellow.Name = "lbl_yellow";
            this.lbl_yellow.Size = new System.Drawing.Size(29, 12);
            this.lbl_yellow.TabIndex = 4;
            this.lbl_yellow.Text = "0 台";
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Location = new System.Drawing.Point(79, 49);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(29, 12);
            this.lbl_green.TabIndex = 3;
            this.lbl_green.Text = "0 台";
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Location = new System.Drawing.Point(80, 123);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(29, 12);
            this.lbl_red.TabIndex = 2;
            this.lbl_red.Text = "0 台";
            // 
            // timer_ping
            // 
            this.timer_ping.Tick += new System.EventHandler(this.timer_ping_Tick);
            // 
            // uiRoundPanel2
            // 
            this.uiRoundPanel2._setRoundRadius = 20;
            this.uiRoundPanel2.BackColor = System.Drawing.Color.Yellow;
            this.uiRoundPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiRoundPanel2.Location = new System.Drawing.Point(32, 78);
            this.uiRoundPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiRoundPanel2.Name = "uiRoundPanel2";
            this.uiRoundPanel2.Size = new System.Drawing.Size(20, 20);
            this.uiRoundPanel2.TabIndex = 2;
            // 
            // uiRoundPanel1
            // 
            this.uiRoundPanel1._setRoundRadius = 20;
            this.uiRoundPanel1.BackColor = System.Drawing.Color.Green;
            this.uiRoundPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiRoundPanel1.Location = new System.Drawing.Point(32, 46);
            this.uiRoundPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiRoundPanel1.Name = "uiRoundPanel1";
            this.uiRoundPanel1.Size = new System.Drawing.Size(20, 20);
            this.uiRoundPanel1.TabIndex = 2;
            // 
            // urp_status
            // 
            this.urp_status._setRoundRadius = 20;
            this.urp_status.BackColor = System.Drawing.Color.Red;
            this.urp_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.urp_status.Location = new System.Drawing.Point(32, 115);
            this.urp_status.Margin = new System.Windows.Forms.Padding(0);
            this.urp_status.Name = "urp_status";
            this.urp_status.Size = new System.Drawing.Size(20, 20);
            this.urp_status.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "网络拓扑发现工具";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel_draw.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel0001.ResumeLayout(false);
            this.panel0001.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为当前拓扑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于软件ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel0001;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel_draw;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_startscan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ipend;
        private System.Windows.Forms.TextBox txt_ipstart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_log;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_icmptimeout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dnstimeout;
        private System.Windows.Forms.CheckBox cb_checkmac;
        private System.Windows.Forms.CheckBox cb_ping;
        private System.Windows.Forms.CheckBox cb_checkhostname;
        private System.Windows.Forms.ProgressBar progressBar_01;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_xhinterval;
        private System.Windows.Forms.CheckBox cb_timerCheck;
        private System.Windows.Forms.Timer timer_ping;
        private UI.UIRoundPanel urp_status;
        private System.Windows.Forms.Label lbl_yellow;
        private System.Windows.Forms.Label lbl_green;
        private UI.UIRoundPanel uiRoundPanel2;
        private UI.UIRoundPanel uiRoundPanel1;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_sums;
        private System.Windows.Forms.CheckBox cb_showall;
    }
}

