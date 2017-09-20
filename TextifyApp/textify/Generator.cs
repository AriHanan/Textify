using System;
using System.Windows.Forms;

namespace TextifyApp
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();
        }

        private void Trygeneratingplz(object sender, EventArgs e)
        {
            try
            {
                string bob = "";
                for (int i = 0; i < Math.Min(originalabc.Text.Length, modifiedabc.Text.Length); i++)
                {
                    if (originalabc.Text[i] != modifiedabc.Text[i])
                    {
                        bob += ",\r\n{ '" + originalabc.Text[i] + "', \"" + modifiedabc.Text[i] + "\" }";
                    }
                }
                code.Text = bob.Substring(2);
            }
            catch { }
        }
    }
}
