namespace ProjetoTurismooo
{
    partial class consultaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mtxtCpfconsultaCliente = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNasciconsultaCliente = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCelularconsultaCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailconsultaCliente = new System.Windows.Forms.TextBox();
            this.txtNomeconsultaCliente = new System.Windows.Forms.TextBox();
            this.lblCpfconsultaCliente = new System.Windows.Forms.Label();
            this.lblConsultacorreto = new System.Windows.Forms.Label();
            this.lblNasciconsultaCliente = new System.Windows.Forms.Label();
            this.rbtnMconsultaCliente = new System.Windows.Forms.RadioButton();
            this.rbtnFconsultaCliente = new System.Windows.Forms.RadioButton();
            this.lblSexoconsultaCliente = new System.Windows.Forms.Label();
            this.lblEmailconsultaCliente = new System.Windows.Forms.Label();
            this.lblNomeconsultaCliente = new System.Windows.Forms.Label();
            this.lblContatoconsultaCliente = new System.Windows.Forms.Label();
            this.txtCepconsultaCliente = new System.Windows.Forms.TextBox();
            this.lblCepconsultaCliente = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnvoltarmenunormal = new System.Windows.Forms.Button();
            this.btnLimparconsultaCliente = new System.Windows.Forms.Button();
            this.btnVoltarmenu = new System.Windows.Forms.Button();
            this.lblConsultaprincipal = new System.Windows.Forms.Label();
            this.btnConsultarcliente = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtCpfconsultaCliente
            // 
            this.mtxtCpfconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtxtCpfconsultaCliente.Location = new System.Drawing.Point(447, 183);
            this.mtxtCpfconsultaCliente.Mask = "000.000.000-00";
            this.mtxtCpfconsultaCliente.Name = "mtxtCpfconsultaCliente";
            this.mtxtCpfconsultaCliente.Size = new System.Drawing.Size(131, 26);
            this.mtxtCpfconsultaCliente.TabIndex = 91;
            this.mtxtCpfconsultaCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtCpfconsultaCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCpfconsultaCliente_MaskInputRejected);
            // 
            // mtxtNasciconsultaCliente
            // 
            this.mtxtNasciconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtxtNasciconsultaCliente.Location = new System.Drawing.Point(379, 505);
            this.mtxtNasciconsultaCliente.Mask = "00/00/0000";
            this.mtxtNasciconsultaCliente.Name = "mtxtNasciconsultaCliente";
            this.mtxtNasciconsultaCliente.Size = new System.Drawing.Size(99, 26);
            this.mtxtNasciconsultaCliente.TabIndex = 93;
            this.mtxtNasciconsultaCliente.ValidatingType = typeof(System.DateTime);
            this.mtxtNasciconsultaCliente.Visible = false;
            this.mtxtNasciconsultaCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtNasciconsultaCliente_MaskInputRejected);
            // 
            // mtxtCelularconsultaCliente
            // 
            this.mtxtCelularconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtxtCelularconsultaCliente.Location = new System.Drawing.Point(567, 505);
            this.mtxtCelularconsultaCliente.Mask = "(99) 0000-00000";
            this.mtxtCelularconsultaCliente.Name = "mtxtCelularconsultaCliente";
            this.mtxtCelularconsultaCliente.Size = new System.Drawing.Size(137, 26);
            this.mtxtCelularconsultaCliente.TabIndex = 92;
            this.mtxtCelularconsultaCliente.Visible = false;
            // 
            // txtEmailconsultaCliente
            // 
            this.txtEmailconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmailconsultaCliente.Location = new System.Drawing.Point(379, 465);
            this.txtEmailconsultaCliente.Name = "txtEmailconsultaCliente";
            this.txtEmailconsultaCliente.Size = new System.Drawing.Size(443, 26);
            this.txtEmailconsultaCliente.TabIndex = 74;
            this.txtEmailconsultaCliente.Visible = false;
            // 
            // txtNomeconsultaCliente
            // 
            this.txtNomeconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeconsultaCliente.Location = new System.Drawing.Point(379, 425);
            this.txtNomeconsultaCliente.MaxLength = 75;
            this.txtNomeconsultaCliente.Name = "txtNomeconsultaCliente";
            this.txtNomeconsultaCliente.Size = new System.Drawing.Size(443, 26);
            this.txtNomeconsultaCliente.TabIndex = 71;
            this.txtNomeconsultaCliente.Visible = false;
            // 
            // lblCpfconsultaCliente
            // 
            this.lblCpfconsultaCliente.AutoSize = true;
            this.lblCpfconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpfconsultaCliente.Location = new System.Drawing.Point(443, 160);
            this.lblCpfconsultaCliente.Name = "lblCpfconsultaCliente";
            this.lblCpfconsultaCliente.Size = new System.Drawing.Size(40, 20);
            this.lblCpfconsultaCliente.TabIndex = 69;
            this.lblCpfconsultaCliente.Text = "CPF";
            // 
            // lblConsultacorreto
            // 
            this.lblConsultacorreto.AutoSize = true;
            this.lblConsultacorreto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConsultacorreto.ForeColor = System.Drawing.Color.Red;
            this.lblConsultacorreto.Location = new System.Drawing.Point(425, 132);
            this.lblConsultacorreto.Name = "lblConsultacorreto";
            this.lblConsultacorreto.Size = new System.Drawing.Size(174, 17);
            this.lblConsultacorreto.TabIndex = 98;
            this.lblConsultacorreto.Text = "Digite o CPF corretamente";
            // 
            // lblNasciconsultaCliente
            // 
            this.lblNasciconsultaCliente.AutoSize = true;
            this.lblNasciconsultaCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNasciconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNasciconsultaCliente.Location = new System.Drawing.Point(280, 511);
            this.lblNasciconsultaCliente.Name = "lblNasciconsultaCliente";
            this.lblNasciconsultaCliente.Size = new System.Drawing.Size(93, 20);
            this.lblNasciconsultaCliente.TabIndex = 68;
            this.lblNasciconsultaCliente.Text = "Nascimento";
            this.lblNasciconsultaCliente.Visible = false;
            // 
            // rbtnMconsultaCliente
            // 
            this.rbtnMconsultaCliente.AutoSize = true;
            this.rbtnMconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnMconsultaCliente.Location = new System.Drawing.Point(664, 549);
            this.rbtnMconsultaCliente.Name = "rbtnMconsultaCliente";
            this.rbtnMconsultaCliente.Size = new System.Drawing.Size(40, 24);
            this.rbtnMconsultaCliente.TabIndex = 89;
            this.rbtnMconsultaCliente.TabStop = true;
            this.rbtnMconsultaCliente.Text = "M";
            this.rbtnMconsultaCliente.UseVisualStyleBackColor = true;
            this.rbtnMconsultaCliente.Visible = false;
            // 
            // rbtnFconsultaCliente
            // 
            this.rbtnFconsultaCliente.AutoSize = true;
            this.rbtnFconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnFconsultaCliente.Location = new System.Drawing.Point(618, 549);
            this.rbtnFconsultaCliente.Name = "rbtnFconsultaCliente";
            this.rbtnFconsultaCliente.Size = new System.Drawing.Size(37, 24);
            this.rbtnFconsultaCliente.TabIndex = 88;
            this.rbtnFconsultaCliente.TabStop = true;
            this.rbtnFconsultaCliente.Text = "F";
            this.rbtnFconsultaCliente.UseVisualStyleBackColor = true;
            this.rbtnFconsultaCliente.Visible = false;
            // 
            // lblSexoconsultaCliente
            // 
            this.lblSexoconsultaCliente.AutoSize = true;
            this.lblSexoconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSexoconsultaCliente.Location = new System.Drawing.Point(563, 551);
            this.lblSexoconsultaCliente.Name = "lblSexoconsultaCliente";
            this.lblSexoconsultaCliente.Size = new System.Drawing.Size(45, 20);
            this.lblSexoconsultaCliente.TabIndex = 87;
            this.lblSexoconsultaCliente.Text = "Sexo";
            this.lblSexoconsultaCliente.Visible = false;
            // 
            // lblEmailconsultaCliente
            // 
            this.lblEmailconsultaCliente.AutoSize = true;
            this.lblEmailconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmailconsultaCliente.Location = new System.Drawing.Point(325, 468);
            this.lblEmailconsultaCliente.Name = "lblEmailconsultaCliente";
            this.lblEmailconsultaCliente.Size = new System.Drawing.Size(48, 20);
            this.lblEmailconsultaCliente.TabIndex = 73;
            this.lblEmailconsultaCliente.Text = "Email";
            this.lblEmailconsultaCliente.Visible = false;
            // 
            // lblNomeconsultaCliente
            // 
            this.lblNomeconsultaCliente.AutoSize = true;
            this.lblNomeconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeconsultaCliente.Location = new System.Drawing.Point(322, 431);
            this.lblNomeconsultaCliente.Name = "lblNomeconsultaCliente";
            this.lblNomeconsultaCliente.Size = new System.Drawing.Size(51, 20);
            this.lblNomeconsultaCliente.TabIndex = 67;
            this.lblNomeconsultaCliente.Text = "Nome";
            this.lblNomeconsultaCliente.Visible = false;
            // 
            // lblContatoconsultaCliente
            // 
            this.lblContatoconsultaCliente.AutoSize = true;
            this.lblContatoconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContatoconsultaCliente.Location = new System.Drawing.Point(503, 511);
            this.lblContatoconsultaCliente.Name = "lblContatoconsultaCliente";
            this.lblContatoconsultaCliente.Size = new System.Drawing.Size(58, 20);
            this.lblContatoconsultaCliente.TabIndex = 72;
            this.lblContatoconsultaCliente.Text = "Celular";
            this.lblContatoconsultaCliente.Visible = false;
            // 
            // txtCepconsultaCliente
            // 
            this.txtCepconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCepconsultaCliente.Location = new System.Drawing.Point(379, 545);
            this.txtCepconsultaCliente.Name = "txtCepconsultaCliente";
            this.txtCepconsultaCliente.Size = new System.Drawing.Size(160, 26);
            this.txtCepconsultaCliente.TabIndex = 82;
            this.txtCepconsultaCliente.Visible = false;
            // 
            // lblCepconsultaCliente
            // 
            this.lblCepconsultaCliente.AutoSize = true;
            this.lblCepconsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCepconsultaCliente.Location = new System.Drawing.Point(332, 551);
            this.lblCepconsultaCliente.Name = "lblCepconsultaCliente";
            this.lblCepconsultaCliente.Size = new System.Drawing.Size(41, 20);
            this.lblCepconsultaCliente.TabIndex = 76;
            this.lblCepconsultaCliente.Text = "CEP";
            this.lblCepconsultaCliente.Visible = false;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(301, 229);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(701, 176);
            this.dgvDados.TabIndex = 107;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            this.dgvDados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDados_MouseDoubleClick);
            // 
            // txtcod
            // 
            this.txtcod.Enabled = false;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcod.Location = new System.Drawing.Point(842, 425);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(160, 26);
            this.txtcod.TabIndex = 108;
            this.txtcod.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_Streamline_70_185090;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(1211, 307);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 47);
            this.btnExcluir.TabIndex = 110;
            this.btnExcluir.Text = "         Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_UI_Basic_GLYPH_48_4733376;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(1211, 227);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(96, 47);
            this.btnAlterar.TabIndex = 109;
            this.btnAlterar.Text = "       Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnvoltarmenunormal
            // 
            this.btnvoltarmenunormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnvoltarmenunormal.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_back_3224191;
            this.btnvoltarmenunormal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltarmenunormal.Location = new System.Drawing.Point(1093, 637);
            this.btnvoltarmenunormal.Name = "btnvoltarmenunormal";
            this.btnvoltarmenunormal.Size = new System.Drawing.Size(246, 38);
            this.btnvoltarmenunormal.TabIndex = 106;
            this.btnvoltarmenunormal.Text = "    Voltar para Menu Principal";
            this.btnvoltarmenunormal.UseVisualStyleBackColor = true;
            this.btnvoltarmenunormal.Click += new System.EventHandler(this.btnvoltarmenunormal_Click);
            // 
            // btnLimparconsultaCliente
            // 
            this.btnLimparconsultaCliente.Enabled = false;
            this.btnLimparconsultaCliente.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_eraser_16086791;
            this.btnLimparconsultaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparconsultaCliente.Location = new System.Drawing.Point(1211, 385);
            this.btnLimparconsultaCliente.Name = "btnLimparconsultaCliente";
            this.btnLimparconsultaCliente.Size = new System.Drawing.Size(96, 45);
            this.btnLimparconsultaCliente.TabIndex = 101;
            this.btnLimparconsultaCliente.Text = "   Limpar";
            this.btnLimparconsultaCliente.UseVisualStyleBackColor = true;
            this.btnLimparconsultaCliente.Click += new System.EventHandler(this.btnLimparconsultaCliente_Click);
            // 
            // btnVoltarmenu
            // 
            this.btnVoltarmenu.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_back_322419;
            this.btnVoltarmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarmenu.Location = new System.Drawing.Point(1354, 760);
            this.btnVoltarmenu.Name = "btnVoltarmenu";
            this.btnVoltarmenu.Size = new System.Drawing.Size(184, 34);
            this.btnVoltarmenu.TabIndex = 100;
            this.btnVoltarmenu.Text = "        Voltar para menu principal";
            this.btnVoltarmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarmenu.UseVisualStyleBackColor = true;
            this.btnVoltarmenu.Click += new System.EventHandler(this.btnVoltarmenu_Click);
            // 
            // lblConsultaprincipal
            // 
            this.lblConsultaprincipal.AutoSize = true;
            this.lblConsultaprincipal.Font = new System.Drawing.Font("Arial Narrow", 24.75F);
            this.lblConsultaprincipal.ForeColor = System.Drawing.Color.Brown;
            this.lblConsultaprincipal.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_001_95895__1_;
            this.lblConsultaprincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConsultaprincipal.Location = new System.Drawing.Point(482, 49);
            this.lblConsultaprincipal.Name = "lblConsultaprincipal";
            this.lblConsultaprincipal.Size = new System.Drawing.Size(296, 40);
            this.lblConsultaprincipal.TabIndex = 99;
            this.lblConsultaprincipal.Text = "Consulta de Cliente     ";
            // 
            // btnConsultarcliente
            // 
            this.btnConsultarcliente.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_Marketing_Icon_Outline_17_4579059;
            this.btnConsultarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarcliente.Location = new System.Drawing.Point(713, 159);
            this.btnConsultarcliente.Name = "btnConsultarcliente";
            this.btnConsultarcliente.Size = new System.Drawing.Size(109, 50);
            this.btnConsultarcliente.TabIndex = 96;
            this.btnConsultarcliente.Text = "       Consultar";
            this.btnConsultarcliente.UseVisualStyleBackColor = true;
            this.btnConsultarcliente.Click += new System.EventHandler(this.btnConsultarcliente_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.Enabled = false;
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTempo.Location = new System.Drawing.Point(53, 639);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(124, 30);
            this.txtTempo.TabIndex = 111;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // consultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblCepconsultaCliente);
            this.Controls.Add(this.btnvoltarmenunormal);
            this.Controls.Add(this.txtCepconsultaCliente);
            this.Controls.Add(this.lblContatoconsultaCliente);
            this.Controls.Add(this.lblSexoconsultaCliente);
            this.Controls.Add(this.btnLimparconsultaCliente);
            this.Controls.Add(this.rbtnFconsultaCliente);
            this.Controls.Add(this.lblEmailconsultaCliente);
            this.Controls.Add(this.rbtnMconsultaCliente);
            this.Controls.Add(this.lblNomeconsultaCliente);
            this.Controls.Add(this.btnVoltarmenu);
            this.Controls.Add(this.lblConsultaprincipal);
            this.Controls.Add(this.lblConsultacorreto);
            this.Controls.Add(this.btnConsultarcliente);
            this.Controls.Add(this.mtxtCpfconsultaCliente);
            this.Controls.Add(this.lblNasciconsultaCliente);
            this.Controls.Add(this.mtxtNasciconsultaCliente);
            this.Controls.Add(this.mtxtCelularconsultaCliente);
            this.Controls.Add(this.txtEmailconsultaCliente);
            this.Controls.Add(this.txtNomeconsultaCliente);
            this.Controls.Add(this.lblCpfconsultaCliente);
            this.Name = "consultaCliente";
            this.Text = "SGAT Sistema Gerenciador de Agência de Turismo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.consultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtCpfconsultaCliente;
        private System.Windows.Forms.MaskedTextBox mtxtNasciconsultaCliente;
        private System.Windows.Forms.MaskedTextBox mtxtCelularconsultaCliente;
        private System.Windows.Forms.TextBox txtEmailconsultaCliente;
        private System.Windows.Forms.TextBox txtNomeconsultaCliente;
        private System.Windows.Forms.Label lblCpfconsultaCliente;
        private System.Windows.Forms.Button btnConsultarcliente;
        private System.Windows.Forms.Label lblConsultacorreto;
        private System.Windows.Forms.Label lblConsultaprincipal;
        private System.Windows.Forms.Button btnVoltarmenu;
        private System.Windows.Forms.Button btnLimparconsultaCliente;
        private System.Windows.Forms.Button btnvoltarmenunormal;
        private System.Windows.Forms.Label lblNasciconsultaCliente;
        private System.Windows.Forms.RadioButton rbtnMconsultaCliente;
        private System.Windows.Forms.RadioButton rbtnFconsultaCliente;
        private System.Windows.Forms.Label lblSexoconsultaCliente;
        private System.Windows.Forms.Label lblEmailconsultaCliente;
        private System.Windows.Forms.Label lblNomeconsultaCliente;
        private System.Windows.Forms.Label lblContatoconsultaCliente;
        private System.Windows.Forms.TextBox txtCepconsultaCliente;
        private System.Windows.Forms.Label lblCepconsultaCliente;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Timer timer1;
    }
}