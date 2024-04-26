using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers;

namespace Timer.Clock
{
    public partial class WorldTime : UserControl
    {
        System.Timers.Timer timer;

        public WorldTime()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(); // 타이머 객체 생성
            timer.Interval = 1000; // 1초마다 업데이트
            timer.Elapsed += timer1_Tick; // 타이머 이벤트 핸들러 연결
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 현재 시간 가져오기
            DateTime currentTime = DateTime.UtcNow;

            // 콤보박스에서 선택된 지역에 따라 시간 업데이트
            if (comboBox1.SelectedItem.ToString() == "한국")
            {
                label2.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, "Korea Standard Time").ToString();   // 한국 시간 업데이트
            }
            // 다른 지역 시간을 업데이트하는 코드 추가 가능
            currentTime = currentTime.AddSeconds(1); // 1초씩 추가하여 실시간

            if (comboBox1.SelectedItem.ToString() == "뉴욕")
            {
                label2.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, "US Eastern Standard Time").ToString();   // 한국 시간 업데이트

            }

            if (comboBox1.SelectedItem.ToString() == "중국")
            {
                label2.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, "China Standard Time").ToString();   // 한국 시간 업데이트

            }
        }
    }
}
