using Portscan.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portscan
{
    public partial class Main : Form
    {
        #region ..:: Construtor ::..

        public Main()
        {
            InitializeComponent();
        }

        #endregion

        #region ..:: Métodos Auxiliares ::..

        /// <summary>
        /// Verifica se os campos de portas 
        /// nao estao vazios
        /// </summary>
        /// <returns></returns>
        public bool InformouPortas() => !string.IsNullOrEmpty(txtPortaInicial.Text) && !string.IsNullOrEmpty(txtPortaFinal.Text);
        /// <summary>
        /// Atribui o valor do endereco ip para a propriedade Ip 
        /// da camada de serviços
        /// </summary>
        private void AtribuirValorIp() => Service.Ip = txtIp.Text;
        /// <summary>
        /// Atribui o valor da porta inicial e final 
        /// </summary>
        private void AtribuirPortas() => Service.Portas(porta_inicial: Convert.ToInt32(txtPortaInicial.Text),
                                                        porta_final: Convert.ToInt32(txtPortaFinal.Text));
        /// <summary>
        /// Faz o escaneamento das portas
        /// </summary>
        /// <returns></returns>
        private async Task Escanear()
        {
            if(rbAtivas.Checked) Service.EscanearPortasAtivas(dataGridView: dgvPortas); //# Tem que ser feito de forma assincrona
            if (rbInativas.Checked) Service.EscanearPortasInativas(dataGridView: dgvPortas); //# Tem que ser feito de forma assincrona
            if (rbTodas.Checked) await Service.EscanearPortas(dataGridView: dgvPortas);
        }
        /// <summary>
        /// Executa os procedimentos iniciais
        /// </summary>        
        private async void ExecutarTratamentos()
        {
            if (InformouPortas())
            {
                if (Service.PodeEscanear(ip: txtIp.Text,
                                         porta_inicial: Convert.ToInt32(txtPortaInicial.Text),
                                         porta_final: Convert.ToInt32(txtPortaFinal.Text)))
                {
                    #region -- Alterando estado do cursor
                    Cursor = Cursors.WaitCursor;
                    #endregion

                    AtribuirValorIp();

                    AtribuirPortas();

                    await Escanear();

                    #region -- Alterando estado do cursor
                    Cursor = Cursors.Default;
                    #endregion
                }
            }
        }

        #endregion

        #region ..:: Eventos ::..

        private void btnPesquisar_Click(object sender, EventArgs e) => ExecutarTratamentos();

        #endregion
    }
}
