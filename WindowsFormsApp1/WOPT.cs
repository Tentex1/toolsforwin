using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WOPT : Form
    {
        public WOPT()
        {
            InitializeComponent();
        }

        private void WOPT_Load(object sender, EventArgs e)
        {

        }

        private void wopt_btn_clean_files_Click(object sender, EventArgs e)
        {
            wopt_lbl_clean_files.Text = "Empty Files and Folders Cleaned!";
            string batFilePath = @"C:\Users\bir\source\repos\WindowsFormsApp1\WindowsFormsApp1\cleanfiles.bat";        
            Process.Start(batFilePath);
        }

        private void wopt_btn_change_power_settings_Click(object sender, EventArgs e)
        {
            wopt_lbl_change_power_cfg.Text = "Changed Power Config!";
            string batFilePath = @"C:\Users\bir\source\repos\WindowsFormsApp1\WindowsFormsApp1\changepowercfg.bat";
            Process.Start(batFilePath);
        }
    }
}
