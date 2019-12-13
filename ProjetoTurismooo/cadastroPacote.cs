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
    public partial class cadastroPacote : Form
    {
        public cadastroPacote()
        {
            InitializeComponent();
        }
        //objeto SqlConnection irá se conectar a um banco de dados local, cujo nome é BDTurismo
        SqlConnection cn = new SqlConnection("User ID=sa;Password=brunoolauu;Initial Catalog=BDTurismo;Data Source=DESKTOP-KKB0QQV\\SQLSERVER14");

        // objeto SqlCommand permite a utilização de instruções sql dentro do C#
        SqlCommand cm = new SqlCommand();

        private void btnVoltarmenu_Click(object sender, EventArgs e)
        {
            formPrincipal novoprincipal = new formPrincipal();
            novoprincipal.Show();
            this.Hide();
        }

        private void btnNovopacote_Click(object sender, EventArgs e)
        {
            lblpreencha.Visible = true;
            txtprecocadastropacote.Enabled = true;
            txtDestinopacote.Enabled = true;
            txtHospedagempacote.Enabled = true;
            txtNomepacote.Enabled = true;
            btnCadastrarpacote.Enabled = true;
            btnLimparpacote.Enabled = true;
            datetimeDatapacote.Enabled = true;
            datetimeRetornopacote.Enabled = true;
            maskedHorapacote.Enabled = true;
            txtNomepacote.Focus();
            btnNovopacote.Enabled = false;

        }
        private void LimparCampos()
        {
            txtprecocadastropacote.Text = "";
            txtDestinopacote.Text = "";
            txtHospedagempacote.Text = "";
            txtNomepacote.Text = "";
            maskedHorapacote.Text = "";
            txtNomepacote.Focus();
        }

        private void btnLimparpacote_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCadastrarpacote_Click(object sender, EventArgs e)
        {
            if (maskedHorapacote.Text == "" || txtDestinopacote.Text == "" || txtHospedagempacote.Text == "" || txtNomepacote.Text == "" || txtprecocadastropacote.Text == "")
            {
                MessageBox.Show("Preencha todos os campos !!", "E R R O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {


                try // ao clicar no botão o metodo tentará executar este bloco, se der erro vai para o catch
                {
                    cn.Open(); // abrindo conexão com o banco de dados
                    cm.CommandText = "insert into tbl_pacotee(nm_pacotee,destino_pacotee,dtsaida_pacotee,dtretorno_pacotee,hospedagem_pacotee,hrsaida_pacotee,preco_pacotee) values('" + txtNomepacote.Text + "','" + txtDestinopacote.Text + "','" + datetimeDatapacote.Text + "','" + datetimeRetornopacote.Text + "', '" + txtHospedagempacote.Text + "','" + maskedHorapacote.Text + "','" + txtprecocadastropacote.Text + "')";
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
