namespace Array
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSoDong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoCot_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy số từ TextBox (Ép kiểu sang số nguyên)
                int dong = int.Parse(txtSoDong.Text);
                int cot = int.Parse(txtSoCot.Text);

                // Tạo Form thứ 2 (frmXuat) và truyền số dòng, số cột sang
                frmXuat fXuat = new frmXuat(dong, cot);

                // Hiện Form 2 lên
                fXuat.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi");
            }
        }
    }
}
