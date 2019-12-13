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
    public partial class consultaPacote : Form
    {
        public consultaPacote()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("User ID=sa;Password=brunoolauu;Initial Catalog=BDTurismo;Data Source=DESKTOP-KKB0QQV\\SQLSERVER14");

        // objeto SqlCommand permite a utilização de instruções sql dentro do C#
        SqlCommand cm = new SqlCommand();

        SqlDataReader objDados;

        private void btnVoltarmenu_Click(object sender, EventArgs e)
        {
            formPrincipal novoprincipal = new formPrincipal();
            novoprincipal.Show();
            this.Hide();
        }

        private void mostraCampos()
        {
            btnAlterarPacote.Enabled = true;
            btnExcluirPacote.Enabled = true;
            maskedHoraConsultapacote.Enabled = true;
            datetimeDataConsultapacote.Enabled = true;
            datetimeRetornoConsultapacote.Enabled = true;
            txtdestinopacote.Visible = true;
            lbldestinopacote.Visible = true;
            txtdestinopacote.Enabled = true;
            txtHospedagemConsultapacote.Enabled = true;
            txtNomeconsultaPacote.Enabled = true;
            lblDataConsultapacote.Visible = true;
            lblHoraConsultapacote.Visible = true;
            lblHospedagemConsultapacote.Visible = true;
            lblNomeconsultaPacote.Visible = true;
            lblRetornoConsultapacote.Visible = true;
            txtNomeconsultaPacote.Visible = true;
            datetimeDataConsultapacote.Visible = true;
            datetimeRetornoConsultapacote.Visible = true;
            btnLimparconsultaPacote.Enabled = true;
            maskedHoraConsultapacote.Visible = true;
            txtHospedagemConsultapacote.Visible = true;
        }

        private void btnConsultaPacote_Click(object sender, EventArgs e)
        {
            btnLimparconsultaPacote.Enabled = true;
            btnAlterarPacote.Enabled = true;
            btnExcluirPacote.Enabled = true;

            if (txtNomeconsultaPacote.Text != "") // se o campo de pesquisa for DIFERENTE de vazio faça...
            {
                try
                {

                    cn.Open();
                    cm.CommandText = "select * from tbl_pacotee where nm_pacotee = @nome";
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeconsultaPacote.Text;
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter(); // objeto que recebe os dados da tabela
                    DataTable dt = new DataTable(); // objeto que vai criar uma tabela virtual com os dados recebidos
                    da.SelectCommand = cm; // lendo os dados que estão na instrução cm
                    da.Fill(dt);
                    dgvDadosPacote.DataSource = dt;
                    cm.Parameters.Clear();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

                finally
                {
                    cn.Close();
                }

            }
            else
            {
                MessageBox.Show("Obrigatorio peencher o campo Nome !!", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeconsultaPacote.Focus();
            }
        }

        private void limparCampos()
        {
            lblDataConsultapacote.Visible = false;
            lblHoraConsultapacote.Visible = false;
            lblHospedagemConsultapacote.Visible = false;
            lblRetornoConsultapacote.Visible = false;
            txtHospedagemConsultapacote.Visible = false;
            maskedHoraConsultapacote.Visible = false;
            datetimeDataConsultapacote.Visible = false;
            datetimeRetornoConsultapacote.Visible = false;
            txtNomeconsultaPacote.Text = "";
            txtNomeconsultaPacote.Focus();
            dgvDadosPacote.DataSource = null;
            txtdestinopacote.Visible = false;
            lbldestinopacote.Visible = false;
            txtprecoconsultapacote.Visible = false;
            lblPrecoconsultapacote.Visible = false;
        }

        private void btnLimparconsultaPacote_Click(object sender, EventArgs e)
        {
            limparCampos();

        }

        private void btnvoltarmenunormal_Click(object sender, EventArgs e)
        {
            formPrincipal novoprincipal = new formPrincipal();
            novoprincipal.Show();
            this.Hide();
        }

        private void consultaPacote_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTempo.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAlterarPacote_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm.CommandText = "update tbl_pacotee set hospedagem_pacotee=@hosp,hrsaida_pacotee=@hora,dtsaida_pacotee=@saida,dtretorno_pacotee=@retorno,destino_pacotee=@destino,nm_pacotee=@nome,preco_pacotee=@preco where cd_pacotee=@cd ";
                cm.Parameters.Add("@hosp", SqlDbType.VarChar).Value = txtHospedagemConsultapacote.Text;
                cm.Parameters.Add("@hora", SqlDbType.VarChar).Value = maskedHoraConsultapacote.Text;
                cm.Parameters.Add("@saida", SqlDbType.VarChar).Value = datetimeDataConsultapacote.Text;
                cm.Parameters.Add("@retorno", SqlDbType.VarChar).Value = datetimeRetornoConsultapacote.Text;
                cm.Parameters.Add("@destino", SqlDbType.VarChar).Value = txtdestinopacote.Text;
                cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeconsultaPacote.Text;
                cm.Parameters.Add("@preco", SqlDbType.VarChar).Value = txtprecoconsultapacote.Text;
                cm.Parameters.Add("@cd", SqlDbType.VarChar).Value = txtcodPacote.Text;
                cm.Connection = cn;

                cm.ExecuteNonQuery();

                MessageBox.Show("Dados ALTERADOS com sucesso !!", "Dados Alterados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                cm.Parameters.Clear();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            finally
            {
                cn.Close();
            }





        }
        private void mostrarCampos()
        {
            lbldestinopacote.Visible = true;
            lblHoraConsultapacote.Visible = true;
            lblDataConsultapacote.Visible = true;
            lblRetornoConsultapacote.Visible = true;
            lblHoraConsultapacote.Visible = true;
            txtdestinopacote.Visible = true;
            txtHospedagemConsultapacote.Visible = true;
            datetimeDataConsultapacote.Visible = true;
            datetimeRetornoConsultapacote.Visible = true;
            maskedHoraConsultapacote.Visible = true;
            txtdestinopacote.Visible = true;
            txtHospedagemConsultapacote.Enabled = true;
            datetimeDataConsultapacote.Enabled = true;
            datetimeRetornoConsultapacote.Enabled = true;
            maskedHoraConsultapacote.Enabled = true;
            lblPrecoconsultapacote.Visible = true;
            txtprecoconsultapacote.Visible = true;
            lblPrecoconsultapacote.Enabled = true;
            txtprecoconsultapacote.Enabled = true;
            lblHospedagemConsultapacote.Visible = true;



        }

        private void dgvDadosPacote_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mostrarCampos();
            txtcodPacote.Text = dgvDadosPacote.SelectedRows[0].Cells[0].Value.ToString();
            txtHospedagemConsultapacote.Text = dgvDadosPacote.SelectedRows[0].Cells[1].Value.ToString();
            maskedHoraConsultapacote.Text = dgvDadosPacote.SelectedRows[0].Cells[2].Value.ToString();
            datetimeDataConsultapacote.Text = dgvDadosPacote.SelectedRows[0].Cells[3].Value.ToString();
            datetimeRetornoConsultapacote.Text = dgvDadosPacote.SelectedRows[0].Cells[4].Value.ToString();
            txtdestinopacote.Text = dgvDadosPacote.SelectedRows[0].Cells[5].Value.ToString();
            txtNomeconsultaPacote.Text = dgvDadosPacote.SelectedRows[0].Cells[6].Value.ToString();
            txtprecoconsultapacote.Text = dgvDadosPacote.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void btnExcluirPacote_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir este registro ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.No)
            {
                return; // não faça nada
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "delete from tbl_pacotee where cd_pacotee=@cd ";
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = Convert.ToInt32(txtcodPacote.Text);
                    cm.Connection = cn;

                    cm.ExecuteNonQuery();

                    MessageBox.Show("Dados Excluidos com sucesso !!", "Dados Excluidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    cm.Parameters.Clear();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

                finally
                {
                    cn.Close();
                }

            }
        }
    }
}
