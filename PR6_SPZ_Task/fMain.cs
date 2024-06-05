using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6_SPZ_Task
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) || (String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!";
                tbAvg.Text = "0";
                return;
            }
            double x1 = double.Parse(tbX1.Text);
            double x2 = double.Parse(tbX2.Text);
            double y = Math.Pow(x1, x2);
            double avg = (x1+x2)/2;
            tbY.Text = y.ToString("0.####");
            tbAvg.Text = avg.ToString("0.####");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbAvg.Text = string.Empty;
            tbY.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
