using System;
using System.Windows.Forms;

namespace change_screen
{
    public partial class Form1 : Form
    {
        private StartGame gameScreen; // 게임 화면을 나타내는 사용자 정의 컨트롤 변수

        public Form1()
        {
            InitializeComponent();
            gameScreen = new StartGame(); // 게임 화면 컨트롤 초기화
            gameScreen.Dock = DockStyle.Fill; // 컨트롤이 폼에 꽉 차도록 설정
            gameScreen.Visible = false; // 일단은 숨겨둠
            this.Controls.Add(gameScreen); // 폼에 게임 화면 컨트롤 추가
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // 닫기 버튼 클릭 시 폼 닫기
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // 시작 버튼 클릭 시 게임 화면 보이도록 설정
            gameScreen.Visible = true;
            this.Controls.Remove(BtnStart); // 시작 버튼 숨기기
            this.Controls.Remove(BtnClose); // 닫기 버튼 숨기기
            this.Controls.Remove(label1); // 물고기 살려라 라벨 숨기기
        }
    }
}

