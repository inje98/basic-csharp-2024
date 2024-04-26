namespace MyTimer
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnStopWatch = new Button();
            BtnAlam = new Button();
            BtnWordTime = new Button();
            BtnClose = new Button();
            pMain = new Panel();
            menuStrip1 = new MenuStrip();
            설정ToolStripMenuItem = new ToolStripMenuItem();
            알람ToolStripMenuItem = new ToolStripMenuItem();
            도움말ToolStripMenuItem = new ToolStripMenuItem();
            TsmAbout = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pMain.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(29, 38, 48);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(pMain, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94.1102753F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.88972425F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(1079, 732);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.245018F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2450151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2450151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.0199432F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2450151F));
            tableLayoutPanel2.Controls.Add(BtnStopWatch, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnAlam, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnWordTime, 2, 0);
            tableLayoutPanel2.Controls.Add(BtnClose, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 684);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1073, 36);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnStopWatch
            // 
            BtnStopWatch.Dock = DockStyle.Fill;
            BtnStopWatch.Location = new Point(3, 3);
            BtnStopWatch.Name = "BtnStopWatch";
            BtnStopWatch.Size = new Size(146, 30);
            BtnStopWatch.TabIndex = 1;
            BtnStopWatch.Text = "스톱워치";
            BtnStopWatch.UseVisualStyleBackColor = true;
            BtnStopWatch.Click += BtnStopWatch_Click;
            // 
            // BtnAlam
            // 
            BtnAlam.Dock = DockStyle.Fill;
            BtnAlam.Location = new Point(155, 3);
            BtnAlam.Name = "BtnAlam";
            BtnAlam.Size = new Size(146, 30);
            BtnAlam.TabIndex = 2;
            BtnAlam.Text = "알람";
            BtnAlam.UseVisualStyleBackColor = true;
            BtnAlam.Click += BtnTimer_Click;
            // 
            // BtnWordTime
            // 
            BtnWordTime.Dock = DockStyle.Fill;
            BtnWordTime.Location = new Point(307, 3);
            BtnWordTime.Name = "BtnWordTime";
            BtnWordTime.Size = new Size(146, 30);
            BtnWordTime.TabIndex = 3;
            BtnWordTime.Text = "세계시각";
            BtnWordTime.UseVisualStyleBackColor = true;
            BtnWordTime.Click += BtnWordTime_Click;
            // 
            // BtnClose
            // 
            BtnClose.Dock = DockStyle.Fill;
            BtnClose.Location = new Point(920, 3);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(150, 30);
            BtnClose.TabIndex = 4;
            BtnClose.Text = "나가기";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // pMain
            // 
            pMain.BackColor = Color.FromArgb(29, 38, 48);
            pMain.Controls.Add(menuStrip1);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(3, 3);
            pMain.Name = "pMain";
            pMain.Size = new Size(1073, 675);
            pMain.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 설정ToolStripMenuItem, 도움말ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1073, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            설정ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 알람ToolStripMenuItem });
            설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            설정ToolStripMenuItem.Size = new Size(43, 20);
            설정ToolStripMenuItem.Text = "설정";
            // 
            // 알람ToolStripMenuItem
            // 
            알람ToolStripMenuItem.Name = "알람ToolStripMenuItem";
            알람ToolStripMenuItem.Size = new Size(98, 22);
            알람ToolStripMenuItem.Text = "알람";
            // 
            // 도움말ToolStripMenuItem
            // 
            도움말ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TsmAbout });
            도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            도움말ToolStripMenuItem.Size = new Size(55, 20);
            도움말ToolStripMenuItem.Text = "도움말";
            // 
            // TsmAbout
            // 
            TsmAbout.Name = "TsmAbout";
            TsmAbout.Size = new Size(180, 22);
            TsmAbout.Text = "이 프로그램은...";
            TsmAbout.Click += TsmAbout_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 38, 48);
            ClientSize = new Size(1079, 732);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            pMain.ResumeLayout(false);
            pMain.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnStopWatch;
        private Button BtnAlam;
        private Button BtnWordTime;
        private Button BtnClose;
        private Panel pMain;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 설정ToolStripMenuItem;
        private ToolStripMenuItem 알람ToolStripMenuItem;
        private ToolStripMenuItem 도움말ToolStripMenuItem;
        private ToolStripMenuItem TsmAbout;
    }
}
