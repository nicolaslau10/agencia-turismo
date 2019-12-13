namespace ProjetoTurismooo
{
    partial class cadastroUsuario
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
            this.lblSenhausuario = new System.Windows.Forms.Label();
            this.lblCpfusuario = new System.Windows.Forms.Label();
            this.lblEmailusuario = new System.Windows.Forms.Label();
            this.lblNomeusuario = new System.Windows.Forms.Label();
            this.txtSenhausuario = new System.Windows.Forms.TextBox();
            this.txtNomeusuario = new System.Windows.Forms.TextBox();
            this.txtEmailusuario = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.mskCpfFunc = new System.Windows.Forms.MaskedTextBox();
            this.btnNovofunc = new System.Windows.Forms.Button();
            this.btnLimparfunc = new System.Windows.Forms.Button();
            this.btnCadastrarfunc = new System.Windows.Forms.Button();
            this.btnVoltarmenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvoltarmenunormal = new System.Windows.Forms.Button();
            this.lblpreenchafunc = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSenhausuario
            // 
            this.lblSenhausuario.AutoSize = true;
            this.lblSenhausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSenhausuario.Location = new System.Drawing.Point(395, 332);
            this.lblSenhausuario.Name = "lblSenhausuario";
            this.lblSenhausuario.Size = new System.Drawing.Size(56, 20);
            this.lblSenhausuario.TabIndex = 2;
            this.lblSenhausuario.Text = "Senha";
            // 
            // lblCpfusuario
            // 
            this.lblCpfusuario.AutoSize = true;
            this.lblCpfusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpfusuario.Location = new System.Drawing.Point(858, 192);
            this.lblCpfusuario.Name = "lblCpfusuario";
            this.lblCpfusuario.Size = new System.Drawing.Size(40, 20);
            this.lblCpfusuario.TabIndex = 5;
            this.lblCpfusuario.Text = "CPF";
            // 
            // lblEmailusuario
            // 
            this.lblEmailusuario.AutoSize = true;
            this.lblEmailusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmailusuario.Location = new System.Drawing.Point(395, 262);
            this.lblEmailusuario.Name = "lblEmailusuario";
            this.lblEmailusuario.Size = new System.Drawing.Size(53, 20);
            this.lblEmailusuario.TabIndex = 10;
            this.lblEmailusuario.Text = "E-mail";
            // 
            // lblNomeusuario
            // 
            this.lblNomeusuario.AutoSize = true;
            this.lblNomeusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeusuario.Location = new System.Drawing.Point(395, 188);
            this.lblNomeusuario.Name = "lblNomeusuario";
            this.lblNomeusuario.Size = new System.Drawing.Size(51, 20);
            this.lblNomeusuario.TabIndex = 11;
            this.lblNomeusuario.Text = "Nome";
            // 
            // txtSenhausuario
            // 
            this.txtSenhausuario.Enabled = false;
            this.txtSenhausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSenhausuario.Location = new System.Drawing.Point(399, 355);
            this.txtSenhausuario.MaxLength = 200;
            this.txtSenhausuario.Name = "txtSenhausuario";
            this.txtSenhausuario.Size = new System.Drawing.Size(185, 26);
            this.txtSenhausuario.TabIndex = 20;
            // 
            // txtNomeusuario
            // 
            this.txtNomeusuario.Enabled = false;
            this.txtNomeusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeusuario.Location = new System.Drawing.Point(399, 215);
            this.txtNomeusuario.MaxLength = 75;
            this.txtNomeusuario.Name = "txtNomeusuario";
            this.txtNomeusuario.Size = new System.Drawing.Size(419, 26);
            this.txtNomeusuario.TabIndex = 23;
            // 
            // txtEmailusuario
            // 
            this.txtEmailusuario.Enabled = false;
            this.txtEmailusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmailusuario.Location = new System.Drawing.Point(399, 285);
            this.txtEmailusuario.MaxLength = 200;
            this.txtEmailusuario.Name = "txtEmailusuario";
            this.txtEmailusuario.Size = new System.Drawing.Size(466, 26);
            this.txtEmailusuario.TabIndex = 40;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(706, 199);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(113, 13);
            this.lblMax.TabIndex = 60;
            this.lblMax.Text = "máximo: 75 caracteres";
            // 
            // mskCpfFunc
            // 
            this.mskCpfFunc.Enabled = false;
            this.mskCpfFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskCpfFunc.Location = new System.Drawing.Point(862, 215);
            this.mskCpfFunc.Mask = "000.000.000-00";
            this.mskCpfFunc.Name = "mskCpfFunc";
            this.mskCpfFunc.Size = new System.Drawing.Size(131, 26);
            this.mskCpfFunc.TabIndex = 76;
            this.mskCpfFunc.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnNovofunc
            // 
            this.btnNovofunc.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_document_text_add_103511__1_;
            this.btnNovofunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovofunc.Location = new System.Drawing.Point(445, 522);
            this.btnNovofunc.Name = "btnNovofunc";
            this.btnNovofunc.Size = new System.Drawing.Size(96, 45);
            this.btnNovofunc.TabIndex = 75;
            this.btnNovofunc.Text = " Novo";
            this.btnNovofunc.UseVisualStyleBackColor = true;
            this.btnNovofunc.Click += new System.EventHandler(this.btnNovofunc_Click);
            // 
            // btnLimparfunc
            // 
            this.btnLimparfunc.Enabled = false;
            this.btnLimparfunc.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_eraser_16086791;
            this.btnLimparfunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparfunc.Location = new System.Drawing.Point(847, 522);
            this.btnLimparfunc.Name = "btnLimparfunc";
            this.btnLimparfunc.Size = new System.Drawing.Size(96, 45);
            this.btnLimparfunc.TabIndex = 74;
            this.btnLimparfunc.Text = "Limpar";
            this.btnLimparfunc.UseVisualStyleBackColor = true;
            this.btnLimparfunc.Click += new System.EventHandler(this.btnLimparfunc_Click);
            // 
            // btnCadastrarfunc
            // 
            this.btnCadastrarfunc.Enabled = false;
            this.btnCadastrarfunc.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_plus_1814113__1_;
            this.btnCadastrarfunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarfunc.Location = new System.Drawing.Point(648, 522);
            this.btnCadastrarfunc.Name = "btnCadastrarfunc";
            this.btnCadastrarfunc.Size = new System.Drawing.Size(96, 45);
            this.btnCadastrarfunc.TabIndex = 73;
            this.btnCadastrarfunc.Text = "      Cadastrar";
            this.btnCadastrarfunc.UseVisualStyleBackColor = true;
            this.btnCadastrarfunc.Click += new System.EventHandler(this.btnCadastrarfunc_Click);
            // 
            // btnVoltarmenu
            // 
            this.btnVoltarmenu.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_back_322419;
            this.btnVoltarmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarmenu.Location = new System.Drawing.Point(1360, 768);
            this.btnVoltarmenu.Name = "btnVoltarmenu";
            this.btnVoltarmenu.Size = new System.Drawing.Size(184, 34);
            this.btnVoltarmenu.TabIndex = 69;
            this.btnVoltarmenu.Text = "        Voltar para menu principal";
            this.btnVoltarmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarmenu.UseVisualStyleBackColor = true;
            this.btnVoltarmenu.Click += new System.EventHandler(this.btnVoltarmenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_user_red_add_60136;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(500, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionário     ";
            // 
            // btnvoltarmenunormal
            // 
            this.btnvoltarmenunormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnvoltarmenunormal.Image = global::ProjetoTurismooo.Properties.Resources.iconfinder_back_3224191;
            this.btnvoltarmenunormal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltarmenunormal.Location = new System.Drawing.Point(1089, 649);
            this.btnvoltarmenunormal.Name = "btnvoltarmenunormal";
            this.btnvoltarmenunormal.Size = new System.Drawing.Size(246, 38);
            this.btnvoltarmenunormal.TabIndex = 77;
            this.btnvoltarmenunormal.Text = "    Voltar para Menu Principal";
            this.btnvoltarmenunormal.UseVisualStyleBackColor = true;
            this.btnvoltarmenunormal.Click += new System.EventHandler(this.btnvoltarmenunormal_Click);
            // 
            // lblpreenchafunc
            // 
            this.lblpreenchafunc.AutoSize = true;
            this.lblpreenchafunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblpreenchafunc.ForeColor = System.Drawing.Color.DarkRed;
            this.lblpreenchafunc.Location = new System.Drawing.Point(537, 453);
            this.lblpreenchafunc.Name = "lblpreenchafunc";
            this.lblpreenchafunc.Size = new System.Drawing.Size(270, 18);
            this.lblpreenchafunc.TabIndex = 78;
            this.lblpreenchafunc.Text = "Preencha todos os CAMPOS, por favor";
            this.lblpreenchafunc.Visible = false;
            // 
            // txtTempo
            // 
            this.txtTempo.Enabled = false;
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTempo.Location = new System.Drawing.Point(54, 637);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(124, 30);
            this.txtTempo.TabIndex = 79;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblpreenchafunc);
            this.Controls.Add(this.btnvoltarmenunormal);
            this.Controls.Add(this.mskCpfFunc);
            this.Controls.Add(this.btnNovofunc);
            this.Controls.Add(this.btnLimparfunc);
            this.Controls.Add(this.btnCadastrarfunc);
            this.Controls.Add(this.btnVoltarmenu);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.txtEmailusuario);
            this.Controls.Add(this.txtNomeusuario);
            this.Controls.Add(this.txtSenhausuario);
            this.Controls.Add(this.lblNomeusuario);
            this.Controls.Add(this.lblEmailusuario);
            this.Controls.Add(this.lblCpfusuario);
            this.Controls.Add(this.lblSenhausuario);
            this.Controls.Add(this.label1);
            this.Name = "cadastroUsuario";
            this.Text = "SGAT Sistema Gerenciador de Agência de Turismo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSenhausuario;
        private System.Windows.Forms.Label lblCpfusuario;
        private System.Windows.Forms.Label lblEmailusuario;
        private System.Windows.Forms.Label lblNomeusuario;
        private System.Windows.Forms.TextBox txtSenhausuario;
        private System.Windows.Forms.TextBox txtNomeusuario;
        private System.Windows.Forms.TextBox txtEmailusuario;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnVoltarmenu;
        private System.Windows.Forms.Button btnNovofunc;
        private System.Windows.Forms.Button btnLimparfunc;
        private System.Windows.Forms.Button btnCadastrarfunc;
        private System.Windows.Forms.MaskedTextBox mskCpfFunc;
        private System.Windows.Forms.Button btnvoltarmenunormal;
        private System.Windows.Forms.Label lblpreenchafunc;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Timer timer1;
    }
}