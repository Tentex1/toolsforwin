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
    public partial class WDA_TEDITORS : Form
    {
        public WDA_TEDITORS()
        {
            InitializeComponent();
        }

        private void WDA_TEDITORS_Load(object sender, EventArgs e)
        {
            
        }

        private void teditors_btn_atom_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/atom/atom/releases/download/v1.60.0/atom-x64-windows.zip";
            Process.Start(url);
        }

        private void teditors_btn_brackets_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/brackets-cont/brackets/releases/download/v2.2.1/Brackets-2.2.1.exe";
            Process.Start(url);
        }

        private void teditors_btn_gvim_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/vim/vim-win32-installer/releases/download/v9.0.1811/gvim_9.0.1811_x64.zip";
            Process.Start(url);
        }

        private void teditors_btn_lighttable_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/LightTable/LightTable/releases/download/0.8.1/lighttable-0.8.1-windows.zip";
            Process.Start(url);
        }

        private void teditors_btn_sublimetext_Click(object sender, EventArgs e)
        {
            string url = "http://www.sublimetext.com/download_thanks?target=win-x64";
            Process.Start(url);
        }

        private void teditors_btn_n2_Click(object sender, EventArgs e)
        {
            string url = "https://www.flos-freeware.ch/zip/notepad2_4.2.25_x64.zip";
            Process.Start(url);
        }

        private void teditors_btn_npp_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.5.6/npp.8.5.6.Installer.x64.exe";
            Process.Start(url);
        }

        private void teditors_btn_neovim_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/neovim/neovim/releases/download/stable/nvim-win64.zip";
            Process.Start(url);
        }
    }
}
