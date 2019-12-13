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
    public partial class formLoading : Form
    {
        public formLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;


            }
            else
            {
                timer1.Enabled = false;
                Login form = new Login();
                form.Show();
                this.Visible = false;

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
