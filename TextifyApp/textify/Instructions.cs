using System.Diagnostics;
using System.Windows.Forms;

namespace TextifyApp
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void Sauce_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/AriHanan/Textify");
        }

        private void Credit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://arihanan.tumblr.com/");
        }
    }
}
