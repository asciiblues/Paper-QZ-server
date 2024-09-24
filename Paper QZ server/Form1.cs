using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace Paper_QZ_server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "/server.bat");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string processName = "javaw.exe"; // Replace with the name of the process you want to check
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length > 0)
            {
                
            }
            else
            {
                Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\QZ Tray\QZ Tray.lnk");
            }
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    } 
}
