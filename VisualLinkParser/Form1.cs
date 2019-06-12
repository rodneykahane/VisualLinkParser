using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLinkParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            String list = "";

            //Uri u = new Uri("http://10.0.0.17/stuff");
            Uri u = new Uri(TxtAddress.Text);
            ExtractLinks parse = new ExtractLinks();
            //  list = parse.Process(u, 1);
            list = parse.Process(u, 1);
            TxtDisplay.Text = list;
        }        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "";
        }
    }
}
