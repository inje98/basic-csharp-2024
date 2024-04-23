namespace Timer
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnStopWatch = new Button();
            BtnTimer = new Button();
            BtnWordTime = new Button();
            BtnClose = new Button();
            pMain = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pMain.SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.49489F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5051088F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(1179, 807);
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
            tableLayoutPanel2.Controls.Add(BtnTimer, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnWordTime, 2, 0);
            tableLayoutPanel2.Controls.Add(BtnClose, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 718);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1173, 77);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnStopWatch
            // 
            BtnStopWatch.Dock = DockStyle.Fill;
            BtnStopWatch.Location = new Point(3, 3);
            BtnStopWatch.Name = "BtnStopWatch";
            BtnStopWatch.Size = new Size(161, 71);
            BtnStopWatch.TabIndex = 1;
            BtnStopWatch.Text = "스톱워치";
            BtnStopWatch.UseVisualStyleBackColor = true;
            BtnStopWatch.Click += BtnStopWatch_Click;
            // 
            // BtnTimer
            // 
            BtnTimer.Dock = DockStyle.Fill;
            BtnTimer.Location = new Point(170, 3);
            BtnTimer.Name = "BtnTimer";
            BtnTimer.Size = new Size(161, 71);
            BtnTimer.TabIndex = 2;
            BtnTimer.Text = "타이머";
            BtnTimer.UseVisualStyleBackColor = true;
            BtnTimer.Click += BtnTimer_Click;
            // 
            // BtnWordTime
            // 
            BtnWordTime.Dock = DockStyle.Fill;
            BtnWordTime.Location = new Point(337, 3);
            BtnWordTime.Name = "BtnWordTime";
            BtnWordTime.Size = new Size(161, 71);
            BtnWordTime.TabIndex = 3;
            BtnWordTime.Text = "세계시각";
            BtnWordTime.UseVisualStyleBackColor = true;
            BtnWordTime.Click += BtnWordTime_Click;
            // 
            // BtnClose
            // 
            BtnClose.Dock = DockStyle.Fill;
            BtnClose.Location = new Point(1008, 3);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(162, 71);
            BtnClose.TabIndex = 4;
            BtnClose.Text = "나가기";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // pMain
            // 
            pMain.BackColor = Color.FromArgb(29, 38, 48);
            pMain.Controls.Add(panel1);
            pMain.Dock = DockStyle.Fill;
            pMain.Location = new Point(3, 3);
            pMain.Name = "pMain";
            pMain.Size = new Size(1173, 709);
            pMain.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 704);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 5);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 807);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            pMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnStopWatch;
        private Button BtnTimer;
        private Button BtnWordTime;
        private Button BtnClose;
        private Panel pMain;
        private Panel panel1;
    }
}
