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
    public partial class GiaiPhuongTrinhBac2 : Form
    {
        public GiaiPhuongTrinhBac2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c != 0)
                    {
                        lblKQ.Text = "Phương trình vô nghiệm";
                    }
                    else
                    {
                        lblKQ.Text = "Phương trình vô số nghiệm";
                    }
                }
                else
                {
                    lblKQ.Text = "Nghiệm của phương trình x là " + (-c / b);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    lblKQ.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    lblKQ.Text = ("x1 = " + (-b + (Math.Sqrt(delta)) / (2 * a))) + Environment.NewLine + "x2 = " + (-b - (Math.Sqrt(delta)) / (2 * a));
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtA.ResetText();
            txtB.ResetText();
            txtC.ResetText();
            lblKQ.ResetText();
        }
    }
}
