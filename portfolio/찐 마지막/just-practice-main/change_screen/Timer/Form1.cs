using System.Diagnostics;

namespace Timer
{
    public partial class Form1 : Form
    {
        Clock.StopWatch stopWatch = new Clock.StopWatch();
        Clock.Timer timer = new Clock.Timer();
        Clock.WorldTime worldTime = new Clock.WorldTime();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pMain.Controls.Add(stopWatch);
        }

        private void BtnStopWatch_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(stopWatch);
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(timer);
        }

        private void BtnWordTime_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(worldTime);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
