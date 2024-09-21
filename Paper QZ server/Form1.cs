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
        static string GetPublicIP()
        {

            string url = "http://checkip.dyndns.org/";
            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = request.GetResponse())
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string responseText = reader.ReadToEnd();
                // Extract the IP address from the response
                int first = responseText.IndexOf("Address: ") + 9;
                int last = responseText.LastIndexOf("</body>");
                return responseText.Substring(first, last - first);
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ip =  GetPublicIP();
            if(textBox1.Text == "****")
            {
                textBox1.Text = ip;
            }
            else 
            {
                textBox1.Text = "****";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
