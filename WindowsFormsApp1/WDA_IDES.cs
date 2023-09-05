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
    public partial class WDA_IDES : Form
    {
        public WDA_IDES()
        {
            InitializeComponent();
        }

        private void ides_btn_vs_Click(object sender, EventArgs e)
        {
            string url = "https://visualstudio.microsoft.com/tr/thank-you-downloading-visual-studio/?sku=Community";
            Process.Start(url);
        }

        private void ides_btn_vscode_Click(object sender, EventArgs e)
        {
            string url = "https://code.visualstudio.com/docs/?dv=win";
            Process.Start(url);
        }

        private void ides_btn_webstorm_Click(object sender, EventArgs e)
        {
            string url = "https://www.jetbrains.com/webstorm/download/download-thanks.html";
            Process.Start(url);
        }

        private void ides_btn_rubymine_Click(object sender, EventArgs e)
        {
            string url = "https://www.jetbrains.com/ruby/download/download-thanks.html?platform=windows";
            Process.Start(url);
        }

        private void ides_btn_rider_Click(object sender, EventArgs e)
        {
            string url = "https://www.jetbrains.com/rider/download/download-thanks.html?platform=windows";
            Process.Start(url);
        }

        private void ides_btn_pycharm_Click(object sender, EventArgs e)
        {
            string url = "https://www.jetbrains.com/pycharm/download/download-thanks.html?platform=windows";
            Process.Start(url);
        }

        private void ides_btn_phpstorm_Click(object sender, EventArgs e)
        {
            string url = "https://www.jetbrains.com/phpstorm/download/download-thanks.html";
            Process.Start(url);
        }

        private void ides_btn_netbeans_Click(object sender, EventArgs e)
        {
            string url = "https://dlcdn.apache.org/netbeans/netbeans-installers/18/Apache-NetBeans-18-bin-windows-x64.exe";
            Process.Start(url);
        }

        private void ides_btn_intellijidea_Click(object sender, EventArgs e)
        {
            string url = "https://www.jetbrains.com/idea/download/download-thanks.html?platform=windows";
            Process.Start(url);
        }

        private void ides_btn_eclipse_Click(object sender, EventArgs e)
        {
            string url = "https://www.eclipse.org/downloads/download.php?file=/oomph/epp/2023-06/R/eclipse-inst-jre-win64.exe&mirror_id=1190";
            Process.Start(url);
        }

        private void ides_btn_clion_Click(object sender, EventArgs e)
        {
            string url = "https://www.jetbrains.com/clion/download/download-thanks.html";
            Process.Start(url);
        }

        private void ides_btn_andrs_Click(object sender, EventArgs e)
        {
            string url = "https://redirector.gvt1.com/edgedl/android/studio/install/2022.3.1.19/android-studio-2022.3.1.19-windows.exe";
            Process.Start(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
