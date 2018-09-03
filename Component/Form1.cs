using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!url.Text.StartsWith("http://") && !url.Text.StartsWith("https://"))
            {
                url.Text = "http://" + url.Text;
            }

            try
            {
                webBrowser1.Navigate(new Uri(url.Text));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }
    }
}
