using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;
using System.IO.Ports;

namespace BabyMonitor
{
    public partial class Form1 : Form
    {
        string m_logFilePath;
        int count = 0;
        public Form1()
        {
            System.Diagnostics.Debug.WriteLine("Here");

            m_logFilePath = "";
            InitializeComponent();

            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);

        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if(m_logFilePath != "")
                {
                    SerialPort spl = (SerialPort)sender;
                    var dataRcv = spl.ReadLine();

                    switch(dataRcv)
                    {
                        case "1":
                            string dt1 = DateTime.Now.ToString();
                            System.Diagnostics.Debug.WriteLine("Motion detected at: " + dt1);
                            System.IO.File.AppendAllText(@m_logFilePath, "Motion detected at: " + dt1 + "\n");
                            break;
                        case "0":
                            string dt2 = DateTime.Now.ToString();
                            System.Diagnostics.Debug.WriteLine("Motion ended at: " + dt2);
                            System.IO.File.AppendAllText(@m_logFilePath, "Motion ended at: " + dt2 + "\n");
                            break;
                        default:
                            break;
                    }

                    System.Diagnostics.Debug.WriteLine("Data received" + dataRcv);

                }

                count++;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM5";
            serialPort1.BaudRate = 9600;

            try
            {
                System.Diagnostics.Debug.WriteLine("Trying to open serial port");

                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    System.Diagnostics.Debug.WriteLine("Serial Port Open");

                    label2.Text = "Connected to Baby Monitor";
                    label2.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                    m_logFilePath = saveFileDialog1.FileName;
                }
            }
        }

        private void openLog_Click(object sender, EventArgs e)
        {
            if (m_logFilePath != "")
            {
                Process.Start(m_logFilePath);
            }
        }

        private void write_Click(object sender, EventArgs e)
        {
            if(m_logFilePath != "")
            {
                string dt = DateTime.Now.ToString();

                System.IO.File.AppendAllText(@m_logFilePath, dt);
                System.IO.File.AppendAllText(@m_logFilePath, "\n");
            }

        }

        private void stop_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();

                    m_logFilePath = "";

                    label2.Text = "Not connected";
                    label2.ForeColor = Color.Red;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
