using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace kantarSerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            seriPort.DataBits = 8;
            seriPort.Handshake = Handshake.None;
            seriPort.Parity = Parity.None;
            seriPort.StopBits = StopBits.One;

            if (!seriPort.IsOpen) { seriPort.Open(); }
        }

        SerialPort seriPort = new SerialPort("COM1");

        private void Btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndm = rnd.Next(2000, 7000);
            label1.Text = rndm.ToString();

            try
            {
                seriPort.Write(rndm.ToString());
            }
            catch(Exception em)
            {
                MessageBox.Show(em.Message.ToString());
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (seriPort.IsOpen) { seriPort.Close(); }
        }
    }
}
