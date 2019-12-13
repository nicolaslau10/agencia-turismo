using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTurismooo
{
    public partial class vendaPacote : Form
    {
        public vendaPacote()
        {
            InitializeComponent();
        }

        private void btngerardadosvenda_Click(object sender, EventArgs e)
        {
           


        }

        private void btnvenda_Click(object sender, EventArgs e)
        {
            txtFuncvenda.Enabled = true;
            txtFuncvenda.Focus();
            mskCPFvendaa.Enabled = true;
            comboBox1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            textBox1.Enabled = true;
            lblpreenchavenda.Visible = true;
            btnvenda.Enabled = false;
            btnLimparvenda.Enabled = true;
            btncadastravenda.Enabled = true;


        }

        private void btnvoltarmenunormal_Click(object sender, EventArgs e)
        {
            formPrincipal novoprincipal = new formPrincipal();
            novoprincipal.Show();
            this.Hide();
        }

        private void btnLimparvenda_Click(object sender, EventArgs e)
        {
            txtFuncvenda.Text = "";
            mskCPFvendaa.Text = "";
            textBox1.Text = "";
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            comboBox1.Text = "";
            txtFuncvenda.Focus();
        }

        private void btncadastravenda_Click(object sender, EventArgs e)
        {
            if (txtFuncvenda.Text == "" || mskCPFvendaa.Text == "" || textBox1.Text == "" || comboBox1.Text == "" || txtFuncvenda.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos !!", "E R R O ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Dados Inseridos com sucesso !!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTempo.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
