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
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroCliente novocliente = new cadastroCliente();
            novocliente.Show();
            this.Hide();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroUsuario novousuario = new cadastroUsuario();
            novousuario.Show();
            this.Hide();
        }

        private void pacoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroPacote novoformPacote = new cadastroPacote();
            novoformPacote.Show();
            this.Hide();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaCliente novoformConsultacli = new consultaCliente();
            novoformConsultacli.Show();
            this.Hide();
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultaFunc novoformConsultafunc = new consultaFunc();
            novoformConsultafunc.Show();
            this.Hide();
        }

        private void pacoteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultaPacote novoformConsultapac = new consultaPacote();
            novoformConsultapac.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnVoltarPrincipal_Click(object sender, EventArgs e)
        {
            Login novoformLogin = new Login();
            novoformLogin.Show();
            this.Hide();
        }

        private void btnAlterarLogin_Click(object sender, EventArgs e)
        {
            Login novologin = new Login();
            novologin.Show();
            this.Hide();

        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTempo.Text = DateTime.Now.ToLongTimeString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblSistema_Click(object sender, EventArgs e)
        {

        }

        private void pacotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vendaPacote novoVenda = new vendaPacote();
            novoVenda.Show();
            this.Hide();




        }
    }
}
