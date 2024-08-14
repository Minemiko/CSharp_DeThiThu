using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_DeThiThu
{
    public partial class ĐĂNG_KÝ_MÔN_HỌC : Form
    {
        public ĐĂNG_KÝ_MÔN_HỌC()
        {
            InitializeComponent();
        }

        private void ĐĂNG_KÝ_MÔN_HỌC_Load(object sender, EventArgs e)
        {
            txtMS.Text = "69420";
            txtHT.Text = "Nyagger";
            rdo1.Checked = true;

            cbbNK.Items.Add("2020");
            cbbNK.Items.Add("2021");
            cbbNK.Items.Add("2022");
            cbbNK.Items.Add("2023");
            cbbNK.Items.Add("2024");
            cbbNK.Items.Add("2025");

            cbbL.Items.Add("Ứng dụng phần 1");
            cbbL.Items.Add("Ứng dụng phần 2");
            cbbL.Items.Add("Ứng dụng phần 3");
            cbbL.Items.Add("Thiết kế đồ họa 1");
            cbbL.Items.Add("Thiết kế đồ họa 2");
            cbbL.Items.Add("Quản trị mạng 1");
            cbbL.Items.Add("Quản trị mạng 2");

            clbMH.Items.Add("LT WIN");
            clbMH.Items.Add("LT INTERNET");
            clbMH.Items.Add("Mạng máy tính");
            clbMH.Items.Add("UML");
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string thongtin;

            thongtin = "Mã số sinh viên: " + txtMS.Text;
            thongtin += "\nHọ và tên: " + txtHT.Text;
            thongtin += "\nNiên khóa: " + cbbNK.SelectedItem;
            thongtin += "\nLớp: " + cbbL.SelectedItem;

            if (rdo1.Checked)
            {
                thongtin += "\nĐã đăng ký học Học kỳ " + rdo1.Text + " các môn học sau:";
            }
            else if (rdo2.Checked)
            {
                thongtin += "\nĐã đăng ký học Học kỳ " + rdo2.Text + " các môn học sau:";
            }
            else if (rdo3.Checked)
            {
                thongtin += "\nĐã đăng ký học Học kỳ " + rdo3.Text + " các môn học sau:";
            }
            else if (rdo4.Checked)
            {
                thongtin += "\nĐã đăng ký học Học kỳ " + rdo4.Text + " các môn học sau:";
            }

            int stt = 1;
            foreach (var item in clbMH.CheckedItems)
            {
                thongtin += "\n" + stt + ". " + item;
                stt++;
            }

            MessageBox.Show(thongtin, "Thông tin sinh viên");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtMS.ResetText();
            txtHT.ResetText();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}