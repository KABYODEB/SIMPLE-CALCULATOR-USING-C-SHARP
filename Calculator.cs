using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operation = "";
        bool operation_Pressed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_Pressed))
                txtResult.Clear();
            operation_Pressed = false;
            txtResult.Text = txtResult.Text + "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_Pressed))
                txtResult.Clear();
            operation_Pressed = false;
            txtResult.Text = txtResult.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_Pressed))
                txtResult.Clear();
            operation_Pressed = false;
            txtResult.Text = txtResult.Text + "1";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_Pressed))
                txtResult.Clear();
            operation_Pressed = false;
            txtResult.Text = txtResult.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_Pressed))
                txtResult.Clear();
            operation_Pressed = false;
            txtResult.Text = txtResult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_Pressed))
                txtResult.Clear();
            operation_Pressed = false;
            txtResult.Text = txtResult.Text + "6";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_Pressed))
                txtResult.Clear();
            operation_Pressed = false;
            txtResult.Text = txtResult.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_Pressed))
                txtResult.Clear();
            operation_Pressed = false;
            txtResult.Text = txtResult.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_Pressed))
                txtResult.Clear();
            operation_Pressed = false;
            txtResult.Text = txtResult.Text + "7";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_Pressed))
                txtResult.Clear();
            operation_Pressed = false;

            txtResult.Text = txtResult.Text + "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0")||(operation_Pressed))
                txtResult.Clear();
            txtResult.Text = txtResult.Text + ".";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            operation = "+";
            value =Double.Parse(txtResult.Text);
            operation_Pressed = true;
            label2.Text = value + "" + operation;

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operation = "-";
            value = Double.Parse(txtResult.Text);
            operation_Pressed = true;
            label2.Text = value + "" + operation;

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operation = "*";
            value = Double.Parse(txtResult.Text);
            operation_Pressed = true;
            label2.Text = value + "" + operation;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            value = Double.Parse(txtResult.Text);
            operation_Pressed = true;
            label2.Text = value + "" + operation;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            switch (operation)
            {
                case "+":

                    txtResult.Text = (value + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (value - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (value * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (value / Double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;

                    
            }
        }

       
    }
}
