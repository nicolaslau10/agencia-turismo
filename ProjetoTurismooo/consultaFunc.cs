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
    public partial class consultaFunc : Form
    {
        public consultaFunc()
        {
            InitializeComponent();
        }

        //objeto SqlConnection irá se conectar a um banco de dados local, cujo nome é BDTurismo
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
        private void mostrarCampos()
        {

            txtNomeconsultaFunc.Enabled = true;
            txtSenhaconsultaFunc.Enabled = true;
            btnAlterarFunc.Enabled = true;
            btnExcluirFunc.Enabled = true;
            txtNomeconsultaFunc.Visible = true;
            txtSenhaconsultaFunc.Visible = true;
            lblNomeconsultaFunc.Visible = true;
            lblSenhaconsultaFunc.Visible = true;
            btnLimparconsultaFunc.Enabled = true;
            lblCpfconsultaFunc.Enabled = true;
            mtxtCpfconsultaFunc.Visible = true;
            mtxtCpfconsultaFunc.Enabled = true;
            lblCpfconsultaFunc.Visible = true;

        }

        private void btnConsultafunc_Click(object sender, EventArgs e)
        {
            btnLimparconsultaFunc.Enabled = true;

            if (txtEmailconsultaFunc.Text != "") // se o campo de pesquisa for DIFERENTE de vazio faça...
            {
                try
                {

                    cn.Open();
                    cm.CommandText = "select * from tbl_usuario where email_usuario = @email";
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmailconsultaFunc.Text;
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter(); // objeto que recebe os dados da tabela
                    DataTable dt = new DataTable(); // objeto que vai criar uma tabela virtual com os dados recebidos
                    da.SelectCommand = cm; // lendo os dados que estão na instrução cm
                    da.Fill(dt);
                    dgvDadosFunc.DataSource = dt;
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
                MessageBox.Show("Obrigatorio peencher o campo Email !!", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtCpfconsultaFunc.Focus();
            }

        }
        
        private void limparCampos()
        {
            mtxtCpfconsultaFunc.Text = "";
            lblNomeconsultaFunc.Visible = false;
            lblSenhaconsultaFunc.Visible = false;
            txtNomeconsultaFunc.Visible = false;
            txtSenhaconsultaFunc.Visible = false;
            mtxtCpfconsultaFunc.Focus();
            dgvDadosFunc.DataSource = null;
            txtEmailconsultaFunc.Text = "";
            txtEmailconsultaFunc.Focus();
            lblCpfconsultaFunc.Visible = false;
            mtxtCpfconsultaFunc.Visible = false;
        }

        private void btnLimparconsultaFunc_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
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
                    cm.CommandText = "delete from tbl_usuario where cdlogin_usuario=@cd ";
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = Convert.ToInt32(txtcodFunc.Text);
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

        private void btnvoltarmenunormal_Click(object sender, EventArgs e)
        {
            formPrincipal novoprincipal = new formPrincipal();
            novoprincipal.Show();
            this.Hide();
        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTempo.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvDadosFunc_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            mostrarCampos();
            txtcodFunc.Text = dgvDadosFunc.SelectedRows[0].Cells[0].Value.ToString();
            txtEmailconsultaFunc.Text = dgvDadosFunc.SelectedRows[0].Cells[1].Value.ToString();
            txtSenhaconsultaFunc.Text = dgvDadosFunc.SelectedRows[0].Cells[2].Value.ToString();
            txtNomeconsultaFunc.Text = dgvDadosFunc.SelectedRows[0].Cells[3].Value.ToString();
            mtxtCpfconsultaFunc.Text = dgvDadosFunc.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnAlterarFunc_Click(object sender, EventArgs e)
        {
            
            try
            {
                cn.Open();
                cm.CommandText = "update tbl_usuario set email_usuario=@mail,senha_usuario=@senha,nm_usuario=@nome,cpf_usuario=@cpf where cdlogin_usuario=@cd ";
                cm.Parameters.Add("@mail", SqlDbType.VarChar).Value = txtEmailconsultaFunc.Text;
                cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenhaconsultaFunc.Text;
                cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeconsultaFunc.Text;
                cm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mtxtCpfconsultaFunc.Text;
                cm.Parameters.Add("@cd", SqlDbType.VarChar).Value = txtcodFunc.Text;
                cm.Connection = cn;

                cm.ExecuteNonQuery();

                MessageBox.Show("Dados ALTERADO0S com sucesso !!", "Dados Alterados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
