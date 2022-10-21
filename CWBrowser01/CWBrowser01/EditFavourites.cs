using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CWBrowser01
{
    public partial class editfavourites : Form
    {
        private Favourites favourites = new Favourites();
        public editfavourites()
        {
            InitializeComponent();
            loadObjectFromFile();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            favourites.addtofavourites();
        }

        private void loadObjectFromFile()
        {
            favourites = favourites.loadfavourites();
            BindingSource databinding = new BindingSource();
            databinding.DataSource = favourites;
            favdataGrid.DataSource = databinding;
        }

        private void favdelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in favdataGrid.SelectedRows)
            {
                if (!item.IsNewRow)
                {
                    favdataGrid.Rows.RemoveAt(item.Index);
                }

            }
        }

        private void favsaveexit_Click(object sender, EventArgs e)
        {
            favourites.addtofavourites();
            this.Close();
        }
    }
}
