namespace ProjetoTurismooo
{
    partial class cadastroCliente
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.lblMax = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.mskNasc = new System.Windows.Forms.DateTimePicker();
            this.btnVoltarmenu = new System.Windows.Forms.Button();
            this.btnNovocliente = new System.Windows.Forms.Button();
            this.btnLimparcliente = new System.Windows.Forms.Button();
            this.btnCadastrarcliente = new System.Windows.Forms.Button();
            this.lblCadastrodepassageiro = new System.Windows.Forms.Label();
            this.btnvoltarmenunormal = new System.Windows.Forms.Button();
            this.lblpreenchacliente = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(626, 340);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 26);
            this.txtEmail.TabIndex = 37;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(622, 312);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContato.Location = new System.Drawing.Point(407, 313);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(58, 20);
            this.lblContato.TabIndex = 35;
            this.lblContato.Text = "Celular";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(411, 205);
            this.txtNome.MaxLength = 75;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(376, 26);
            this.txtNome.TabIndex = 31;
            this.txtNome.TextChanged += new System.EventHandler(this.txtPassageiro_TextChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpf.Location = new System.Drawing.Point(623, 242);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 29;
            this.lblCpf.Text = "CPF";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNascimento.Location = new System.Drawing.Point(407, 242);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(93, 20);
            this.lblNascimento.TabIndex = 28;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNome.Location = new System.Drawing.Point(407, 178);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Nome";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSexo.Location = new System.Drawing.Point(847, 178);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 52;
            this.lblSexo.Text = "Sexo";
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Enabled = false;
            this.rbtnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnF.Location = new System.Drawing.Point(851, 205);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(37, 24);
            this.rbtnF.TabIndex = 53;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "F";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Enabled = false;
            this.rbtnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnM.Location = new System.Drawing.Point(918, 205);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(40, 24);
            this.rbtnM.TabIndex = 54;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "M";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(674, 189);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(113, 13);
            this.lblMax.TabIndex = 62;
            this.lblMax.Text = "máximo: 75 caracteres";
            // 
            // mskCelular
            // 
            this.mskCelular.Enabled = false;
            this.mskCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskCelular.Location = new System.Drawing.Point(411, 340);
            this.mskCelular.Mask = "(99) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(137, 26);
            this.mskCelular.TabIndex = 64;
            this.mskCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskCPF
            // 
            this.mskCPF.Enabled = false;
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskCPF.Location = new System.Drawing.Point(627, 269);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(131, 26);
            this.mskCPF.TabIndex = 66;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCep.Location = new System.Drawing.Point(847, 246);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(41, 20);
            this.lblCep.TabIndex = 39;
            this.lblCep.Text = "CEP";
            // 
            // mskCep
            // 
            this.mskCep.Enabled = false;
            this.mskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskCep.Location = new System.Drawing.Point(851, 269);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(137, 26);
            this.mskCep.TabIndex = 67;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskNasc
            // 
            this.mskNasc.Enabled = false;
            this.mskNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskNasc.Location = new System.Drawing.Point(411, 269);
            this.mskNasc.Name = "mskNasc";
            this.mskNasc.Size = new System.Drawing.Size(151, 26);
            this.mskNasc.TabIndex = 68;
            // 
            // btnVoltarmenu
            // 
            this.btnVoltarmenu.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_back_322419;
            this.btnVoltarmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarmenu.Location = new System.Drawing.Point(1379, 764);
            this.btnVoltarmenu.Name = "btnVoltarmenu";
            this.btnVoltarmenu.Size = new System.Drawing.Size(184, 34);
            this.btnVoltarmenu.TabIndex = 61;
            this.btnVoltarmenu.Text = "        Voltar para menu principal";
            this.btnVoltarmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarmenu.UseVisualStyleBackColor = true;
            this.btnVoltarmenu.Click += new System.EventHandler(this.btnVoltarmenu_Click);
            // 
            // btnNovocliente
            // 
            this.btnNovocliente.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_document_text_add_103511__1_;
            this.btnNovocliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovocliente.Location = new System.Drawing.Point(460, 502);
            this.btnNovocliente.Name = "btnNovocliente";
            this.btnNovocliente.Size = new System.Drawing.Size(96, 45);
            this.btnNovocliente.TabIndex = 60;
            this.btnNovocliente.Text = " Novo";
            this.btnNovocliente.UseVisualStyleBackColor = true;
            this.btnNovocliente.Click += new System.EventHandler(this.btnNovocliente_Click);
            // 
            // btnLimparcliente
            // 
            this.btnLimparcliente.Enabled = false;
            this.btnLimparcliente.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_eraser_16086791;
            this.btnLimparcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparcliente.Location = new System.Drawing.Point(866, 502);
            this.btnLimparcliente.Name = "btnLimparcliente";
            this.btnLimparcliente.Size = new System.Drawing.Size(96, 45);
            this.btnLimparcliente.TabIndex = 56;
            this.btnLimparcliente.Text = "Limpar";
            this.btnLimparcliente.UseVisualStyleBackColor = true;
            this.btnLimparcliente.Click += new System.EventHandler(this.btnLimparcliente_Click);
            // 
            // btnCadastrarcliente
            // 
            this.btnCadastrarcliente.Enabled = false;
            this.btnCadastrarcliente.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_plus_1814113__1_;
            this.btnCadastrarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarcliente.Location = new System.Drawing.Point(663, 502);
            this.btnCadastrarcliente.Name = "btnCadastrarcliente";
            this.btnCadastrarcliente.Size = new System.Drawing.Size(96, 45);
            this.btnCadastrarcliente.TabIndex = 55;
            this.btnCadastrarcliente.Text = "      Cadastrar";
            this.btnCadastrarcliente.UseVisualStyleBackColor = true;
            this.btnCadastrarcliente.Click += new System.EventHandler(this.btnCadastrarcliente_Click);
            // 
            // lblCadastrodepassageiro
            // 
            this.lblCadastrodepassageiro.AutoSize = true;
            this.lblCadastrodepassageiro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrodepassageiro.Font = new System.Drawing.Font("Arial Narrow", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrodepassageiro.ForeColor = System.Drawing.Color.Brown;
            this.lblCadastrodepassageiro.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_photo_370076__1_;
            this.lblCadastrodepassageiro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCadastrodepassageiro.Location = new System.Drawing.Point(531, 42);
            this.lblCadastrodepassageiro.Name = "lblCadastrodepassageiro";
            this.lblCadastrodepassageiro.Size = new System.Drawing.Size(299, 40);
            this.lblCadastrodepassageiro.TabIndex = 51;
            this.lblCadastrodepassageiro.Text = "Cadastro de Cliente     ";
            // 
            // btnvoltarmenunormal
            // 
            this.btnvoltarmenunormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnvoltarmenunormal.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_back_3224191;
            this.btnvoltarmenunormal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltarmenunormal.Location = new System.Drawing.Point(1112, 651);
            this.btnvoltarmenunormal.Name = "btnvoltarmenunormal";
            this.btnvoltarmenunormal.Size = new System.Drawing.Size(246, 38);
            this.btnvoltarmenunormal.TabIndex = 77;
            this.btnvoltarmenunormal.Text = "    Voltar para Menu Principal";
            this.btnvoltarmenunormal.UseVisualStyleBackColor = true;
            this.btnvoltarmenunormal.Click += new System.EventHandler(this.btnvoltarmenunormal_Click);
            // 
            // lblpreenchacliente
            // 
            this.lblpreenchacliente.AutoSize = true;
            this.lblpreenchacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblpreenchacliente.ForeColor = System.Drawing.Color.DarkRed;
            this.lblpreenchacliente.Location = new System.Drawing.Point(549, 429);
            this.lblpreenchacliente.Name = "lblpreenchacliente";
            this.lblpreenchacliente.Size = new System.Drawing.Size(270, 18);
            this.lblpreenchacliente.TabIndex = 79;
            this.lblpreenchacliente.Text = "Preencha todos os CAMPOS, por favor";
            this.lblpreenchacliente.Visible = false;
            // 
            // txtTempo
            // 
            this.txtTempo.Enabled = false;
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTempo.Location = new System.Drawing.Point(49, 640);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(124, 30);
            this.txtTempo.TabIndex = 80;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblpreenchacliente);
            this.Controls.Add(this.btnvoltarmenunormal);
            this.Controls.Add(this.mskNasc);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.btnVoltarmenu);
            this.Controls.Add(this.btnNovocliente);
            this.Controls.Add(this.btnLimparcliente);
            this.Controls.Add(this.btnCadastrarcliente);
            this.Controls.Add(this.rbtnM);
            this.Controls.Add(this.rbtnF);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCadastrodepassageiro);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblNome);
            this.Name = "cadastroCliente";
            this.Text = "SGAT Sistema Gerenciador de Agência de Turismo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCadastrodepassageiro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.Button btnCadastrarcliente;
        private System.Windows.Forms.Button btnNovocliente;
        private System.Windows.Forms.Button btnVoltarmenu;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Button btnLimparcliente;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.DateTimePicker mskNasc;
        private System.Windows.Forms.Button btnvoltarmenunormal;
        private System.Windows.Forms.Label lblpreenchacliente;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Timer timer1;
    }
}