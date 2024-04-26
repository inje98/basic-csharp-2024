using System.Diagnostics;

namespace MyTimer
{
    public partial class FrmMain : Form
    {
        Clock.StopWatch stopWatch = new Clock.StopWatch();
        Clock.CustomTimer timer = new Clock.CustomTimer();
        Clock.WorldTime worldTime = new Clock.WorldTime();

        public FrmMain()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pMain.Controls.Add(stopWatch);
        }

        private void BtnStopWatch_Click(object sender, EventArgs e)
        {
            BtnStopWatch.Font = new Font(BtnStopWatch.Font, FontStyle.Bold | FontStyle.Underline);
            BtnAlam.Font = new Font(BtnAlam.Font, FontStyle.Regular);
            BtnWordTime.Font = new Font(BtnWordTime.Font, FontStyle.Regular);
            pMain.Controls.Clear();
            pMain.Controls.Add(stopWatch);
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {
            BtnAlam.Font = new Font(BtnAlam.Font, FontStyle.Bold | FontStyle.Underline);
            BtnStopWatch.Font = new Font(BtnStopWatch.Font, FontStyle.Regular);
            BtnWordTime.Font = new Font(BtnWordTime.Font, FontStyle.Regular);
            pMain.Controls.Clear();
            pMain.Controls.Add(timer);
        }

        private void BtnWordTime_Click(object sender, EventArgs e)
        {
            BtnWordTime.Font = new Font(BtnWordTime.Font, FontStyle.Bold | FontStyle.Underline);
            BtnStopWatch.Font = new Font(BtnStopWatch.Font, FontStyle.Regular);
            BtnAlam.Font = new Font(BtnAlam.Font, FontStyle.Regular);
            pMain.Controls.Clear();
            pMain.Controls.Add(worldTime);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TsmAbout_Click(object sender, EventArgs e)
        {
            FrmAbout popup = new FrmAbout();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }
    }
    
}
