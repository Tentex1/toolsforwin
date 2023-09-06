using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace ToolsForWin
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
        private void wopt_btn_cleanfiles_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\bir\source\repos\ToolsForWin\ToolsForWin\cleanfiles.bat";
            Process.Start(path);
            wopt_lbl_cleanemptyfiles.Text = "Program Opened!";
            Thread.Sleep(1750);
            wopt_lbl_cleanemptyfiles.Text = "";
        }
        private void wopt_btn_changepowercfg_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\bir\source\repos\ToolsForWin\ToolsForWin\changepowercfg.bat";
            Process.Start(path);
            wopt_lbl_changepowercfg.Text = "Program Opened!";
            Thread.Sleep(1750);
            wopt_lbl_changepowercfg.Text = "";
        }

        private void wopt_btn_diskcleanup_Click(object sender, EventArgs e)
        {
            string path = @"C:\WINDOWS\system32\cleanmgr.exe";
            Process.Start(path);
            wopt_lbl_diskcleanup.Text = "Program Opened!";
            Thread.Sleep(1750);
            wopt_lbl_diskcleanup.Text = "";
        }
    }
}
