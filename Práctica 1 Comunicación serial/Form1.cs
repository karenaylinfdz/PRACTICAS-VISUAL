namespace Práctica_1_Comunicación_serial
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        //SerialPort serialPort;
        public Form1()
        {

            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino = new SerialPort("COM3", 9600);
            Arduino.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arduino.Write("F");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduino.Write("E");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
