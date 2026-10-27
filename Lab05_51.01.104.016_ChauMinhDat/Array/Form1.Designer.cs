namespace Array
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtSoDong = new TextBox();
            txtSoCot = new TextBox();
            btnKhoiTao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 28);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Số dòng";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 61);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Số cột";
            label2.Click += label2_Click;
            // 
            // txtSoDong
            // 
            txtSoDong.Location = new Point(90, 25);
            txtSoDong.Name = "txtSoDong";
            txtSoDong.Size = new Size(125, 27);
            txtSoDong.TabIndex = 2;
            txtSoDong.TextChanged += txtSoDong_TextChanged;
            // 
            // txtSoCot
            // 
            txtSoCot.Location = new Point(90, 58);
            txtSoCot.Name = "txtSoCot";
            txtSoCot.Size = new Size(125, 27);
            txtSoCot.TabIndex = 3;
            txtSoCot.TextChanged += txtSoCot_TextChanged;
            // 
            // btnKhoiTao
            // 
            btnKhoiTao.Location = new Point(232, 25);
            btnKhoiTao.Name = "btnKhoiTao";
            btnKhoiTao.Size = new Size(116, 60);
            btnKhoiTao.TabIndex = 4;
            btnKhoiTao.Text = "Khởi tạo form";
            btnKhoiTao.UseVisualStyleBackColor = true;
            btnKhoiTao.Click += btnKhoiTao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 104);
            Controls.Add(btnKhoiTao);
            Controls.Add(txtSoCot);
            Controls.Add(txtSoDong);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSoDong;
        private TextBox txtSoCot;
        private Button btnKhoiTao;
    }
}
