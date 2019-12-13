using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoTurismooo
{
    public partial class cadastroUsuario : Form
    {
        public cadastroUsuario()
        {
            InitializeComponent();
        }
        //objeto SqlConnection irá se conectar a um banco de dados local, cujo nome é BDTurismo
        SqlConnection cn = new SqlConnection("User ID=sa;Password=brunoolauu;Initial Catalog=BDTurismo;Data Source=DESKTOP-KKB0QQV\\SQLSERVER14");

        // objeto SqlCommand permite a utilização de instruções sql dentro do C#
        SqlCommand cm = new SqlCommand();

        private void cadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarmenu_Click(object sender, EventArgs e)
        {
            formPrincipal novoprincipal = new formPrincipal();
            novoprincipal.Show();
            this.Hide();
        }

        private void btnNovofunc_Click(object sender, EventArgs e)
        {
            lblpreenchafunc.Visible = true;
            txtEmailusuario.Enabled = true;
            txtNomeusuario.Enabled = true;
            txtSenhausuario.Enabled = true;
            mskCpfFunc.Enabled = true;
            txtNomeusuario.Focus();
            btnCadastrarfunc.Enabled = true;
            btnLimparfunc.Enabled = true;
            btnNovofunc.Enabled = false;


        }
        private void LimparCampos()
        {
            txtEmailusuario.Text = "";
            txtNomeusuario.Text = "";
            txtSenhausuario.Text = "";
            mskCpfFunc.Text = "";
            txtNomeusuario.Focus();
            
        }

        private void btnLimparfunc_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void btnCadastrarfunc_Click(object sender, EventArgs e)
        {
            if (mskCpfFunc.Text == "" || txtEmailusuario.Text == "" || txtNomeusuario.Text == "" || txtSenhausuario.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !!", "E R R O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                try // ao clicar no botão o metodo tentará executar este bloco, se der erro vai para o catch
                {
                    cn.Open(); // abrindo conexão com o banco de dados
                    cm.CommandText = "insert into tbl_usuario(email_usuario,senha_usuario,nm_usuario,cpf_usuario) values('" + txtEmailusuario.Text + "','" + txtSenhausuario.Text + "','" + txtNomeusuario.Text + "','" + mskCpfFunc.Text + "')";
                    cm.Connection = cn; // informando que este comando sql será executado na conexao estabelecida
                    cm.ExecuteNonQuery();  // executando a instrução sql
                    MessageBox.Show("Dados inseridos com sucesso !!!"); // exibindo mensagem de sucesso
                    LimparCampos();

                }


                catch (Exception erro)  // explode mensagem de erro se alguma coisa acontecer de errado no try
                {
                    MessageBox.Show(erro.Message);
                }

                finally
                {
                    cn.Close(); // fechando conexao
                }
            }
        }

        private void btnvoltarmenunormal_Click(object sender, EventArgs e)
        {
            formPrincipal novoprincipal = new formPrincipal();
            novoprincipal.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTempo.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
