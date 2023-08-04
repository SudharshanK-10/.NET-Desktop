using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForms
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public List<int> GetNumbers()
        {
            int n1 = Int16.Parse(TxtNo1.Text);
            int n2 = Int16.Parse(TxtNo2.Text);

            return new List<int>() { n1, n2 };
        }

        private bool NoNumber()
        {   
            if(TxtNo1.Text == "" || TxtNo2.Text == "")
            {
                MessageBox.Show("Enter both numbers!");
                return true;
            }

            return false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (NoNumber())
                return;

            List<int> numbers = GetNumbers();
            TxtResult.Text = (numbers[0] + numbers[1]).ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (NoNumber())
                return;

            List<int> numbers = GetNumbers();
            TxtResult.Text = (numbers[0] - numbers[1]).ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            if (NoNumber())
                return;

            List<int> numbers = GetNumbers();
            TxtResult.Text = (numbers[0] * numbers[1]).ToString();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (NoNumber())
                return;

            List<int> numbers = GetNumbers();

            if (numbers[1] == 0)
            {
                MessageBox.Show("Denominator cannot be 0!");
            }

            TxtResult.Text = (numbers[0] / numbers[1]).ToString();
        }
    }
}
