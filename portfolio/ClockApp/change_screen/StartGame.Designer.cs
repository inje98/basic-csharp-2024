namespace change_screen
{
    partial class StartGame
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
            timerGame = new System.Windows.Forms.Timer(components);
            lblLevel = new Label();
            lblElapsedTime = new Label();
            SuspendLayout();
            // 
            // timerGame
            // 
            timerGame.Enabled = true;
            timerGame.Interval = 1000;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(179, 36);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(34, 15);
            lblLevel.TabIndex = 0;
            lblLevel.Text = "Level";
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.Location = new Point(346, 36);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(26, 15);
            lblElapsedTime.TabIndex = 1;
            lblElapsedTime.Text = "0초";
            // 
            // StartGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblElapsedTime);
            Controls.Add(lblLevel);
            Name = "StartGame";
            Size = new Size(662, 457);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerGame;
        private Label lblLevel;
        private Label lblElapsedTime;
    }
}
