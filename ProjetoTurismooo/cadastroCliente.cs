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
    public partial class cadastroCliente : Form
    {
        public cadastroCliente()
        {
            InitializeComponent();
        }
        //objeto SqlConnection irá se conectar a um banco de dados local, cujo nome é BDTurismo
        SqlConnection cn = new SqlConnection("User ID=sa;Password=brunoolauu;Initial Catalog=BDTurismo;Data Source=DESKTOP-KKB0QQV\\SQLSERVER14");

        // objeto SqlCommand permite a utilização de instruções sql dentro do C#
        SqlCommand cm = new SqlCommand();


        private void txtPassageiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltarmenu_Click(object sender, EventArgs e)
        {
            formPrincipal novoprincipal = new formPrincipal();
            novoprincipal.Show();
            this.Hide();
        }

        private void btnNovocliente_Click(object sender, EventArgs e)
        {
            lblpreenchacliente.Visible = true;
            mskNasc.Enabled = true;
            mskCep.Enabled = true;
            txtEmail.Enabled = true;
            txtNome.Enabled = true;     
            btnCadastrarcliente.Enabled = true;
            btnLimparcliente.Enabled = true;
            mskNasc.Enabled = true;
            mskCelular.Enabled = true;
            mskCPF.Enabled = true;
            txtNome.Focus();
            rbtnF.Enabled = true;
            rbtnM.Enabled = true;
            btnNovocliente.Enabled = false;
            
        }

        private void cadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnLimparcliente_Click(object sender, EventArgs e)
        {
            limparCampos();
        }


        private void limparCampos()
        {
            mskCep.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            mskNasc.Text = "";
            mskCelular.Text = "";
            mskCPF.Text = "";
            rbtnF.Checked = false;
            rbtnM.Checked = false;
            txtNome.Focus();
        }

        private void btnCadastrarcliente_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtNome.Text == "" || mskCelular.Text == "" || mskCep.Text == "" || mskCPF.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !!", "E R R O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // DateTime data = Convert.ToDateTime(mskNasc.Text);
            else
            {


                char sexo;
                if (rbtnM.Checked)
                {
                    sexo = 'M';
                }
                else
                {
                    sexo = 'F';
                }


                try // ao clicar no botão o metodo tentará executar este bloco, se der erro vai para o catch
                {
                    cn.Open(); // abrindo conexão com o banco de dados
                    cm.CommandText = "insert into tbl_cliente(nasc_cliente,sexo_cliente,cep_cliente,email_cliente,cpf_cliente,nome_cliente,celular_cliente) values('" + mskNasc.Text + "','" + sexo + "','" + mskCep.Text + "','" + txtEmail.Text + "','" + mskCPF.Text + "','" + txtNome.Text + "','" + mskCelular.Text + "')";
                    cm.Connection = cn; // informando que este comando sql será executado na conexao estabelecida
                    cm.ExecuteNonQuery();  // executando a instrução sql
                    MessageBox.Show("Dados inseridos com sucesso !!!"); // exibindo mensagem de sucesso
                    limparCampos(); // chamdno função para limpar campos

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
