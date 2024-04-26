using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace Timer.Clock
{

    public partial class StopWatch : UserControl
    {
        System.Timers.Timer timer;
        int h, m, s, ms;
        bool isStop = true; // true : 정지상태
                             // false : 동작상태
        public StopWatch()
        {
            InitializeComponent();
        }

        private void StopWatch_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                ms += 1;
                if (ms == 100)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                LblWhatTime.Text = string.Format("{0} : {1} : {2} : {3}",
                    h.ToString().ToString().PadLeft(2, '0'),
                    m.ToString().ToString().PadLeft(2, '0'),
                    s.ToString().ToString().PadLeft(2, '0'),
                    ms.ToString().ToString().PadLeft(2, '0'));
            }));
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (isStop) // 타이머 정지 상태이면
            {
                BtnStart.Text = "정지";
                timer.Start();
                isStop = false;
            }
            else // 타이머 동작 상태이면
            {
                BtnStart.Text = "시작";
                timer.Stop();
                isStop = true;
            }
        }
    }
}
