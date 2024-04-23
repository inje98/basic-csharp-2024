namespace fish
{
    public partial class Form1 : Form
    {
        private DateTime startTime;  // 프로그램 시작 시간을 저장할 변수
        private int level = 1;  // 현재 레벨

        private int progressBarMaxValue = 100; // 프로그레스 바의 최대 값
        private int progressBarCurrentValue = 0; // 프로그레스 바의 현재 값

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10; // 타이머 간격을 10밀리초로 설정
            timer1.Tick += Timer_Tick; // 타이머 이벤트 핸들러 연결

            progressBar.Maximum = progressBarMaxValue; // 프로그레스 바의 최대 값 설정
            progressBar.Minimum = 0; // 프로그레스 바의 최소 값 설정
            progressBar.Value = progressBarCurrentValue; // 프로그레스 바 초기 값 설정
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;  // 폼 로드 시 시작 시간을 현재 시간으로 설정
            timer1.Start(); // 타이머 시작
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;  // 시작부터 지금까지의 경과 시간을 계산
            double totalSeconds = elapsed.TotalMilliseconds / 1000; // 경과 시간을 초 단위로 변환

            // 10초 간격마다 프로그레스 바가 10씩 증가하도록 설정
            int newValue = (int)(totalSeconds % 10 * 10);
            progressBarCurrentValue = Math.Min(newValue, progressBarMaxValue);
            progressBar.Value = progressBarCurrentValue;

            // 10초 간격마다 레벨을 증가하고, 최대 레벨에 도달하면 타이머를 중지하고 게임을 종료
            if (totalSeconds / 10 >= level)
            {
                level++;  // 레벨 증가
                if (level > 5)
                {
                    timer1.Stop();  // 타이머 중지
                    MessageBox.Show("축하합니다! 레벨 5에 도달했습니다.");
                    var result = MessageBox.Show("다시 시작하시겠습니까?", "게임 오버", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        RestartGame();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }

            // 레이블 업데이트
            label1.Text = $"{totalSeconds}초";
            label2.Text = $"level : {level}";
        }

        private void RestartGame() 
        {
            startTime = DateTime.Now;  // 시작 시간 리셋
            level = 1;  // 레벨 리셋
            progressBarCurrentValue = 0; // 프로그레스 바 리셋
            progressBar.Value = 0;
            timer1.Start();  // 타이머 다시 시작
        }
    }
}
