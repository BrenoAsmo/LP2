using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalc
{
    public partial class Form1 : Form
    {
        double num1, num2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text,out num1))
            {
                MessageBox.Show("Entrada 1 inválida", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum1.Focus();
            }

        }
        private void txtNum2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum2.Text,out num2))
            {
                MessageBox.Show("Entrada 2 inválida", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum2.Focus();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            result = num1 - num2;
            txtReult.Text = result.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            result = num1 * num2;
            txtReult.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            result = num1 / num2;
            if (num2 == 0) {
                MessageBox.Show("Entrada inválida - não se pode dividir por 0", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum2.Text = " ";
                num2 = 0;
                txtNum2.Focus();
            } else
                txtReult.Text = result.ToString();
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            result = num1 + num2;
            txtReult.Text = result.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = " ";
            txtNum2.Text = " ";
            txtReult.Text = " ";
            num1 = 0;
            num2 = 0;
            result = 0;
            txtNum1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
