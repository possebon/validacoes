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
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(13, 28);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(162, 20);
            this.txtValor.TabIndex = 0;
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
            this.txtValor2.Text = "BA";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.radEmail);
            this.Controls.Add(this.radCEP);
            this.Controls.Add(this.radIE);
            this.Controls.Add(this.radCNPJ);
            this.Controls.Add(this.radCPF);
            this.Controls.Add(this.cmdValida);
            this.Controls.Add(this.txtValor);
            this.Name = "frmMain";
            this.Text = "Validador de Dados";
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
    }
}

