using Ax.Fw.MetroFramework.Forms;

namespace BookRentalShopApp
{
    public partial class FrmMain : BorderlessForm // MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // 값형식 변수는 null
            // 값형식 변수에 null값을 넣을 수 있도록 만들어준 기능 Nullable. 변수명 뒤에 ?만 추가할것
            int? a = 0;
            MessageBox.Show(a.ToString());
        }
    }
}
