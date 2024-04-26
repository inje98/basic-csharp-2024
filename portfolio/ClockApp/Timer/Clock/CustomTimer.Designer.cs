namespace MyTimer.Clock
{
    partial class CustomTimer
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1Min = new System.Windows.Forms.Timer(components);
            NmrHour = new NumericUpDown();
            NmrMin = new NumericUpDown();
            NmrSec = new NumericUpDown();
            groupBox1 = new GroupBox();
            button11 = new Button();
            LblMyTime = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            Min1 = new Label();
            groupBox3 = new GroupBox();
            button9 = new Button();
            button10 = new Button();
            Min3 = new Label();
            groupBox4 = new GroupBox();
            button5 = new Button();
            Min5 = new Label();
            button6 = new Button();
            groupBox5 = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            Min10 = new Label();
            timer3Min = new System.Windows.Forms.Timer(components);
            timer5Min = new System.Windows.Forms.Timer(components);
            timer10Min = new System.Windows.Forms.Timer(components);
            timerMy = new System.Windows.Forms.Timer(components);
            process1 = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)NmrHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NmrMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NmrSec).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // timer1Min
            // 
            timer1Min.Interval = 1000;
            timer1Min.Tick += timer1Min_Tick;
            // 
            // NmrHour
            // 
            NmrHour.Location = new Point(15, 78);
            NmrHour.Name = "NmrHour";
            NmrHour.Size = new Size(120, 23);
            NmrHour.TabIndex = 0;
            // 
            // NmrMin
            // 
            NmrMin.Location = new Point(164, 78);
            NmrMin.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            NmrMin.Name = "NmrMin";
            NmrMin.Size = new Size(120, 23);
            NmrMin.TabIndex = 1;
            // 
            // NmrSec
            // 
            NmrSec.Location = new Point(315, 78);
            NmrSec.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            NmrSec.Name = "NmrSec";
            NmrSec.Size = new Size(120, 23);
            NmrSec.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(LblMyTime);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(NmrSec);
            groupBox1.Controls.Add(NmrMin);
            groupBox1.Controls.Add(NmrHour);
            groupBox1.ForeColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(287, 487);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 154);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "직접 시간설정";
            // 
            // button11
            // 
            button11.ForeColor = Color.Black;
            button11.Location = new Point(466, 78);
            button11.Name = "button11";
            button11.Size = new Size(45, 23);
            button11.TabIndex = 14;
            button11.Text = "확인";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // LblMyTime
            // 
            LblMyTime.AutoSize = true;
            LblMyTime.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            LblMyTime.ForeColor = Color.White;
            LblMyTime.Location = new Point(164, 10);
            LblMyTime.Name = "LblMyTime";
            LblMyTime.Size = new Size(222, 65);
            LblMyTime.TabIndex = 13;
            LblMyTime.Text = "00:00:00";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(271, 116);
            button1.Name = "button1";
            button1.Size = new Size(42, 32);
            button1.TabIndex = 10;
            button1.Text = "다시";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(223, 116);
            button2.Name = "button2";
            button2.Size = new Size(42, 32);
            button2.TabIndex = 9;
            button2.Text = "시작";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(441, 86);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 5;
            label3.Text = "초";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(290, 86);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 4;
            label2.Text = "분";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(141, 86);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 3;
            label1.Text = "시";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(Min1);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(44, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(513, 216);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "1분";
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(266, 144);
            button3.Name = "button3";
            button3.Size = new Size(42, 32);
            button3.TabIndex = 12;
            button3.Text = "다시";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(218, 144);
            button4.Name = "button4";
            button4.Size = new Size(42, 32);
            button4.TabIndex = 11;
            button4.Text = "시작";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Min1
            // 
            Min1.AutoSize = true;
            Min1.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Min1.Location = new Point(151, 39);
            Min1.Name = "Min1";
            Min1.Size = new Size(222, 65);
            Min1.TabIndex = 0;
            Min1.Text = "00:01:00";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(Min3);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(563, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(533, 216);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "3분";
            // 
            // button9
            // 
            button9.ForeColor = Color.Black;
            button9.Location = new Point(290, 144);
            button9.Name = "button9";
            button9.Size = new Size(42, 32);
            button9.TabIndex = 18;
            button9.Text = "다시";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Location = new Point(242, 144);
            button10.Name = "button10";
            button10.Size = new Size(42, 32);
            button10.TabIndex = 17;
            button10.Text = "시작";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Min3
            // 
            Min3.AutoSize = true;
            Min3.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Min3.Location = new Point(165, 39);
            Min3.Name = "Min3";
            Min3.Size = new Size(222, 65);
            Min3.TabIndex = 1;
            Min3.Text = "00:03:00";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(Min5);
            groupBox4.Controls.Add(button6);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(44, 241);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(513, 209);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "5분";
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(266, 135);
            button5.Name = "button5";
            button5.Size = new Size(42, 32);
            button5.TabIndex = 14;
            button5.Text = "다시";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Min5
            // 
            Min5.AutoSize = true;
            Min5.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Min5.Location = new Point(151, 50);
            Min5.Name = "Min5";
            Min5.Size = new Size(222, 65);
            Min5.TabIndex = 2;
            Min5.Text = "00:05:00";
            // 
            // button6
            // 
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(218, 135);
            button6.Name = "button6";
            button6.Size = new Size(42, 32);
            button6.TabIndex = 13;
            button6.Text = "시작";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button8);
            groupBox5.Controls.Add(button7);
            groupBox5.Controls.Add(Min10);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(563, 241);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(533, 209);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "10분";
            // 
            // button8
            // 
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(242, 135);
            button8.Name = "button8";
            button8.Size = new Size(42, 32);
            button8.TabIndex = 15;
            button8.Text = "시작";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.ForeColor = Color.Black;
            button7.Location = new Point(290, 135);
            button7.Name = "button7";
            button7.Size = new Size(42, 32);
            button7.TabIndex = 16;
            button7.Text = "다시";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Min10
            // 
            Min10.AutoSize = true;
            Min10.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Min10.Location = new Point(165, 50);
            Min10.Name = "Min10";
            Min10.Size = new Size(222, 65);
            Min10.TabIndex = 3;
            Min10.Text = "00:10:00";
            // 
            // timer3Min
            // 
            timer3Min.Interval = 1000;
            timer3Min.Tick += timer3Min_Tick;
            // 
            // timer5Min
            // 
            timer5Min.Interval = 1000;
            timer5Min.Tick += timer5Min_Tick;
            // 
            // timer10Min
            // 
            timer10Min.Interval = 1000;
            timer10Min.Tick += timer10Min_Tick;
            // 
            // timerMy
            // 
            timerMy.Interval = 1000;
            timerMy.Tick += timerMy_Tick;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // Timer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 38, 48);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Timer";
            Size = new Size(1126, 653);
            ((System.ComponentModel.ISupportInitialize)NmrHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)NmrMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)NmrSec).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1Min;
        private NumericUpDown NmrHour;
        private NumericUpDown NmrMin;
        private NumericUpDown NmrSec;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label Min1;
        private Label Min3;
        private Label Min5;
        private Label Min10;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer3Min;
        private System.Windows.Forms.Timer timer5Min;
        private System.Windows.Forms.Timer timer10Min;
        private System.Windows.Forms.Timer timerMy;
        private Button button3;
        private Button button4;
        private Button button9;
        private Button button10;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button7;
        private Label LblMyTime;
        private Button button11;
        private System.Diagnostics.Process process1;
    }
}
