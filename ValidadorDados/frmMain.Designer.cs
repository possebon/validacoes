namespace ValidadorDados
{
    partial class frmMain
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmdValida = new System.Windows.Forms.Button();
            this.radCPF = new System.Windows.Forms.RadioButton();
            this.radCNPJ = new System.Windows.Forms.RadioButton();
            this.radIE = new System.Windows.Forms.RadioButton();
            this.radCEP = new System.Windows.Forms.RadioButton();
            this.radEmail = new System.Windows.Forms.RadioButton();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdCEPCliente = new System.Windows.Forms.Button();
            this.cmdIEClientes = new System.Windows.Forms.Button();
            this.cmdCPFCNPJCliente = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdCPFCNPJ_Fornecedor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(13, 28);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(162, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "062.307.904/0081";
            // 
            // cmdValida
            // 
            this.cmdValida.Location = new System.Drawing.Point(299, 25);
            this.cmdValida.Name = "cmdValida";
            this.cmdValida.Size = new System.Drawing.Size(75, 23);
            this.cmdValida.TabIndex = 1;
            this.cmdValida.Text = "Validar";
            this.cmdValida.UseVisualStyleBackColor = true;
            this.cmdValida.Click += new System.EventHandler(this.cmdValida_Click);
            // 
            // radCPF
            // 
            this.radCPF.AutoSize = true;
            this.radCPF.Location = new System.Drawing.Point(13, 72);
            this.radCPF.Name = "radCPF";
            this.radCPF.Size = new System.Drawing.Size(45, 17);
            this.radCPF.TabIndex = 2;
            this.radCPF.TabStop = true;
            this.radCPF.Text = "CPF";
            this.radCPF.UseVisualStyleBackColor = true;
            // 
            // radCNPJ
            // 
            this.radCNPJ.AutoSize = true;
            this.radCNPJ.Location = new System.Drawing.Point(74, 72);
            this.radCNPJ.Name = "radCNPJ";
            this.radCNPJ.Size = new System.Drawing.Size(52, 17);
            this.radCNPJ.TabIndex = 3;
            this.radCNPJ.TabStop = true;
            this.radCNPJ.Text = "CNPJ";
            this.radCNPJ.UseVisualStyleBackColor = true;
            // 
            // radIE
            // 
            this.radIE.AutoSize = true;
            this.radIE.Checked = true;
            this.radIE.Location = new System.Drawing.Point(151, 72);
            this.radIE.Name = "radIE";
            this.radIE.Size = new System.Drawing.Size(112, 17);
            this.radIE.TabIndex = 4;
            this.radIE.TabStop = true;
            this.radIE.Text = "Inscrição Estadual";
            this.radIE.UseVisualStyleBackColor = true;
            // 
            // radCEP
            // 
            this.radCEP.AutoSize = true;
            this.radCEP.Location = new System.Drawing.Point(269, 72);
            this.radCEP.Name = "radCEP";
            this.radCEP.Size = new System.Drawing.Size(46, 17);
            this.radCEP.TabIndex = 5;
            this.radCEP.TabStop = true;
            this.radCEP.Text = "CEP";
            this.radCEP.UseVisualStyleBackColor = true;
            // 
            // radEmail
            // 
            this.radEmail.AutoSize = true;
            this.radEmail.Location = new System.Drawing.Point(321, 72);
            this.radEmail.Name = "radEmail";
            this.radEmail.Size = new System.Drawing.Size(53, 17);
            this.radEmail.TabIndex = 6;
            this.radEmail.TabStop = true;
            this.radEmail.Text = "E-mail";
            this.radEmail.UseVisualStyleBackColor = true;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(202, 28);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(61, 20);
            this.txtValor2.TabIndex = 7;
            this.txtValor2.Text = "MG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(13, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 194);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de Staging";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 169);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdCEPCliente);
            this.tabPage1.Controls.Add(this.cmdIEClientes);
            this.tabPage1.Controls.Add(this.cmdCPFCNPJCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 143);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdCEPCliente
            // 
            this.cmdCEPCliente.Location = new System.Drawing.Point(100, 6);
            this.cmdCEPCliente.Name = "cmdCEPCliente";
            this.cmdCEPCliente.Size = new System.Drawing.Size(75, 56);
            this.cmdCEPCliente.TabIndex = 19;
            this.cmdCEPCliente.Text = "Validar CEP Clientes";
            this.cmdCEPCliente.UseVisualStyleBackColor = true;
            this.cmdCEPCliente.Click += new System.EventHandler(this.cmdCEPCliente_Click);
            // 
            // cmdIEClientes
            // 
            this.cmdIEClientes.Location = new System.Drawing.Point(195, 6);
            this.cmdIEClientes.Name = "cmdIEClientes";
            this.cmdIEClientes.Size = new System.Drawing.Size(75, 56);
            this.cmdIEClientes.TabIndex = 18;
            this.cmdIEClientes.Text = "Validar I.E. Clientes";
            this.cmdIEClientes.UseVisualStyleBackColor = true;
            // 
            // cmdCPFCNPJCliente
            // 
            this.cmdCPFCNPJCliente.Location = new System.Drawing.Point(6, 6);
            this.cmdCPFCNPJCliente.Name = "cmdCPFCNPJCliente";
            this.cmdCPFCNPJCliente.Size = new System.Drawing.Size(81, 56);
            this.cmdCPFCNPJCliente.TabIndex = 16;
            this.cmdCPFCNPJCliente.Text = "Validar CPF e CNPJ Clientes";
            this.cmdCPFCNPJCliente.UseVisualStyleBackColor = true;
            this.cmdCPFCNPJCliente.Click += new System.EventHandler(this.cmdCPFCNPJCliente_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdCPFCNPJ_Fornecedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 143);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fornecedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdCPFCNPJ_Fornecedor
            // 
            this.cmdCPFCNPJ_Fornecedor.Location = new System.Drawing.Point(18, 15);
            this.cmdCPFCNPJ_Fornecedor.Name = "cmdCPFCNPJ_Fornecedor";
            this.cmdCPFCNPJ_Fornecedor.Size = new System.Drawing.Size(84, 70);
            this.cmdCPFCNPJ_Fornecedor.TabIndex = 0;
            this.cmdCPFCNPJ_Fornecedor.Text = "Validar CPF e CNPJ";
            this.cmdCPFCNPJ_Fornecedor.UseVisualStyleBackColor = true;
            this.cmdCPFCNPJ_Fornecedor.Click += new System.EventHandler(this.cmdCPFCNPJ_Fornecedor_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 319);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.radEmail);
            this.Controls.Add(this.radCEP);
            this.Controls.Add(this.radIE);
            this.Controls.Add(this.radCNPJ);
            this.Controls.Add(this.radCPF);
            this.Controls.Add(this.cmdValida);
            this.Controls.Add(this.txtValor);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validador de Dados";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button cmdValida;
        private System.Windows.Forms.RadioButton radCPF;
        private System.Windows.Forms.RadioButton radCNPJ;
        private System.Windows.Forms.RadioButton radIE;
        private System.Windows.Forms.RadioButton radCEP;
        private System.Windows.Forms.RadioButton radEmail;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cmdCEPCliente;
        private System.Windows.Forms.Button cmdIEClientes;
        private System.Windows.Forms.Button cmdCPFCNPJCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdCPFCNPJ_Fornecedor;
    }
}

