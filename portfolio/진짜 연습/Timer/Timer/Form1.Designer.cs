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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            TsmSelect = new ToolStripMenuItem();
            TsmTimer = new ToolStripMenuItem();
            TsmStopWatch = new ToolStripMenuItem();
            TsmWorldTime = new ToolStripMenuItem();
            도움말ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            StlTimer = new ToolStripLabel();
            StlStopwatch = new ToolStripLabel();
            StlWorldTime = new ToolStripLabel();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TsmSelect, 도움말ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TsmSelect
            // 
            TsmSelect.DropDownItems.AddRange(new ToolStripItem[] { TsmTimer, TsmStopWatch, TsmWorldTime });
            TsmSelect.Name = "TsmSelect";
            TsmSelect.Size = new Size(43, 20);
            TsmSelect.Text = "보기";
            // 
            // TsmTimer
            // 
            TsmTimer.Name = "TsmTimer";
            TsmTimer.Size = new Size(122, 22);
            TsmTimer.Text = "타이머";
            // 
            // TsmStopWatch
            // 
            TsmStopWatch.Name = "TsmStopWatch";
            TsmStopWatch.Size = new Size(122, 22);
            TsmStopWatch.Text = "스톱워치";
            // 
            // TsmWorldTime
            // 
            TsmWorldTime.Name = "TsmWorldTime";
            TsmWorldTime.Size = new Size(122, 22);
            TsmWorldTime.Text = "세계시각";
            // 
            // 도움말ToolStripMenuItem
            // 
            도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            도움말ToolStripMenuItem.Size = new Size(55, 20);
            도움말ToolStripMenuItem.Text = "도움말";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { StlTimer, StlStopwatch, StlWorldTime });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // StlTimer
            // 
            StlTimer.Name = "StlTimer";
            StlTimer.Size = new Size(43, 22);
            StlTimer.Text = "타이머";
            StlTimer.Click += StlTimer_Click;
            // 
            // StlStopwatch
            // 
            StlStopwatch.Name = "StlStopwatch";
            StlStopwatch.Size = new Size(55, 22);
            StlStopwatch.Text = "스탑워치";
            StlStopwatch.Click += StlStopwatch_Click;
            // 
            // StlWorldTime
            // 
            StlWorldTime.Name = "StlWorldTime";
            StlWorldTime.Size = new Size(55, 22);
            StlWorldTime.Text = "세계시각";
            StlWorldTime.Click += StlWorldTime_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 395);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TsmSelect;
        private ToolStripMenuItem TsmTimer;
        private ToolStripMenuItem TsmStopWatch;
        private ToolStripMenuItem TsmWorldTime;
        private ToolStripMenuItem 도움말ToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel StlTimer;
        private ToolStripLabel StlStopwatch;
        private ToolStripLabel StlWorldTime;
        private Panel panel1;
    }
}
