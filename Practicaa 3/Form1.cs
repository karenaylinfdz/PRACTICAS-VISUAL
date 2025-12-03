using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO.Ports;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduinoo_practica_3
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private bool isBlinking;
        private SoundPlayer soundPlayer;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM3", 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            botonComenzar.Click +=
                botonComenzar_Click;
            timer1.Interval = 500;//Intervalo de parpadeo en milisegundos timmer1.Tick+=timer1_Tick;
            //soundPlayer = new SoundPlayer("C:\\Users\\miria\\OneDrive\\Escritorio\\2024 semestre2\\MECANICA\\gifs\\Emergency Siren Policw Wail 02.Wav");

        }
        protected override void
            OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            base.OnFormClosing(e);
        }
        /*private void Timmer1_Tick(objet? sender,EventArgs e)
        {
        throw new NotlmplementedException();
        }*/


        private void botonComenzar_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
            }
        }
        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            this.Invoke(new Action(() =>
            {
                label1.Text = "Sensor Status." + (data.Trim() == "1" ? "Water Detected" : "No Water Detected");
                if (data.Trim() == "1")
                {
                    if (!isBlinking)
                    {
                        timer1.Start();
                        //soundPlayer.PlayLooping();
                        pictureBox1.BackColor =
                        System.Drawing.Color.Red;
                        isBlinking = true;
                    }
                }
                else
                {
                    if (isBlinking)
                    {
                        //soundPlayer.Stop();
                        pictureBox1.BackColor = System.Drawing.Color.Gray;
                        isBlinking = false;
                    }
                }
            }));
        }
        private void timmer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackColor =
                pictureBox1.BackColor ==
                System.Drawing.Color.Gray ?
                System.Drawing.Color.Yellow :
                System.Drawing.Color.Gray;
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

                
            }
        

