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
    public partial class EditHomePage : Form
    {

        private HomePage homepage = new HomePage();

        public EditHomePage()
        {
            InitializeComponent();

        }

        private void homecancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homesave_Click(object sender, EventArgs e)
        {

        }


        private void EditHomePage_Load(object sender, EventArgs e)
        {
           // homepagename = homepage.getpagename();
           // homepageurl = homepage.getpageurl();
        }
    }

    }
}
