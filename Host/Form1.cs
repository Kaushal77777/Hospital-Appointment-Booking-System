using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFservice;

namespace Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (ServiceHost host = new ServiceHost(typeof(ServiceReference.)))
            //{
            //    host.Open();
            //    label1.Text = "Service Running";
            //}
        }
    }
}
