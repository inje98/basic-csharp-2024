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
            // ������ ������ null
            // ������ ������ null���� ���� �� �ֵ��� ������� ��� Nullable. ������ �ڿ� ?�� �߰��Ұ�
            int? a = 0;
            MessageBox.Show(a.ToString());
        }
    }
}
