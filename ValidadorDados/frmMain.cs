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
using System.Runtime.InteropServices;
using System.IO;

namespace ValidadorDados
{
    public partial class frmMain : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
        private AX_Migracao_StagingDataContext stgContext = new AX_Migracao_StagingDataContext();
        private DynamicsAX2012R2DataContext axdb = new DynamicsAX2012R2DataContext();
        
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

        private void cmdCPFCNPJCliente_Click(object sender, EventArgs e)
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

            var ClientesCNPJAjustar = from c in stgContext.stg_Clientes
                           where c.CNPJCPFNum_BR != null && c.CNPJCPFNum_BR.Trim().Length == 11
                           select c;

            foreach (var item in ClientesCNPJAjustar)
            {
                logger.Info("Cliente,CPF," + item.RegistroIDMig.ToString() + "," + item.CNPJCPFNum_BR.ToString() + "," + Validacoes.ValidaCPF(item.CNPJCPFNum_BR).ToString());  
            }

            // Atualiza a base de dados para as situações em que o CPF está com 9 e 10 posições.
            // Na importação ele perdeu os zeros à esquerda e será adicionado.

            var clientesPJ = from c in stgContext.stg_Clientes
                             where c.CNPJCPFNum_BR != null && (c.CNPJCPFNum_BR.Trim().Length == 12 || c.CNPJCPFNum_BR.Trim().Length == 13)
                             select c;

            // Atualização da base de dados para tratar clientes com CNPJ com 12 e 13 posições e incluir zeros à esquerda
            foreach (stg_Cliente item in clientesPJ)
            {
                item.CNPJCPFNum_BR = Convert.ToInt64(item.CNPJCPFNum_BR).ToString("00000000000000");
            }
            stgContext.SubmitChanges();

            var ClientesPJ2 = from c in stgContext.stg_Clientes
                           where c.CNPJCPFNum_BR != null && c.CNPJCPFNum_BR.Trim().Length == 14
                           select c;

            foreach (var item in ClientesPJ2)
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

        private void cmdCNPJCliente_Click(object sender, EventArgs e)
        {

            
            
            MessageBox.Show("Validação Concluída");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void cmdCEPCliente_Click(object sender, EventArgs e)
        {
            AX_Migracao_StagingDataContext staging = new AX_Migracao_StagingDataContext();
            //DynamicsAX2012R2DataContext axdb = new DynamicsAX2012R2DataContext();

            foreach (var item in staging.stg_Clientes)
            {
                var CEPsAX = from c in axdb.LOGISTICSADDRESSZIPCODEs
                             where c.ZIPCODE == item.ZipCode
                             select c;

                if (CEPsAX.Count().Equals(0))
                {
                    if (item.ZipCode == null)
                    {
                        logger.Info("Cliente,CEP," + item.RegistroIDMig.ToString() + ",Nulo," + false.ToString());  

                    }
                    else
                    {
                        logger.Info("Cliente,CEP," + item.RegistroIDMig.ToString() + "," + item.ZipCode.ToString() + "," + false.ToString());  

                    }
                                    }
            }
        }

        private void cmdCPFCNPJ_Fornecedor_Click(object sender, EventArgs e)
        {

            // Atualiza a base de dados para as situações em que o CPF está com 9 e 10 posições.
            // Na importação ele perdeu os zeros à esquerda e será adicionado.

            var Fornecedores = from c in stgContext.stg_Fornecedores
                              where c.CNPJCPFNum_BR != null && (c.CNPJCPFNum_BR.Trim().Length == 9 || c.CNPJCPFNum_BR.Trim().Length == 10)
                              select c;

           foreach (stg_Fornecedore item in Fornecedores)
           {
               item.CNPJCPFNum_BR = Convert.ToInt64(item.CNPJCPFNum_BR).ToString("00000000000");
           }
           stgContext.SubmitChanges();

           var fornecedores = from c in stgContext.stg_Fornecedores
                                     where c.CNPJCPFNum_BR != null && c.CNPJCPFNum_BR.Trim().Length == 11
                                     select c;

           foreach (var item in fornecedores)
           {
               logger.Info("Fornecedor,CPF," + item.RegistroIDMig.ToString() + "," + item.CNPJCPFNum_BR.ToString() + "," + Validacoes.ValidaCPF(item.CNPJCPFNum_BR).ToString());
           }

           var fornecedorPJ = from c in stgContext.stg_Fornecedores
                            where c.CNPJCPFNum_BR != null && (c.CNPJCPFNum_BR.Trim().Length == 12 || c.CNPJCPFNum_BR.Trim().Length == 13)
                            select c;

           // Atualização da base de dados para tratar clientes com CNPJ com 12 e 13 posições e incluir zeros à esquerda
           foreach (stg_Fornecedore item in fornecedorPJ)
           {
               item.CNPJCPFNum_BR = Convert.ToInt64(item.CNPJCPFNum_BR).ToString("00000000000000");
           }
           stgContext.SubmitChanges();

           var fornecedorPJ2 = from c in stgContext.stg_Fornecedores
                             where c.CNPJCPFNum_BR != null && c.CNPJCPFNum_BR.Trim().Length == 14
                             select c;

           foreach (var item in fornecedorPJ2)
           {
               logger.Info("Fornecedor,CNPJ," + item.RegistroIDMig.ToString() + "," + item.CNPJCPFNum_BR.ToString() + "," + Validacoes.ValidaCNPJ(item.CNPJCPFNum_BR).ToString());
           }

           var fornecedoresNulos = from c in stgContext.stg_Fornecedores
                           where c.CNPJCPFNum_BR == null || c.CNPJCPFNum_BR.Trim() == ""
                           select c;

           foreach (var item in fornecedoresNulos)
           {
               logger.Info("Fornecedor,Nulo," + item.RegistroIDMig.ToString() + ",,");
           }

           foreach (var item in stgContext.stg_Fornecedores)
           {
               var CEPsAX = from c in axdb.LOGISTICSADDRESSZIPCODEs
                            where c.ZIPCODE == item.ZipCode
                            select c;

               if (CEPsAX.Count().Equals(0))
               {
                   if (item.ZipCode == null)
                   {
                       logger.Info("Fornecedor,CEP," + item.RegistroIDMig.ToString() + ",Nulo," + false.ToString());

                   }
                   else
                   {
                       logger.Info("Fornecedor,CEP," + item.RegistroIDMig.ToString() + "," + item.ZipCode.ToString() + "," + false.ToString());

                   }
               }
           }

           MessageBox.Show("Validação Concluída");

        }
    }
}
