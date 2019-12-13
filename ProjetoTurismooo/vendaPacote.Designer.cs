namespace ProjetoTurismooo
{
    partial class vendaPacote
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
            this.lblFuncvenda = new System.Windows.Forms.Label();
            this.txtFuncvenda = new System.Windows.Forms.TextBox();
            this.lblCpfclientevenda = new System.Windows.Forms.Label();
            this.mskCPFvendaa = new System.Windows.Forms.MaskedTextBox();
            this.lblPacotevenda = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblcpfvenda = new System.Windows.Forms.Label();
            this.lblfunvvendapacote = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnvoltarmenunormal = new System.Windows.Forms.Button();
            this.btnvenda = new System.Windows.Forms.Button();
            this.btnLimparvenda = new System.Windows.Forms.Button();
            this.btncadastravenda = new System.Windows.Forms.Button();
            this.lblVendapacote = new System.Windows.Forms.Label();
            this.lblpreenchavenda = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblFuncvenda
            // 
            this.lblFuncvenda.AutoSize = true;
            this.lblFuncvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFuncvenda.Location = new System.Drawing.Point(449, 181);
            this.lblFuncvenda.Name = "lblFuncvenda";
            this.lblFuncvenda.Size = new System.Drawing.Size(127, 20);
            this.lblFuncvenda.TabIndex = 2;
            this.lblFuncvenda.Text = "Nome do Pacote";
            // 
            // txtFuncvenda
            // 
            this.txtFuncvenda.Enabled = false;
            this.txtFuncvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFuncvenda.Location = new System.Drawing.Point(453, 204);
            this.txtFuncvenda.Name = "txtFuncvenda";
            this.txtFuncvenda.Size = new System.Drawing.Size(205, 26);
            this.txtFuncvenda.TabIndex = 3;
            // 
            // lblCpfclientevenda
            // 
            this.lblCpfclientevenda.AutoSize = true;
            this.lblCpfclientevenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpfclientevenda.Location = new System.Drawing.Point(450, 326);
            this.lblCpfclientevenda.Name = "lblCpfclientevenda";
            this.lblCpfclientevenda.Size = new System.Drawing.Size(112, 20);
            this.lblCpfclientevenda.TabIndex = 4;
            this.lblCpfclientevenda.Text = "CPF do cliente";
            // 
            // mskCPFvendaa
            // 
            this.mskCPFvendaa.Enabled = false;
            this.mskCPFvendaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskCPFvendaa.Location = new System.Drawing.Point(453, 353);
            this.mskCPFvendaa.Mask = "000.000.000-00";
            this.mskCPFvendaa.Name = "mskCPFvendaa";
            this.mskCPFvendaa.Size = new System.Drawing.Size(131, 26);
            this.mskCPFvendaa.TabIndex = 67;
            this.mskCPFvendaa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblPacotevenda
            // 
            this.lblPacotevenda.AutoSize = true;
            this.lblPacotevenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPacotevenda.Location = new System.Drawing.Point(721, 181);
            this.lblPacotevenda.Name = "lblPacotevenda";
            this.lblPacotevenda.Size = new System.Drawing.Size(163, 20);
            this.lblPacotevenda.TabIndex = 68;
            this.lblPacotevenda.Text = "Forma de Pagamento";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito",
            "Boleto",
            "Cheque"});
            this.comboBox1.Location = new System.Drawing.Point(725, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 69;
            // 
            // lblcpfvenda
            // 
            this.lblcpfvenda.AutoSize = true;
            this.lblcpfvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblcpfvenda.Location = new System.Drawing.Point(449, 250);
            this.lblcpfvenda.Name = "lblcpfvenda";
            this.lblcpfvenda.Size = new System.Drawing.Size(130, 20);
            this.lblcpfvenda.TabIndex = 73;
            this.lblcpfvenda.Text = "Nome do Cliente ";
            // 
            // lblfunvvendapacote
            // 
            this.lblfunvvendapacote.AutoSize = true;
            this.lblfunvvendapacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblfunvvendapacote.Location = new System.Drawing.Point(721, 250);
            this.lblfunvvendapacote.Name = "lblfunvvendapacote";
            this.lblfunvvendapacote.Size = new System.Drawing.Size(182, 20);
            this.lblfunvvendapacote.TabIndex = 71;
            this.lblfunvvendapacote.Text = "Exigência de Nota Fiscal";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(453, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 26);
            this.textBox1.TabIndex = 83;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton1.Location = new System.Drawing.Point(725, 278);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 24);
            this.radioButton1.TabIndex = 84;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sim";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton2.Location = new System.Drawing.Point(798, 278);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 24);
            this.radioButton2.TabIndex = 85;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Não";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnvoltarmenunormal
            // 
            this.btnvoltarmenunormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnvoltarmenunormal.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_back_3224191;
            this.btnvoltarmenunormal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltarmenunormal.Location = new System.Drawing.Point(1083, 650);
            this.btnvoltarmenunormal.Name = "btnvoltarmenunormal";
            this.btnvoltarmenunormal.Size = new System.Drawing.Size(246, 38);
            this.btnvoltarmenunormal.TabIndex = 89;
            this.btnvoltarmenunormal.Text = "    Voltar para Menu Principal";
            this.btnvoltarmenunormal.UseVisualStyleBackColor = true;
            this.btnvoltarmenunormal.Click += new System.EventHandler(this.btnvoltarmenunormal_Click);
            // 
            // btnvenda
            // 
            this.btnvenda.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_document_text_add_103511__1_;
            this.btnvenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvenda.Location = new System.Drawing.Point(418, 514);
            this.btnvenda.Name = "btnvenda";
            this.btnvenda.Size = new System.Drawing.Size(96, 45);
            this.btnvenda.TabIndex = 88;
            this.btnvenda.Text = " Novo";
            this.btnvenda.UseVisualStyleBackColor = true;
            this.btnvenda.Click += new System.EventHandler(this.btnvenda_Click);
            // 
            // btnLimparvenda
            // 
            this.btnLimparvenda.Enabled = false;
            this.btnLimparvenda.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_eraser_16086791;
            this.btnLimparvenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparvenda.Location = new System.Drawing.Point(824, 514);
            this.btnLimparvenda.Name = "btnLimparvenda";
            this.btnLimparvenda.Size = new System.Drawing.Size(96, 45);
            this.btnLimparvenda.TabIndex = 87;
            this.btnLimparvenda.Text = "Limpar";
            this.btnLimparvenda.UseVisualStyleBackColor = true;
            this.btnLimparvenda.Click += new System.EventHandler(this.btnLimparvenda_Click);
            // 
            // btncadastravenda
            // 
            this.btncadastravenda.Enabled = false;
            this.btncadastravenda.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_plus_1814113__1_;
            this.btncadastravenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncadastravenda.Location = new System.Drawing.Point(621, 514);
            this.btncadastravenda.Name = "btncadastravenda";
            this.btncadastravenda.Size = new System.Drawing.Size(96, 45);
            this.btncadastravenda.TabIndex = 86;
            this.btncadastravenda.Text = "      Cadastrar";
            this.btncadastravenda.UseVisualStyleBackColor = true;
            this.btncadastravenda.Click += new System.EventHandler(this.btncadastravenda_Click);
            // 
            // lblVendapacote
            // 
            this.lblVendapacote.AutoSize = true;
            this.lblVendapacote.Font = new System.Drawing.Font("Arial Narrow", 24.75F);
            this.lblVendapacote.ForeColor = System.Drawing.Color.Brown;
            this.lblVendapacote.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_941_32_4619651__1_;
            this.lblVendapacote.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVendapacote.Location = new System.Drawing.Point(530, 47);
            this.lblVendapacote.Name = "lblVendapacote";
            this.lblVendapacote.Size = new System.Drawing.Size(266, 40);
            this.lblVendapacote.TabIndex = 1;
            this.lblVendapacote.Text = "Venda de Pacote     ";
            // 
            // lblpreenchavenda
            // 
            this.lblpreenchavenda.AutoSize = true;
            this.lblpreenchavenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblpreenchavenda.ForeColor = System.Drawing.Color.DarkRed;
            this.lblpreenchavenda.Location = new System.Drawing.Point(544, 436);
            this.lblpreenchavenda.Name = "lblpreenchavenda";
            this.lblpreenchavenda.Size = new System.Drawing.Size(270, 18);
            this.lblpreenchavenda.TabIndex = 90;
            this.lblpreenchavenda.Text = "Preencha todos os CAMPOS, por favor";
            this.lblpreenchavenda.Visible = false;
            // 
            // txtTempo
            // 
            this.txtTempo.Enabled = false;
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTempo.Location = new System.Drawing.Point(48, 652);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(124, 30);
            this.txtTempo.TabIndex = 115;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vendaPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblpreenchavenda);
            this.Controls.Add(this.btnvoltarmenunormal);
            this.Controls.Add(this.btnvenda);
            this.Controls.Add(this.btnLimparvenda);
            this.Controls.Add(this.btncadastravenda);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblfunvvendapacote);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblcpfvenda);
            this.Controls.Add(this.lblPacotevenda);
            this.Controls.Add(this.mskCPFvendaa);
            this.Controls.Add(this.lblCpfclientevenda);
            this.Controls.Add(this.txtFuncvenda);
            this.Controls.Add(this.lblFuncvenda);
            this.Controls.Add(this.lblVendapacote);
            this.Name = "vendaPacote";
            this.Text = "SGAT Sistema Gerenciador de Agência de Turismo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendapacote;
        private System.Windows.Forms.Label lblFuncvenda;
        private System.Windows.Forms.TextBox txtFuncvenda;
        private System.Windows.Forms.Label lblCpfclientevenda;
        private System.Windows.Forms.MaskedTextBox mskCPFvendaa;
        private System.Windows.Forms.Label lblPacotevenda;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblcpfvenda;
        private System.Windows.Forms.Label lblfunvvendapacote;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnvenda;
        private System.Windows.Forms.Button btnLimparvenda;
        private System.Windows.Forms.Button btncadastravenda;
        private System.Windows.Forms.Button btnvoltarmenunormal;
        private System.Windows.Forms.Label lblpreenchavenda;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Timer timer1;
    }
}