using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator_Mark
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (cbOperators.Text == "+") {
                LabelShowTotal.Text = BasicComputation.Addition(float.Parse(x.Text),float.Parse(y.Text)).ToString();

            }
            else if (cbOperators.Text == "-")
            {
                LabelShowTotal.Text = BasicComputation.Subtraction(float.Parse(x.Text), float.Parse(y.Text)).ToString();
            }
            else if (cbOperators.Text == "*")
            {
                LabelShowTotal.Text = BasicComputation.Multiplication(float.Parse(x.Text), float.Parse(y.Text)).ToString();
            }
            else if (cbOperators.Text == "/")
            {
                LabelShowTotal.Text = BasicComputation.Division(float.Parse(x.Text), float.Parse(y.Text)).ToString();
            }
        }
    }
}
