namespace CSharp_ChuViDienTich
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double dai = Convert.ToDouble(txtChieuDai.Text);
            double rong = Convert.ToDouble(txtChieuRong.Text);

            lbKQ.Text = "Dien Tich: " + TinhDienTich(dai, rong) + Environment.NewLine + "Chu Vi: " + TinhChuVi(dai, rong);


        }

        private double TinhDienTich(double d, double r)
        {
            return d * r;
        }

        private double TinhChuVi(double d, double r)
        {
            return 2 * (d + r);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
