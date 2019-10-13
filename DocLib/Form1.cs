using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace DocLib
{
    public partial class Form1 : Form
    {
        bool serviceStarted = false;
        ServiceHost myServiceHost = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serviceStarted)
            {
                myServiceHost.Close();
                serviceStarted = false;
                button1.Text = "Start Service";
            }
            else
            {
                Uri baseAddress = new Uri("net.tcp://localhost:2202/PatientService");

                NetTcpBinding binding = new NetTcpBinding();

                myServiceHost = new ServiceHost(typeof(DocService), baseAddress);
                myServiceHost.AddServiceEndpoint(typeof(IService1), binding, baseAddress);

                myServiceHost.Open();

                serviceStarted = true;
                button1.Text = "Stop Service";
            }
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
