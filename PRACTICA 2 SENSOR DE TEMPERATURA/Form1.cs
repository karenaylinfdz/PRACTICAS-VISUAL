using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace PRACTICA_2_SENSOR_DE_TEMPERATURA
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        bool puertoCerrado = false;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;

        }

        private void LABEL1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (puertoCerrado == false)
            {
                conectar();
            }
            else
            {
                noConectado();

            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            
          
            this.Invoke(new MethodInvoker(delegate

        {
            string[] values = data.Split('\t');
            if (values.Length == 2)
            {
                LABEL1.Text = values[1];
                label2.Text = values[0];
                listBox1.Items.Add(values[1] + " " + values[0]);
            }
        }));
        }

        private void button1_Click_1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void conectar()
        {
            try
            {
                puertoCerrado = true;
                
                serialPort.Open();
                botonConectar.Text = "DESCONECTAR";
                botonConectar.BackColor = Color.Black;
                
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void noConectado()
        {
            try
            {
                puertoCerrado = false;
                serialPort.Close(); 
                
                botonConectar.Text = "CONECTAR";
                botonConectar.BackColor = Color.Blue;
                listBox1.Items.Clear();
                LABEL1.Text = "TEMPERATURA °C";
               label2.Text = "HUMEDAD %";
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}   