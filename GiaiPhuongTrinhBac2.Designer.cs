namespace CSharp_DeThiThu
{
    partial class GiaiPhuongTrinhBac2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtA = new TextBox();
            label2 = new Label();
            txtB = new TextBox();
            label3 = new Label();
            txtC = new TextBox();
            label4 = new Label();
            lblKQ = new Label();
            btnTinh = new Button();
            btnThoat = new Button();
            btnR = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 33);
            label1.TabIndex = 0;
            label1.Text = "Nhập số a:";
            // 
            // txtA
            // 
            txtA.Location = new Point(162, 6);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 40);
            txtA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(145, 33);
            label2.TabIndex = 0;
            label2.Text = "Nhập số b:";
            // 
            // txtB
            // 
            txtB.Location = new Point(162, 52);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 40);
            txtB.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(142, 33);
            label3.TabIndex = 0;
            label3.Text = "Nhập số c:";
            // 
            // txtC
            // 
            txtC.Location = new Point(162, 98);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 40);
            txtC.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(116, 33);
            label4.TabIndex = 0;
            label4.Text = "Kết quả:";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(162, 147);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(0, 33);
            lblKQ.TabIndex = 0;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(12, 291);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(114, 44);
            btnTinh.TabIndex = 2;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(472, 291);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 44);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnR
            // 
            btnR.Location = new Point(352, 291);
            btnR.Name = "btnR";
            btnR.Size = new Size(114, 44);
            btnR.TabIndex = 3;
            btnR.Text = "Reset";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // GiaiPhuongTrinhBac2
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 351);
            Controls.Add(btnR);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(txtC);
            Controls.Add(lblKQ);
            Controls.Add(label4);
            Controls.Add(txtB);
            Controls.Add(label3);
            Controls.Add(txtA);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "GiaiPhuongTrinhBac2";
            Text = "GiaiPhuongTrinhBac2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtA;
        private Label label2;
        private TextBox txtB;
        private Label label3;
        private TextBox txtC;
        private Label label4;
        private Label lblKQ;
        private Button btnTinh;
        private Button btnThoat;
        private Button btnR;
    }
}