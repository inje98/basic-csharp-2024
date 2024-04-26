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
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MyTimer.Clock
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
                // 동작
                BtnStart.Text = "정지";
                timer.Start();
                isStop = false;
                BtnCheckReset.Text = "구간기록";
                BtnCheckReset.Enabled = true;
                
                
            }
            else // 타이머 동작 상태이면
            {
                // 정지
                BtnStart.Text = "시작";
                timer.Stop();
                isStop = true;
                BtnCheckReset.Text = "초기화";
            }
        }


     
        private void BtnCheckReset_Click(object sender, EventArgs e)
        {
            

            if (!isStop) // 타이머 동작 상태이면(구간기록)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = DateTime.Now.ToString();
                lvi.SubItems.Add(LblWhatTime.Text);
                listView1.Items.Add(lvi);

            }
            else // 정지상태 (초기화)
            {
                timer.Stop();
                h = 0;
                m = 0;
                s = 0;
                ms = 0;
                LblWhatTime.Text = "00 : 00 : 00 : 00";
                BtnCheckReset.Enabled = false;
                BtnCheckReset.Text = "구간기록";
                listView1.Items.Clear();
            }
        }
    }
}
