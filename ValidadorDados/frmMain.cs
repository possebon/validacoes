using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using System.Reflection;

namespace ValidadorDados
{
    public partial class frmMain : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        
        public frmMain()
        {
            Log.Debug("Application is starting....");
            InitializeComponent();
        }

        private void cmdValida_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Resultado validações: " + Validacoes.ValidaCPF(txtValor.Text).ToString());
            var controle = this.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            getValidacao(controle);

        }

        private void getValidacao(RadioButton radioButton)
        {
            bool retorno = false;
            
            if (radioButton.Checked)
            {
                switch (radioButton.Text)
                {
                    case "CPF":
                        retorno = Validacoes.ValidaCPF(txtValor.Text);
                        break;
                    case "CNPJ":
                        retorno = Validacoes.ValidaCNPJ(txtValor.Text);
                        break;
                    case "Inscrição Estadual":
                        retorno = Validacoes.ValidaInscricaoEstadual(txtValor2.Text, txtValor.Text);
                        break;
                    case "CEP":
                        retorno = Validacoes.ValidaCep(txtValor.Text);
                        break;
                    case "E-mail":
                        retorno = Validacoes.ValidaEmail(txtValor.Text);
                        break;
                    default:
                        break;
                }

                MessageBox.Show("Retorno da Validação: " + retorno.ToString());
            }
            
        }
    }
}
