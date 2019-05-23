using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduniodtmfHack
{
    public partial class Form1 : Form
    {
        string[] portlar = SerialPort.GetPortNames();
        public Form1()
        {
            InitializeComponent();
        }
   
        string sonuc;
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("WeLCome to Dtmf Hacking Tools.","Bekra Hayr Nester");
            foreach (string port in portlar)
            {
                comboBoxEx1.Items.Add(port);
                comboBoxEx1.SelectedIndex = 0;
                comboBoxEx2.SelectedIndex = 1;
            }
        }
            private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                sonuc = serialPort1.ReadExisting();                  
                if (sonuc != "")
                {
                    textBoxX1.Text += sonuc;
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                timer1.Stop();
            }
        }
        
        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            if (serialPort1.IsOpen == false)
            {
                if (comboBoxEx1.Text == "")

                    return;
                serialPort1.PortName = comboBoxEx1.Text;
                serialPort1.BaudRate = Convert.ToInt16(comboBoxEx2.Text);
                try
                {
                    serialPort1.Open();
                    label2.Text = "Connect Open";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                label2.Text = "Bağlantı kuruldu";
            }
            }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (serialPort1.IsOpen==true)
            {
                serialPort1.Close();
                label2.Text = "Connect Close";
            }
        }
        private void buttonX4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            base.Close();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            textBoxX1.Text = "";
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            string yol = Application.StartupPath + "" + "/Dial/Dial.exe";
            Process.Start(yol.ToString(),"0123456789");
        }
    }
    }

