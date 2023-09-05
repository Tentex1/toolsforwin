using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WDA : Form
    {
        public WDA()
        {
            InitializeComponent();
        }

        private void WDA_Load(object sender, EventArgs e)
        {

        }

        private void wda_btn_ides_Click(object sender, EventArgs e)
        {
            WDA_IDES ides = new WDA_IDES();
            ides.Show();
        }

        private void wda_btn_teditors_Click(object sender, EventArgs e)
        {
            WDA_TEDITORS teditors = new WDA_TEDITORS();
            teditors.Show();
        }

        private void wda_btn_compilers_Click(object sender, EventArgs e)
        {
            WDA_COMPILERS compilers = new WDA_COMPILERS();
            compilers.Show();
        }
    }
}
