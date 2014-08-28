using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
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
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
        private AX_Migracao_StagingDataContext stgContext = new AX_Migracao_StagingDataContext();
        
        public frmMain()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));

            if (!LogManager.GetRepository().Configured)
                throw new Exception("log4net should have been configured.");
            
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

        private void cmdCPFCliente_Click(object sender, EventArgs e)
        {
            
            // Atualiza a base de dados para as situações em que o CPF está com 9 e 10 posições.
            // Na importação ele perdeu os zeros à esquerda e será adicionado.

            var clientesPF = from c in stgContext.stg_Clientes
                             where c.CNPJCPFNum_BR != null && (c.CNPJCPFNum_BR.Trim().Length == 9 || c.CNPJCPFNum_BR.Trim().Length == 10)
                             select c;

             foreach (stg_Cliente item in clientesPF)
	        {
	            item.CNPJCPFNum_BR = Convert.ToInt64(item.CNPJCPFNum_BR).ToString("00000000000");
	        }
            stgContext.SubmitChanges();

            var Clientes = from c in stgContext.stg_Clientes
                           where c.CNPJCPFNum_BR != null && c.CNPJCPFNum_BR.Trim().Length == 11
                           select c;

                     

            foreach (var item in Clientes)
            {
                logger.Info("Cliente,CPF," + item.RegistroIDMig.ToString() + "," + item.CNPJCPFNum_BR.ToString() + "," + Validacoes.ValidaCPF(item.CNPJCPFNum_BR).ToString());  
            }

            MessageBox.Show("Validação Concluída");
        }

        private void cmdCNPJCliente_Click(object sender, EventArgs e)
        {

            // Atualiza a base de dados para as situações em que o CPF está com 9 e 10 posições.
            // Na importação ele perdeu os zeros à esquerda e será adicionado.

            var clientesPJ = from c in stgContext.stg_Clientes
                             where c.CNPJCPFNum_BR != null && (c.CNPJCPFNum_BR.Trim().Length == 12 || c.CNPJCPFNum_BR.Trim().Length == 13)
                             select c;

            foreach (stg_Cliente item in clientesPJ)
            {
                item.CNPJCPFNum_BR = Convert.ToInt64(item.CNPJCPFNum_BR).ToString("00000000000000");
            }
            stgContext.SubmitChanges();
               
            var Clientes = from c in stgContext.stg_Clientes
                           where c.CNPJCPFNum_BR != null && c.CNPJCPFNum_BR.Trim().Length == 14
                           select c;

            foreach (var item in Clientes)
            {
                logger.Info("Cliente,CNPJ," + item.RegistroIDMig.ToString() + "," + item.CNPJCPFNum_BR.ToString() + "," + Validacoes.ValidaCNPJ(item.CNPJCPFNum_BR).ToString());
            }

            var Clientes2 = from c in stgContext.stg_Clientes
                           where c.CNPJCPFNum_BR == null || c.CNPJCPFNum_BR.Trim() == ""
                           select c;

            foreach (var item in Clientes2)
            {
                logger.Info("Cliente,Nulo," + item.RegistroIDMig.ToString() + ",,");
            }
            
            MessageBox.Show("Validação Concluída");
        }
    }
}
