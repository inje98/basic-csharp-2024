namespace change_screen
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
            label1 = new Label();
            BtnStart = new Button();
            BtnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 48F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(185, 120);
            label1.Name = "label1";
            label1.Size = new Size(444, 86);
            label1.TabIndex = 0;
            label1.Text = "물고기 살려라";
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(320, 257);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(135, 64);
            BtnStart.TabIndex = 1;
            BtnStart.Text = "시작";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(320, 327);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(135, 64);
            BtnClose.TabIndex = 2;
            BtnClose.Text = "종료";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnClose);
            Controls.Add(BtnStart);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnStart;
        private Button BtnClose;
    }
}
