using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TFW : Form
    {
        public TFW()
        {
            InitializeComponent();
        }

        private void TFW_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        
        private void btn_wda_Click(object sender, EventArgs e)
        {
            WDA wda = new WDA();
            wda.Show();
        }

        private void btn_wopt_Click(object sender, EventArgs e)
        {
            WOPT wopt = new WOPT();
            wopt.Show();
        }

        private void tfw_btn_website_Click(object sender, EventArgs e)
        {
            string url = "https://duranforreal1.github.io";
            Process.Start(url);
        }
    }
}
