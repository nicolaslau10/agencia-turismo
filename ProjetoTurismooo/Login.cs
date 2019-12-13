using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // biblioteca para usar objetos do sql server

namespace ProjetoTurismooo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //objeto SqlConnection irá se conectar a um banco de dados local, cujo nome é BDTurismo
        SqlConnection cn = new SqlConnection("User ID=sa;Password=brunoolauu;Initial Catalog=BDTurismo;Data Source=DESKTOP-KKB0QQV\\SQLSERVER14");

        // objeto SqlCommand permite a utilização de instruções sql dentro do C#
        SqlCommand cm = new SqlCommand();

        SqlDataReader objDados;

        private void lblLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            lblErro.Visible = false;
        }

        private void lblEntrar_Click(object sender, EventArgs e)            
        {

            if(txtLogin.Text == "" && txtSenha.Text == "")
            {
                lblErro.Visible = true;
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_usuario where (email_usuario = '" + txtLogin.Text + "') and (senha_usuario = '" + txtSenha.Text + "')";
                    cm.Connection = cn;
                    objDados = cm.ExecuteReader();

                    if (objDados.HasRows)
                    {
                        formPrincipal principal = new formPrincipal();
                        principal.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Login e senha inválidos !!!", "E R R O", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limparCampos();
                    }
                }

                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

                finally
                {
                    cn.Close();
                }

            }
                       
          
        }


        private void limparCampos()
        {
            txtLogin.Clear();
            txtSenha.Clear();
            txtLogin.Focus();
        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
