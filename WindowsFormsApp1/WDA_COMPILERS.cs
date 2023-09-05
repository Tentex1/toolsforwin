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
    public partial class WDA_COMPILERS : Form
    {
        public WDA_COMPILERS()
        {
            InitializeComponent();
        }

        private void compilers_btn_dotnet_Click(object sender, EventArgs e)
        {
            string url = "https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.400-windows-x64-installer";
            Process.Start(url);
        }

        private void compilers_btn_gcc_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/brechtsanders/winlibs_mingw/releases/download/13.2.0mcf-16.0.6-11.0.1-ucrt-r2/winlibs-i686-mcf-dwarf-gcc-13.2.0-llvm-16.0.6-mingw-w64ucrt-11.0.1-r2.zip";
            Process.Start(url);
        }

        private void compilers_btn_rust_Click(object sender, EventArgs e)
        {
            string url = "https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.400-windows-x64-installer";
            Process.Start(url);
        }
    }
}
