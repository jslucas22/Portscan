using Portscan.Enum;
using Portscan.Properties;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portscan.Services
{
    public class Service
    {
        #region ..:: Propriedades ::..

        public static string Ip { get; set; }
        private static IPAddress EnderecoIp { get { return Dns.GetHostEntry(Ip).AddressList[0]; } }

        #endregion

        #region ..:: Variáveis ::..

        private static List<int> _portas;
        protected static string _regexIp = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";

        #endregion

        #region ..:: Métodos ::..,

        public static bool PodeEscanear(string ip, int porta_inicial, int porta_final)
        {
            var regex = new Regex(_regexIp);

            if (!regex.Match(ip).Success)
            {
                MessageBox.Show("Endereço IP inválido! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (porta_inicial > porta_final)
            {
                MessageBox.Show("Porta inicial não pode ser maior do que a porta final! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Cria o range para as portas
        /// </summary>
        /// <param name="porta_inicial">a primeira porta informada</param>
        /// <param name="porta_final">a ultima porta informada</param>
        /// <returns></returns>
        public static List<int> Portas(int porta_inicial, int porta_final)
        {
            _portas = new List<int>();

            for (int i = porta_inicial; i <= porta_final; i++)
                _portas.Add(i);

            return _portas;
        }

        /// <summary>
        /// Retorna o estado das portas
        /// </summary>
        /// <param name="dataGridView">o componente visual</param>
        public static async Task EscanearPortas(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0) dataGridView.Rows.Clear();
            foreach (var porta in _portas)
            {
                dataGridView.Rows.Add();
                int row = dataGridView.Rows.Count - 1;

                await Task.Run(() =>
                {
                    try
                    {
                        var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socket.Connect(Ip, porta);

                        if (socket.Connected)
                        {
                            dataGridView.Rows[row].Cells[(int)GridEnum.Porta].Value = porta;
                            dataGridView.Rows[row].Cells[(int)GridEnum.Status].Value = Resources.green_circle_16px;
                        }
                    }
                    catch
                    {
                        dataGridView.Rows[row].Cells[(int)GridEnum.Porta].Value = porta;
                        dataGridView.Rows[row].Cells[(int)GridEnum.Status].Value = Resources.red_circle_16px;
                    }
                });
            }
            dataGridView.ClearSelection();
        }

        /// <summary>
        /// Retorna o estado das portas ativas
        /// </summary>
        /// <param name="dataGridView">o componente visual</param>
        public static void EscanearPortasAtivas(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0) dataGridView.Rows.Clear();
            foreach (var porta in _portas)
            {
                try
                {
                    var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(Ip, porta);

                    if (socket.Connected)
                    {
                        dataGridView.Rows.Add();
                        int row = dataGridView.Rows.Count - 1;

                        dataGridView.Rows[row].Cells[(int)GridEnum.Porta].Value = porta;
                        dataGridView.Rows[row].Cells[(int)GridEnum.Status].Value = Resources.green_circle_16px;
                    }
                }
                catch {/*;;;*/ }
            }
            dataGridView.ClearSelection();
        }

        /// <summary>
        /// Retorna o estado das portas inativas
        /// </summary>
        /// <param name="dataGridView">o componente visual</param>
        public static void EscanearPortasInativas(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0) dataGridView.Rows.Clear();
            foreach (var porta in _portas)
            {
                try
                {
                    var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(Ip, porta);
                }
                catch
                {
                    dataGridView.Rows.Add();
                    int row = dataGridView.Rows.Count - 1;

                    dataGridView.Rows[row].Cells[(int)GridEnum.Porta].Value = porta;
                    dataGridView.Rows[row].Cells[(int)GridEnum.Status].Value = Resources.red_circle_16px;
                }
            }
            dataGridView.ClearSelection();
        }
        #endregion
    }
}


