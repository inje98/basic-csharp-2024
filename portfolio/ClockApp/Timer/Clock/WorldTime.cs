using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyTimer.Clock
{
    public partial class WorldTime : UserControl
    {
        System.Timers.Timer timer;
        private int selectedMarkerIndex = -1; // 선택된 마커의 인덱스를 추적하는 변수

        public WorldTime()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(1000); // 1초마다 업데이트
            timer.Elapsed += timer1_Tick;
            timer.AutoReset = true;
            timer.Enabled = true;

            // 콤보박스의 선택이 변경될 때마다 시간 업데이트
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateMarker();
            UpdateTimeForSelectedZone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTimeForSelectedZone();
        }

        private void UpdateTimeForSelectedZone()
        {
            if (comboBox1.SelectedItem == null) return;

            DateTime currentTime = DateTime.UtcNow;
            var selectedZone = comboBox1.SelectedItem.ToString();
            string timeZoneId = "";

            switch (selectedZone)
            {
                case "한국":
                    timeZoneId = "Korea Standard Time";
                    break;
                case "뉴욕":
                    timeZoneId = "US Eastern Standard Time";
                    break;
                case "중국":
                    timeZoneId = "China Standard Time";
                    break;
                case "알래스카":
                    timeZoneId = "Alaskan Standard Time";
                    break;
                case "이집트":
                    timeZoneId = "Egypt Standard Time";
                    break;
                case "베네수엘라":
                    timeZoneId = "Venezuela Standard Time";
                    break;


            }

            if (!string.IsNullOrEmpty(timeZoneId))
            {
                label2.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, timeZoneId).ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void UpdateMarker()
        {
            if (comboBox1.SelectedItem == null)
            {
                selectedMarkerIndex = -1;
            }
            else
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "한국":
                        selectedMarkerIndex = 0;
                        break;
                    case "뉴욕":
                        selectedMarkerIndex = 1;
                        break;
                    case "중국":
                        selectedMarkerIndex = 2;
                        break;
                    case "알래스카":
                        selectedMarkerIndex = 3;
                        break;
                    case "이집트":
                        selectedMarkerIndex = 4;
                        break;
                    case "베네수엘라":
                        selectedMarkerIndex = 5;
                        break;

                    default:
                        selectedMarkerIndex = -1; // 기본값으로 설정
                        break;
                }
            }

            pictureBox1.Invalidate(); // pictureBox를 다시 그리도록 요청
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (this.imageList1.Images.Count > 0 && selectedMarkerIndex != -1)
            {
                switch (selectedMarkerIndex)
                {
                    case 0:
                        g.DrawImage(this.imageList1.Images[0], 910, 210, 20, 20); // 한국
                        break;
                    case 1:
                        g.DrawImage(this.imageList1.Images[1], 280, 200, 20, 20); // 뉴욕
                        break;
                    case 2:
                        g.DrawImage(this.imageList1.Images[2], 860, 230, 20, 20); // 중국
                        break;
                    case 3:
                        g.DrawImage(this.imageList1.Images[3], 35, 103, 20, 20); // 알래스카
                        break;
                    case 4:
                        g.DrawImage(this.imageList1.Images[4], 610, 250, 20, 20); // 이집트
                        break;
                    case 5:
                        g.DrawImage(this.imageList1.Images[5], 325, 310, 20, 20); // 베네수엘라
                        break;

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 콤보박스의 선택이 변경될 때는 아무 동작도 하지 않음
            // 버튼을 클릭할 때만 동작
        }
    }
}
