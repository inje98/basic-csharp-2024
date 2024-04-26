using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Timer.Clock
{
    public partial class Timer : UserControl
    {

        System.Timers.Timer timer1min, timer3min, timer5min, timer10min, timerMymin;
        DateTime startTime1min, startTime3min, startTime5min, startTime10min, startTimeMymin;
        int remainingSeconds1min, remainingSeconds3min, remainingSeconds5min, remainingSeconds10min, remainingSecondsMymin;
        bool isStop1min = true, isStop3min = true, isStop5min = true, isStop10min = true, isStopMymin = true;
        private TimeSpan elapsedTime1min = TimeSpan.Zero; // 경과 시간 저장
        private TimeSpan elapsedTime3min = TimeSpan.Zero;
        private TimeSpan elapsedTime5min = TimeSpan.Zero;
        private TimeSpan elapsedTime10min = TimeSpan.Zero;
        private TimeSpan elapsedTimeMymin = TimeSpan.Zero;

        int MyTotalSeconds; // 사용자가 입력한 시간 총 초
        int MyHours;  // numericUpdown으로 입력한거 여기다가
        int MyMinutes;
        int MySeconds;


        public Timer()
        {
            InitializeComponent();

            // 1분 카운트다운 타이머 설정
            timer1min = new System.Timers.Timer();
            timer1min.Interval = 1000;
            timer1min.Elapsed += timer1Min_Tick;

            // 3분 카운트다운 타이머 설정
            timer3min = new System.Timers.Timer();
            timer3min.Interval = 1000;
            timer3min.Elapsed += timer3Min_Tick;

            // 5분 카운트다운 타이머 설정
            timer5min = new System.Timers.Timer();
            timer5min.Interval = 1000;
            timer5min.Elapsed += timer5Min_Tick;

            // 10분 카운트다운 타이머 설정
            timer10min = new System.Timers.Timer();
            timer10min.Interval = 1000;
            timer10min.Elapsed += timer10Min_Tick;

            // 사용자 입력 카운트다운 타이머 설정
            timerMymin = new System.Timers.Timer();
            timerMymin.Interval = 1000;
            timerMymin.Elapsed += timerMy_Tick;
        }

        private void timerMy_Tick(object sender, EventArgs e)
        {
            if (MyTotalSeconds <= 0)
            {
                timerMymin.Stop();
                MessageBox.Show("종료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MyTotalSeconds--; // 1초씩 감소

            int hours = MyTotalSeconds / 3600;
            int minutes = (MyTotalSeconds % 3600) / 60;
            int seconds = MyTotalSeconds % 60;

            Invoke(new Action(() =>
            {
                LblMyTime.Text = string.Format("{0}:{1}:{2}",
                    hours.ToString().PadLeft(2, '0'),
                    minutes.ToString().PadLeft(2, '0'),
                    seconds.ToString().PadLeft(2, '0'));
            }));
        }
        private void timer1Min_Tick(object sender, EventArgs e)
        {
            remainingSeconds1min = (int)(startTime1min.AddMinutes(1) - DateTime.Now).TotalSeconds;

            if (remainingSeconds1min <= 0)
            {
                timer1min.Stop();
                MessageBox.Show("1분이 종료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int hours = remainingSeconds1min / 3600;
            int minutes = (remainingSeconds1min % 3600) / 60;
            int seconds = remainingSeconds1min % 60;

            Invoke(new Action(() =>
            {
                Min1.Text = string.Format("{0}:{1}:{2}",
                    hours.ToString().PadLeft(2, '0'),
                    minutes.ToString().PadLeft(2, '0'),
                    seconds.ToString().PadLeft(2, '0'));
            }));
        }



        private void timer3Min_Tick(object sender, EventArgs e)
        {
            remainingSeconds3min = (int)(startTime3min.AddMinutes(3) - DateTime.Now).TotalSeconds;

            if (remainingSeconds3min <= 0)
            {
                timer3min.Stop();
                MessageBox.Show("3분이 종료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int hours = remainingSeconds3min / 3600;
            int minutes = (remainingSeconds3min % 3600) / 60;
            int seconds = remainingSeconds3min % 60;

            Invoke(new Action(() =>
            {
                Min3.Text = string.Format("{0}:{1}:{2}",
                    hours.ToString().PadLeft(2, '0'),
                    minutes.ToString().PadLeft(2, '0'),
                    seconds.ToString().PadLeft(2, '0'));
            }));
        }

        private void timer5Min_Tick(object sender, EventArgs e)
        {
            remainingSeconds5min = (int)(startTime5min.AddMinutes(5) - DateTime.Now).TotalSeconds;

            if (remainingSeconds5min <= 0)
            {
                timer5min.Stop();
                MessageBox.Show("5분이 종료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int hours = remainingSeconds5min / 3600;
            int minutes = (remainingSeconds5min % 3600) / 60;
            int seconds = remainingSeconds5min % 60;

            Invoke(new Action(() =>
            {
                Min5.Text = string.Format("{0}:{1}:{2}",
                    hours.ToString().PadLeft(2, '0'),
                    minutes.ToString().PadLeft(2, '0'),
                    seconds.ToString().PadLeft(2, '0'));
            }));
        }

        private void timer10Min_Tick(object sender, EventArgs e)
        {
            remainingSeconds10min = (int)(startTime10min.AddMinutes(10) - DateTime.Now).TotalSeconds;

            if (remainingSeconds10min <= 0)
            {
                timer10min.Stop();
                MessageBox.Show("10분이 종료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int hours = remainingSeconds10min / 3600;
            int minutes = (remainingSeconds10min % 3600) / 60;
            int seconds = remainingSeconds10min % 60;

            Invoke(new Action(() =>
            {
                Min10.Text = string.Format("{0}:{1}:{2}",
                    hours.ToString().PadLeft(2, '0'),
                    minutes.ToString().PadLeft(2, '0'),
                    seconds.ToString().PadLeft(2, '0'));
            }));
        }

        private void button4_Click(object sender, EventArgs e) // 1분 시작버튼
        {
            if (isStop1min)
            {
                startTime1min = DateTime.Now - elapsedTime1min; // 시작 시간을 현재 시간에서 경과 시간을 뺀 시간으로 설정
                timer1min.Start();
                isStop1min = false;
                button4.Text = "정지";
            }
            else
            {
                timer1min.Stop();
                elapsedTime1min = DateTime.Now - startTime1min; // 경과 시간 업데이트
                isStop1min = true;
                button4.Text = "계속";
            }
        }
        private void button3_Click(object sender, EventArgs e) // 1분 정지버튼
        {
            if (!isStop1min)
            {
                timer1min.Stop(); // 타이머 중지
                isStop1min = true; // 타이머 상태를 정지 상태로 설정
            }

            elapsedTime1min = TimeSpan.Zero; // 경과 시간 초기화
            Min1.Text = "00:01:00"; // Label 텍스트 초기화
            button4.Text = "시작";
        }

        private void button10_Click(object sender, EventArgs e) // 3분 시작버튼
        {
            if (isStop3min)
            {
                startTime3min = DateTime.Now - elapsedTime3min; // 시작 시간을 현재 시간에서 경과 시간을 뺀 시간으로 설정
                timer3min.Start();
                isStop3min = false;
                button10.Text = "정지";
            }
            else
            {
                timer3min.Stop();
                elapsedTime3min = DateTime.Now - startTime3min; // 경과 시간 업데이트
                isStop3min = true;
                button10.Text = "계속";
            }
        }
        private void button9_Click(object sender, EventArgs e) // 3분 정지버튼
        {
            if (!isStop3min)
            {
                timer3min.Stop(); // 타이머 중지
                isStop3min = true; // 타이머 상태를 정지 상태로 설정
            }

            elapsedTime3min = TimeSpan.Zero; // 경과 시간 초기화
            Min3.Text = "00:03:00"; // Label 텍스트 초기화
            button10.Text = "시작";
        }

        private void button6_Click(object sender, EventArgs e) // 5분 시작버튼
        {
            if (isStop5min)
            {
                startTime5min = DateTime.Now - elapsedTime5min; // 시작 시간을 현재 시간에서 경과 시간을 뺀 시간으로 설정
                timer5min.Start();
                isStop5min = false;
                button6.Text = "정지";
            }
            else
            {
                timer5min.Stop();
                elapsedTime5min = DateTime.Now - startTime5min; // 경과 시간 업데이트
                isStop5min = true;
                button6.Text = "계속";
            }
        }
        private void button5_Click(object sender, EventArgs e) // 5분 정지버튼
        {
            if (!isStop5min)
            {
                timer5min.Stop(); // 타이머 중지
                isStop5min = true; // 타이머 상태를 정지 상태로 설정
            }

            elapsedTime5min = TimeSpan.Zero; // 경과 시간 초기화
            Min5.Text = "00:05:00"; // Label 텍스트 초기화
            button6.Text = "시작";
        }

        private void button8_Click(object sender, EventArgs e) // 10분 시작버튼
        {
            if (isStop10min)
            {
                startTime10min = DateTime.Now - elapsedTime10min; // 시작 시간을 현재 시간에서 경과 시간을 뺀 시간으로 설정
                timer10min.Start();
                isStop10min = false;
                button8.Text = "정지";
            }
            else
            {
                timer10min.Stop();
                elapsedTime10min = DateTime.Now - startTime10min; // 경과 시간 업데이트
                isStop10min = true;
                button8.Text = "계속";
            }
        }

        private void button7_Click(object sender, EventArgs e) // 10분 정지버튼
        {
            if (!isStop10min)
            {
                timer10min.Stop(); // 타이머 중지
                isStop10min = true; // 타이머 상태를 정지 상태로 설정
            }

            elapsedTime10min = TimeSpan.Zero; // 경과 시간 초기화
            Min5.Text = "00:10:00"; // Label 텍스트 초기화
            button8.Text = "시작";
        }
        private void button2_Click(object sender, EventArgs e) // 사용자 입력 시작버튼
        {
            if (isStopMymin)
            {
                startTimeMymin = DateTime.Now - elapsedTimeMymin; // 시작 시간을 현재 시간에서 경과 시간을 뺀 시간으로 설정
                timerMymin.Start();
                isStopMymin = false;
                button2.Text = "정지";
            }
            else
            {
                timerMymin.Stop();
                elapsedTimeMymin = DateTime.Now - startTimeMymin; // 경과 시간 업데이트
                isStopMymin = true;
                button2.Text = "계속";
            }
        }

        private void button1_Click(object sender, EventArgs e) // 사용자 입력 초기화버튼
        {
            if (!isStopMymin)
            {
                timerMymin.Stop(); // 타이머 중지
                isStopMymin = true; // 타이머 상태를 정지 상태로 설정
            }

            elapsedTimeMymin = TimeSpan.Zero; // 경과 시간 초기화

            MyTotalSeconds = MyHours * 3600 + MyMinutes * 60 + MySeconds;

            LblMyTime.Text = string.Format("{0}:{1}:{2}",
            MyHours.ToString().PadLeft(2, '0'),
            MyMinutes.ToString().PadLeft(2, '0'),
            MySeconds.ToString().PadLeft(2, '0'));

            

            button8.Text = "시작";
        }

        private void button11_Click(object sender, EventArgs e) // 내가 정한 타이머 확인버튼
        {
            button1.Enabled = true;
            button2.Enabled = true;

            MyHours = (int)NmrHour.Value;
            MyMinutes = (int)NmrMin.Value;
            MySeconds = (int)NmrSec.Value;

            // 총 시간을 초 단위로 계산합니다.
            MyTotalSeconds = MyHours * 3600 + MyMinutes * 60 + MySeconds;

            LblMyTime.Text = string.Format("{0}:{1}:{2}",
            MyHours.ToString().PadLeft(2, '0'),
            MyMinutes.ToString().PadLeft(2, '0'),
            MySeconds.ToString().PadLeft(2, '0'));
        }

       
    }
}
