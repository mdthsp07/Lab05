using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Array
{
    public partial class frmXuat : Form
    {
        // 2 thuộc tính nhận dữ liệu từ Form 1 truyền sang
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SoDong { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SoCot { get; set; }

        // Khai báo kích thước nút và khoảng cách lề
        int h = 35, margin = 5;

        // Hàm khởi tạo có tham số truyền vào
        public frmXuat(int dong = 1, int cot = 1)
        {
            InitializeComponent();

            // Gán giá trị
            this.SoDong = dong;
            this.SoCot = cot;

            int dem = 1; // Biến đếm số thứ tự (1, 2, 3...)

            // Vòng lặp tạo nút bấm động
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Button btn = new Button();
                    btn.Width = h;
                    btn.Height = h;
                    btn.Text = dem.ToString(); // Ghi số lên nút

                    // Tính tọa độ X, Y để xếp thành lưới
                    btn.Location = new Point(margin + j * (h + margin), margin + i * (h + margin));

                    // Thêm nút vào Form
                    this.Controls.Add(btn);

                    dem++; // Tăng biến đếm
                }
            }

            // Tự động phóng to Form cho vừa với số nút (tránh bị che khuất)
            this.Width = margin + SoCot * (h + margin) + 20;
            this.Height = margin + SoDong * (h + margin) + 40;
        }
    }
}