using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btt0_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "0")
                txtNum.Text = "0";
            else txtNum.Text = txtNum.Text + "0";
        }

        private void btt1_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "0")
                txtNum.Text = "1";
            else txtNum.Text = txtNum.Text + "1";
        }

        private void btt2_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "0")
                txtNum.Text = "2";
            else txtNum.Text = txtNum.Text + "2";
        }

        private void btt3_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "0")
                txtNum.Text = "3";
            else txtNum.Text = txtNum.Text + "3";
        }

        private void btt4_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "0")
                txtNum.Text = "4";
            else txtNum.Text = txtNum.Text + "4";
        }

        private void btt5_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "0")
                txtNum.Text = "5";
            else txtNum.Text = txtNum.Text + "5";
        }

        private void btt6_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "0")
                txtNum.Text = "6";
            else txtNum.Text = txtNum.Text + "6";
        }

        private void btt7_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "0")
                txtNum.Text = "7";
            else txtNum.Text = txtNum.Text + "7";
        }

        private void btt8_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "0")
                txtNum.Text = "8";
            else txtNum.Text = txtNum.Text + "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "0")
                txtNum.Text = "9";
            else txtNum.Text = txtNum.Text + "9";
        }

        private void bttPonto_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text + ".";
            bttPonto.Enabled = false;
        }

        private void bttDivide_Click(object sender, EventArgs e)
        {
            lblTempo.Text = txtNum.Text;
            lblOpcao.Text = "Divide";
            txtNum.Text = "0";
        }

        private void bttMenos_Click(object sender, EventArgs e)
        {
            lblTempo.Text = txtNum.Text;
            lblOpcao.Text = "Menos";
            txtNum.Text = "0";
        }

        private void bttSoma_Click(object sender, EventArgs e)
        {
            lblTempo.Text = txtNum.Text;
            lblOpcao.Text = "Soma";
            txtNum.Text = "0";
        }

        private void brrVezes_Click(object sender, EventArgs e)
        {
            lblTempo.Text = txtNum.Text;
            lblOpcao.Text = "Vezes";
            txtNum.Text = "0";
        }

        private void bttIgual_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;
            a = Convert.ToDouble(lblTempo.Text);
            b = Convert.ToDouble(txtNum.Text);

            if (string.Compare(lblOpcao.Text, "Divide") == 0)
             txtNum.Text = (a / b).ToString();

            double c = 0, d = 0;
            c = Convert.ToDouble(lblTempo.Text);
            d = Convert.ToDouble(txtNum.Text);


            if (string.Compare(lblOpcao.Text, "Menos") == 0)
                txtNum.Text = (a - b).ToString();

             double z = 0, f = 0;
            z = Convert.ToDouble(lblTempo.Text);
            f = Convert.ToDouble(txtNum.Text);

            if (string.Compare(lblOpcao.Text, "Soma") == 0)
                txtNum.Text = (a + b).ToString();

            double g = 0, h = 0;
            g = Convert.ToDouble(lblTempo.Text);
            h = Convert.ToDouble(txtNum.Text);

            if (string.Compare(lblOpcao.Text, "Vezes") == 0)
                txtNum.Text = (a * b).ToString();

            double i = 0, j = 0;
            i = Convert.ToDouble(lblTempo.Text);
            j = Convert.ToDouble(txtNum.Text);

            if (string.Compare(lblOpcao.Text, "Percentagem") == 0)
            {
                txtNum.Text = ((j / 100) * i).ToString();
            }
        }

        private void bttCe_Click(object sender, EventArgs e)
        {
            lblOpcao.Text = "vazio";
            txtNum.Text = "0";
            lblTempo.Text = "0";
        }

        private void lblOpcao_Click(object sender, EventArgs e)
        {

        }

        private void bttPercentagem_Click(object sender, EventArgs e)
        {
            lblTempo.Text = txtNum.Text;
            lblOpcao.Text = "Percentagem";
            txtNum.Text = "0";
        }
    }
}
