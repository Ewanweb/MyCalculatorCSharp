using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculater
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        bool ValidateInputs()
        {
            bool isValid = true;
            if (txtN1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("adad aval ra vared konid");
            }
            else
            {
                if (txtN2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("adad dovom ra vared konid");
                }
            }

            return isValid;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Plus((int)txtN1.Value, (int)txtN2.Value);
                MessageBox.Show("sum is :" + sum);
            }
            else
            {
                MessageBox.Show("adad ha nabayd barabar 0 bashand");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int minus = calculate.Minus((int)txtN1.Value, (int)txtN2.Value);
                MessageBox.Show("minus is :" + minus);

            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int multiple = calculate.Multiple((int)txtN1.Value, (int)txtN2.Value);
                MessageBox.Show("multiple is :" + multiple);

            }
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int devide = calculate.Divide((int)txtN1.Value, (int)txtN2.Value);
                MessageBox.Show("devide is :" + devide);

            }
        }
    }
}
