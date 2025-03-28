namespace Module1BaiSo3_HuynhNhatGiaLac
{
    public partial class frmBaiTap3 : Form
    {
        public frmBaiTap3()
        {
            InitializeComponent();
        }
        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }
        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }
        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }
        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtHo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblHoTen.Text = txtHo.Text;
            }
        }
        private void FormName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
