using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsForWin
{
    public partial class TFW : Form
    {
        public TFW()
        {
            InitializeComponent();
        }

        private void TWF_Load(object sender, EventArgs e)
        {
            
        }
        private void twf_btn_wopt_Click(object sender, EventArgs e)
        {
            WOPT optimizer = new WOPT();
            optimizer.Show();
        }

        private void twf_btn_about_Click(object sender, EventArgs e)
        {
            TFW_About about = new TFW_About();
            about.Show();
        }
    }
}
