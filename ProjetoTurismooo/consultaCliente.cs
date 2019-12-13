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
    public partial class consultaCliente : Form
    {
        public consultaCliente()
        {
            InitializeComponent();
        }


        //objeto SqlConnection irá se conectar a um banco de dados local, cujo nome é BDTurismo
        SqlConnection cn = new SqlConnection("User ID=sa;Password=brunoolauu;Initial Catalog=BDTurismo;Data Source=DESKTOP-KKB0QQV\\SQLSERVER14");

        // objeto SqlCommand permite a utilização de instruções sql dentro do C#
        SqlCommand cm = new SqlCommand();

        SqlDataReader objDados;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltarmenu_Click(object sender, EventArgs e)
        {
            formPrincipal novoprincipal = new formPrincipal();
            novoprincipal.Show();
            this.Hide();
        }

        private void mostrarCampos()
        {
            txtCepconsultaCliente.Visible = true;
            txtEmailconsultaCliente.Visible = true;
            txtNomeconsultaCliente.Visible = true;
            mtxtCelularconsultaCliente.Visible = true;
            mtxtCpfconsultaCliente.Visible = true;
            mtxtNasciconsultaCliente.Visible = true;
            rbtnFconsultaCliente.Visible = true;
            rbtnMconsultaCliente.Visible = true;
            btnLimparconsultaCliente.Enabled = true;
            lblCepconsultaCliente.Visible = true;
            lblConsultacorreto.Visible = true;
            lblConsultaprincipal.Visible = true;
            lblContatoconsultaCliente.Visible = true;
            lblCpfconsultaCliente.Visible = true;
            lblEmailconsultaCliente.Visible = true;
            lblNasciconsultaCliente.Visible = true;
            lblNomeconsultaCliente.Visible = true;
            lblSexoconsultaCliente.Visible = true;
            mtxtCpfconsultaCliente.Focus();
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnConsultarcliente_Click(object sender, EventArgs e)
        {
            btnLimparconsultaCliente.Enabled = true;

            if (mtxtCpfconsultaCliente.Text.Length > 10) // se o campo de pesquisa for DIFERENTE de vazio faça...
            {
                try
                {
                    
                    cn.Open();
                    cm.CommandText = "select * from tbl_cliente where cpf_cliente = @cpf";
                    cm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mtxtCpfconsultaCliente.Text;
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter(); // objeto que recebe os dados da tabela
                    DataTable dt = new DataTable(); // objeto que vai criar uma tabela virtual com os dados recebidos
                    da.SelectCommand = cm; // lendo os dados que estão na instrução cm
                    da.Fill(dt);
                    dgvDados.DataSource = dt;
                    cm.Parameters.Clear();

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
            else
            {
                MessageBox.Show("Obrigatorio peencher o campo cpf !!", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtCpfconsultaCliente.Focus();
            }
        
        }

        private void mtxtCpfconsultaCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void consultaCliente_Load(object sender, EventArgs e)
        {
            mtxtCpfconsultaCliente.Focus();
        }

        private void mtxtNasciconsultaCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void limparCampos()
        {
            lblCepconsultaCliente.Visible = false;
            lblContatoconsultaCliente.Visible = false;
            lblEmailconsultaCliente.Visible = false;
            lblNasciconsultaCliente.Visible = false;
            lblNomeconsultaCliente.Visible = false;
            lblSexoconsultaCliente.Visible = false;
            txtCepconsultaCliente.Visible = false;
            txtEmailconsultaCliente.Visible = false;
            txtNomeconsultaCliente.Visible = false;
            rbtnFconsultaCliente.Visible = false;
            rbtnMconsultaCliente.Visible = false;
            mtxtCelularconsultaCliente.Visible = false;
            mtxtNasciconsultaCliente.Visible = false;
            mtxtCpfconsultaCliente.Text = "";
            mtxtCpfconsultaCliente.Focus();
            dgvDados.DataSource = null;
        }

        private void btnLimparconsultaCliente_Click(object sender, EventArgs e)
        {


            limparCampos();



        }

        private void btnvoltarmenunormal_Click(object sender, EventArgs e)
        {
            formPrincipal novoprincipal = new formPrincipal();
            novoprincipal.Show();
            this.Hide();
        }

      
        private void dgvDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mostrarCampos();
            txtcod.Text = dgvDados.SelectedRows[0].Cells[0].Value.ToString();
            mtxtNasciconsultaCliente.Text = dgvDados.SelectedRows[0].Cells[1].Value.ToString();
            string sexo = dgvDados.SelectedRows[0].Cells[2].Value.ToString();
            if(sexo == "M")
            {
                rbtnMconsultaCliente.Checked = true;
            }
            else
            {
                rbtnFconsultaCliente.Checked = true;
            }
            txtCepconsultaCliente.Text = dgvDados.SelectedRows[0].Cells[3].Value.ToString();
            txtEmailconsultaCliente.Text = dgvDados.SelectedRows[0].Cells[4].Value.ToString();
            mtxtCpfconsultaCliente.Text = dgvDados.SelectedRows[0].Cells[5].Value.ToString();
            txtNomeconsultaCliente.Text = dgvDados.SelectedRows[0].Cells[6].Value.ToString();
            mtxtCelularconsultaCliente.Text = dgvDados.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string s;
            try
            {
                cn.Open();
                cm.CommandText = "update tbl_cliente set nasc_cliente=@nasc,sexo_cliente=@sexo,cep_cliente=@cep,email_cliente=@mail,cpf_cliente=@cpf,nome_cliente=@nome,celular_cliente=@cel where cd_cliente=@cd ";
                cm.Parameters.Add("@nasc", SqlDbType.VarChar).Value = mtxtNasciconsultaCliente.Text;
                if (rbtnFconsultaCliente.Checked)
                {
                    s = "F";
                }
                else
                {
                     s = "M";
                }
                cm.Parameters.Add("@sexo", SqlDbType.VarChar).Value = s;
                cm.Parameters.Add("@cep", SqlDbType.VarChar).Value = txtCepconsultaCliente.Text;
                cm.Parameters.Add("@mail", SqlDbType.VarChar).Value = txtEmailconsultaCliente.Text;
                cm.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mtxtCpfconsultaCliente.Text;
                cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNomeconsultaCliente.Text;
                cm.Parameters.Add("@cel", SqlDbType.VarChar).Value = mtxtCelularconsultaCliente.Text;
                cm.Parameters.Add("@cd", SqlDbType.Int).Value = Convert.ToInt32(txtcod.Text);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Deseja excluir este registro ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(resultado == DialogResult.No)
            {
                return; // não faça nada
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "delete from tbl_cliente where cd_cliente=@cd ";
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = Convert.ToInt32(txtcod.Text);
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

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTempo.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
