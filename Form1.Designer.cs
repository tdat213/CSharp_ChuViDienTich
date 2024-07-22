namespace CSharp_ChuViDienTich
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
            btnTinh = new Button();
            label2 = new Label();
            txtChieuDai = new TextBox();
            txtChieuRong = new TextBox();
            label3 = new Label();
            btnThoat = new Button();
            lbKQ = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F);
            label1.Location = new Point(140, 69);
            label1.Name = "label1";
            label1.Size = new Size(113, 29);
            label1.TabIndex = 0;
            label1.Text = "Chieu Dai";
            label1.Click += label1_Click;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(289, 187);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(146, 42);
            btnTinh.TabIndex = 1;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F);
            label2.Location = new Point(140, 115);
            label2.Name = "label2";
            label2.Size = new Size(133, 29);
            label2.TabIndex = 0;
            label2.Text = "Chieu Rong";
            label2.Click += label1_Click;
            // 
            // txtChieuDai
            // 
            txtChieuDai.Location = new Point(331, 69);
            txtChieuDai.Name = "txtChieuDai";
            txtChieuDai.Size = new Size(200, 23);
            txtChieuDai.TabIndex = 2;
            txtChieuDai.TextChanged += textBox1_TextChanged;
            // 
            // txtChieuRong
            // 
            txtChieuRong.Location = new Point(331, 115);
            txtChieuRong.Name = "txtChieuRong";
            txtChieuRong.Size = new Size(200, 23);
            txtChieuRong.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F);
            label3.Location = new Point(140, 263);
            label3.Name = "label3";
            label3.Size = new Size(99, 29);
            label3.TabIndex = 0;
            label3.Text = "Ket Qua";
            label3.Click += label1_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(289, 372);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(146, 42);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lbKQ
            // 
            lbKQ.AutoSize = true;
            lbKQ.Location = new Point(294, 264);
            lbKQ.Name = "lbKQ";
            lbKQ.Size = new Size(0, 15);
            lbKQ.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbKQ);
            Controls.Add(txtChieuRong);
            Controls.Add(txtChieuDai);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTinh;
        private Label label2;
        private TextBox txtChieuDai;
        private TextBox txtChieuRong;
        private Label label3;
        private Button btnThoat;
        private Label lbKQ;
    }
}
