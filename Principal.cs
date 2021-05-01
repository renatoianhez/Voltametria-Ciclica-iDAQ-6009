using iDAQ;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iDAQ3___Mai2021
{
    public partial class Principal : Form
    {
        iDAQ6009Base idaq = new iDAQ6009Base();
        public List<double> dadoVoltagem = new List<double>();
        public List<double> dadoCorrente = new List<double>();
        private readonly string diretorioInicial = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Principal()
        {
            InitializeComponent();
            lbAviso.Visible = false;

        }

        private void numVi_ValueChanged(object sender, EventArgs e)
        {
            if (numVi.Value >= numVf.Value)
            {
                numVi.Value = numVf.Value - (decimal)0.05;
                MessageBox.Show("O valor da tensão inicial deve ser menor que a final", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numVf_ValueChanged(object sender, EventArgs e)
        {
            if (numVf.Value <= numVi.Value)
            {
                numVf.Value = numVi.Value + (decimal)0.05;
                MessageBox.Show("O valor da tensão final deve ser maior que a inicial", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numIncremento_ValueChanged(object sender, EventArgs e)
        {
            int TxVarredura = (int)((numIncremento.Value / numDelay.Value) * 1000);
            lbTxVarredura.Text = TxVarredura.ToString();
        }

        private void numDelay_ValueChanged(object sender, EventArgs e)
        {
            int TxVarredura = (int)((numIncremento.Value / numDelay.Value) * 1000);
            lbTxVarredura.Text = TxVarredura.ToString();
        }

        private void btLer_Click(object sender, EventArgs e)
        {
            panPainel.Enabled = false;
            btLer.Enabled = false;
            lbAviso.Visible = true;
            Task.Delay(500);
            double incremento = (double)numIncremento.Value / 1000;
            int numCiclosPorExperimento = (int)numCiclos.Value;
            double vInicial = 2.50 + (1.06383 * (double)numVi.Value);
            double vFinal = 2.50 + (1.06383 * (double)numVf.Value);
            int delay = (int)numDelay.Value;
            dadoVoltagem.Clear();
            dadoCorrente.Clear();
            idaq.OpeniDAQDevice(0);

            for (int ciclo = 0; ciclo < numCiclosPorExperimento; ciclo++)
            {

                for (double voltagem = vInicial; voltagem <= vFinal; voltagem += incremento)
                {
                    idaq.SetDAQDeviceAO(0, voltagem);
                    Task.Delay(delay);
                    dadoVoltagem.Add(idaq.ReadDAQDeviceAISingle(0));
                    dadoCorrente.Add(idaq.ReadDAQDeviceAISingle(1));
                }
                for (double voltagem = vFinal; voltagem >= vInicial; voltagem -= incremento)
                {
                    idaq.SetDAQDeviceAO(0, voltagem);
                    Task.Delay(delay);
                    dadoVoltagem.Add(idaq.ReadDAQDeviceAISingle(0));
                    dadoCorrente.Add(idaq.ReadDAQDeviceAISingle(1));
                }
            }
            idaq.CloseiDAQDevice();
            var decisao = MessageBox.Show("Deseja salvar os dados?",
                "Leitura terminada!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (decisao == DialogResult.Yes)
            {
                SaveFileDialog cxSalvar1 = new SaveFileDialog();
                cxSalvar1.InitialDirectory = diretorioInicial;
                cxSalvar1.FileName = "VoltCiclica_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");
                cxSalvar1.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
                DialogResult resultado = cxSalvar1.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    TextWriter tw = new StreamWriter(cxSalvar1.FileName);
                    for (int i = 0; i < dadoVoltagem.Count; i++)
                    {
                        tw.WriteLine(dadoVoltagem[i] + "\t" + dadoCorrente[i]);
                    }
                    tw.Close();
                }             
                  
            }
            panPainel.Enabled = true;
            btLer.Enabled = true;
            lbAviso.Visible = false;
        }
    }
}
