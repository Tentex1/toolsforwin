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

namespace ToolsForWin
{
    public partial class TFW_About : Form
    {
        public TFW_About()
        {
            InitializeComponent();
        }

        private void twf_lbl_about_link_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/duranforreal1";
            Process.Start(url);
        }

        private void twf_lbl_about_lbl_insta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://instagram.com/duranforreal";
            Process.Start(url);
        }

        private void twf_lbl_about_twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://twitter.com/yvz_drn";
            Process.Start(url);
        }

        private void twf_lbl_about_website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://duranforreal1.github.io";
            Process.Start(url);
        }
    }
}
