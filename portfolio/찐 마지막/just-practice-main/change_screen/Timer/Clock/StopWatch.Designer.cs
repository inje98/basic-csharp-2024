namespace Timer.Clock
{
    partial class StopWatch
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
            LblWhatTime = new Label();
            panel1 = new Panel();
            listView1 = new ListView();
            BtnCheckReset = new Button();
            BtnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LblWhatTime
            // 
            LblWhatTime.AutoSize = true;
            LblWhatTime.Font = new Font("Segoe Print", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblWhatTime.ForeColor = Color.White;
            LblWhatTime.Location = new Point(244, 15);
            LblWhatTime.Name = "LblWhatTime";
            LblWhatTime.Size = new Size(636, 112);
            LblWhatTime.TabIndex = 0;
            LblWhatTime.Text = "00 : 00 : 00 : 00";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(244, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 5);
            panel1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(28, 38, 48);
            listView1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(244, 184);
            listView1.Name = "listView1";
            listView1.Size = new Size(636, 307);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BtnCheckReset
            // 
            BtnCheckReset.Location = new Point(351, 533);
            BtnCheckReset.Name = "BtnCheckReset";
            BtnCheckReset.Size = new Size(164, 72);
            BtnCheckReset.TabIndex = 3;
            BtnCheckReset.Text = "구간기록";
            BtnCheckReset.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(635, 533);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(163, 72);
            BtnStart.TabIndex = 4;
            BtnStart.Text = "시작";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 38, 48);
            Controls.Add(BtnStart);
            Controls.Add(BtnCheckReset);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Controls.Add(LblWhatTime);
            Name = "StopWatch";
            Size = new Size(1126, 653);
            Load += StopWatch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblWhatTime;
        private Panel panel1;
        private ListView listView1;
        private Button BtnCheckReset;
        private Button BtnStart;
        private System.Windows.Forms.Timer timer1;
    }
}
