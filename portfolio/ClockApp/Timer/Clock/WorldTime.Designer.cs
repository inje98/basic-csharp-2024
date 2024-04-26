namespace MyTimer.Clock
{
    partial class WorldTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldTime));
            button1 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(233, 56);
            button1.Name = "button1";
            button1.Size = new Size(77, 23);
            button1.TabIndex = 4;
            button1.Text = "확인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(45, 532);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 121);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(31, 58);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 6;
            label1.Text = "나라선택";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "한국", "뉴욕", "중국", "알래스카", "이집트", "베네수엘라" });
            comboBox1.Location = new Point(97, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 23);
            comboBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(438, 532);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 121);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("나눔고딕코딩", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 47);
            label3.Name = "label3";
            label3.Size = new Size(206, 32);
            label3.TabIndex = 1;
            label3.Text = "현재 시각 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("나눔고딕코딩", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 47);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 0;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BlueMap;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1123, 523);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Ping.png");
            imageList1.Images.SetKeyName(1, "Ping.png");
            imageList1.Images.SetKeyName(2, "Ping.png");
            imageList1.Images.SetKeyName(3, "Ping.png");
            imageList1.Images.SetKeyName(4, "Ping.png");
            imageList1.Images.SetKeyName(5, "Ping.png");
            // 
            // WorldTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 38, 48);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WorldTime";
            Size = new Size(1126, 653);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private Label label3;
    }
}
