using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWBrowser01
{
    public partial class updatepageinfo : Form
    {

        public string pagecontent;

        public updatepageinfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pageinfo.Text = pagecontent;
            if (pageinfo.Text == "")
            {
                pageinfook.Enabled = false;
            }
            else
            {
                pageinfook.Enabled = true;
            }
        }

        private void updatehomeok_Click(object sender, EventArgs e)
        {
            pagecontent = pageinfo.Text;
            this.Close();
        }

        private void updatehomecancel_Click(object sender, EventArgs e)
        {
            pagecontent = "";
            this.Close();
        }

        private void pagecontent_TextChanged(object sender, EventArgs e)
        {
            if (pageinfo.Text == "")
            {
                pageinfook.Enabled = false;
            }
            else
            {
                pageinfook.Enabled = true;
            }
        }

        private void pagecontent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                if (pageinfo.Text != "")
                {
                    pagecontent = pageinfo.Text;
                    this.Close();
                }
            }
        }
    }
}
