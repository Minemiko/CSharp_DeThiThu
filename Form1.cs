namespace CSharp_DeThiThu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "Thông tin");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string thongTin = "Họ tên sinh viên: Nyagger\nMSSV: 69420\nBruh\nOwO";
            lblInfo.Text = thongTin;
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPhuongTrinhBac2 PTB2 = new GiaiPhuongTrinhBac2();
            PTB2.Show();
        }

        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ĐĂNG_KÝ_MÔN_HỌC DKMH = new ĐĂNG_KÝ_MÔN_HỌC();
            DKMH.Show();
        }
    }
}
