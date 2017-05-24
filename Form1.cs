using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TCPKlient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_polacz_Click(object sender, EventArgs e)
        {

            string host = Adres.Text;
            int port = System.Convert.ToInt32(my_port.Value);

            try
            {
               TcpClient klient = new TcpClient(host, port);
                info_o_polaczeniu.Items.Add("Nawiazano polaczenie z " + host + "na danym porcie " + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                info_o_polaczeniu.Items.Add("blad: " + "Nie udalo sie nawiazac polaczena!");
                MessageBox.Show(ex.ToString(), "Blad");
            }
        }
    }
}
