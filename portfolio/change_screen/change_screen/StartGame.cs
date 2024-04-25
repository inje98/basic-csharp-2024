using System;
using System.Windows.Forms;

namespace change_screen
{
    public partial class StartGame : UserControl
    {
        private int level = 1; // 현재 레벨
        private int elapsedTime = 0; // 경과 시간 (초 단위)

        public StartGame()
        {
            InitializeComponent();

            // 타이머 이벤트 핸들러 연결
            timerGame.Tick += TimerGame_Tick;

            // 타이머 간격 설정 (1초)
            timerGame.Interval = 1000;

            // 타이머 시작
            timerGame.Start();
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            // 경과 시간 증가
            elapsedTime++;

            // 시간 경과를 라벨에 표시
            lblElapsedTime.Text = $"경과 시간: {elapsedTime} 초";

            // 레벨을 라벨에 표시
            lblLevel.Text = $"레벨: {level}";

            // 매 20초마다 레벨 증가
            if (elapsedTime % 20 == 0)
            {
                level++;
                Console.WriteLine($"레벨이 {level}로 증가했습니다!");
            }
        }


    }
}
