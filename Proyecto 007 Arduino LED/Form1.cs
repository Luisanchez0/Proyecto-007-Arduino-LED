using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;//usa los puertos de la PC

namespace Proyecto_007_Arduino_LED
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }
        //obbtiene las puertas de comunicacion serial del PC

        public Form1()
        {
            InitializeComponent();
            //PUERTO [COM3]
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3";
            ArduinoPort.BaudRate = 9600;
            //velocidad de baudios en el puerto serie los baudios pueden contener varios bits
            ArduinoPort.Open();

            //vinculacion de los eventos
            this.btn_Apagar.Click += btn_Apagar_Click;
            this.btn_Encender.Click += btn_Encender_Click;
            this.FormClosing += close_form;

        }

        private void close_form(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }

        private void btn_Encender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }
    }
}
