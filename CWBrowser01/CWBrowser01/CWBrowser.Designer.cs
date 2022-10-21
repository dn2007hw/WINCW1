
namespace CWBrowser01
{
    partial class CWBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Go = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.RichTextBox();
            this.download = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCurrentAsHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHomeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCurrentPageToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyhomepage = new System.Windows.Forms.ToolStripMenuItem();
            this.historyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadMultiplePagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.httpresponsestatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.refresh = new System.Windows.Forms.Button();
            this.addfavouritebtn = new System.Windows.Forms.Button();
            this.httpresponsecode = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Go.Location = new System.Drawing.Point(822, 28);
            this.Go.Margin = new System.Windows.Forms.Padding(2);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(30, 20);
            this.Go.TabIndex = 1;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // urlBox
            // 
            this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBox.Location = new System.Drawing.Point(156, 27);
            this.urlBox.Margin = new System.Windows.Forms.Padding(2);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(666, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlBox_KeyPress);
            // 
            // contentBox
            // 
            this.contentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentBox.Location = new System.Drawing.Point(0, 53);
            this.contentBox.Margin = new System.Windows.Forms.Padding(2);
            this.contentBox.Name = "contentBox";
            this.contentBox.ReadOnly = true;
            this.contentBox.Size = new System.Drawing.Size(984, 507);
            this.contentBox.TabIndex = 2;
            this.contentBox.Text = "";
            // 
            // download
            // 
            this.download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.download.Location = new System.Drawing.Point(918, 28);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(64, 20);
            this.download.TabIndex = 5;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.bulkDownload_Click);
            // 
            // Prev
            // 
            this.Prev.Enabled = false;
            this.Prev.Location = new System.Drawing.Point(50, 27);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(23, 20);
            this.Prev.TabIndex = 6;
            this.Prev.Text = "<";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(72, 27);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(25, 20);
            this.Next.TabIndex = 7;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(3, 27);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(47, 20);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.setCurrentAsHomeToolStripMenuItem,
            this.editHomeToolStripMenuItem1,
            this.exitBrowserToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "&Home";
            this.homeToolStripMenuItem.ToolTipText = "Home Menu";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.homePageToolStripMenuItem.Text = "&Home Page";
            this.homePageToolStripMenuItem.ToolTipText = "Click to go to Home page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // setCurrentAsHomeToolStripMenuItem
            // 
            this.setCurrentAsHomeToolStripMenuItem.Name = "setCurrentAsHomeToolStripMenuItem";
            this.setCurrentAsHomeToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.setCurrentAsHomeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.setCurrentAsHomeToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.setCurrentAsHomeToolStripMenuItem.Text = "&Set Current as Home Page";
            this.setCurrentAsHomeToolStripMenuItem.ToolTipText = "Click to save the current page as Home page";
            this.setCurrentAsHomeToolStripMenuItem.Click += new System.EventHandler(this.setCurrentAsHomeToolStripMenuItem_Click);
            // 
            // editHomeToolStripMenuItem1
            // 
            this.editHomeToolStripMenuItem1.Name = "editHomeToolStripMenuItem1";
            this.editHomeToolStripMenuItem1.ShortcutKeyDisplayString = "";
            this.editHomeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editHomeToolStripMenuItem1.Size = new System.Drawing.Size(252, 22);
            this.editHomeToolStripMenuItem1.Text = "&Edit Home Page";
            this.editHomeToolStripMenuItem1.ToolTipText = "Click to edit the home page (ALT + E)";
            this.editHomeToolStripMenuItem1.Click += new System.EventHandler(this.editHomeToolStripMenuItem1_Click);
            // 
            // exitBrowserToolStripMenuItem
            // 
            this.exitBrowserToolStripMenuItem.Name = "exitBrowserToolStripMenuItem";
            this.exitBrowserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.exitBrowserToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.exitBrowserToolStripMenuItem.Text = "&Close Browser";
            this.exitBrowserToolStripMenuItem.ToolTipText = "Click to exit the browser (Alt + X)";
            this.exitBrowserToolStripMenuItem.Click += new System.EventHandler(this.exitBrowserToolStripMenuItem_Click);
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCurrentPageToFavouritesToolStripMenuItem,
            this.listToolStripMenuItem,
            this.editFavouritesToolStripMenuItem});
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.favouritesToolStripMenuItem.Text = "&Favourites";
            // 
            // addCurrentPageToFavouritesToolStripMenuItem
            // 
            this.addCurrentPageToFavouritesToolStripMenuItem.Name = "addCurrentPageToFavouritesToolStripMenuItem";
            this.addCurrentPageToFavouritesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addCurrentPageToFavouritesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addCurrentPageToFavouritesToolStripMenuItem.Text = "&Add to Favourites";
            this.addCurrentPageToFavouritesToolStripMenuItem.ToolTipText = "Click to add current page to Favourites";
            this.addCurrentPageToFavouritesToolStripMenuItem.Click += new System.EventHandler(this.addCurrentPageToFavouritesToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.listToolStripMenuItem.Text = "&List";
            // 
            // editFavouritesToolStripMenuItem
            // 
            this.editFavouritesToolStripMenuItem.Name = "editFavouritesToolStripMenuItem";
            this.editFavouritesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.editFavouritesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.editFavouritesToolStripMenuItem.Text = "&Edit Favourites";
            this.editFavouritesToolStripMenuItem.ToolTipText = "Click to edit the favourites";
            this.editFavouritesToolStripMenuItem.Click += new System.EventHandler(this.editFavouritesToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyhomepage,
            this.historyListToolStripMenuItem,
            this.clearHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "His&tory";
            // 
            // historyhomepage
            // 
            this.historyhomepage.Name = "historyhomepage";
            this.historyhomepage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.historyhomepage.Size = new System.Drawing.Size(183, 22);
            this.historyhomepage.Text = "&Home Page";
            this.historyhomepage.ToolTipText = "Click to goto Home page";
            this.historyhomepage.Click += new System.EventHandler(this.histopryhomepage_Click);
            // 
            // historyListToolStripMenuItem
            // 
            this.historyListToolStripMenuItem.Name = "historyListToolStripMenuItem";
            this.historyListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.historyListToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.historyListToolStripMenuItem.Text = "&List";
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clearHistoryToolStripMenuItem.Text = "&Clear History";
            this.clearHistoryToolStripMenuItem.ToolTipText = "Click to clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // bulkDownloadToolStripMenuItem
            // 
            this.bulkDownloadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadMultiplePagesToolStripMenuItem});
            this.bulkDownloadToolStripMenuItem.Name = "bulkDownloadToolStripMenuItem";
            this.bulkDownloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.bulkDownloadToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.bulkDownloadToolStripMenuItem.Text = "&Bulk Download";
            // 
            // downloadMultiplePagesToolStripMenuItem
            // 
            this.downloadMultiplePagesToolStripMenuItem.Name = "downloadMultiplePagesToolStripMenuItem";
            this.downloadMultiplePagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.downloadMultiplePagesToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.downloadMultiplePagesToolStripMenuItem.Text = "&Download Multiple Pages";
            this.downloadMultiplePagesToolStripMenuItem.ToolTipText = "Click to download files in bulk";
            this.downloadMultiplePagesToolStripMenuItem.Click += new System.EventHandler(this.downloadMultiplePagesToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.favouritesToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.bulkDownloadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "bulk";
            this.openFileDialog1.Filter = "\"Text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            this.openFileDialog1.InitialDirectory = "\\\\Mac\\Home\\Documents\\CodeSep\\WINCW\\CWBrowser01\\CWBrowser01\\bin\\Debug\\";
            this.openFileDialog1.Title = "Bulk Download - Select a file";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpresponsestatus,
            this.httpresponsecode});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // httpresponsestatus
            // 
            this.httpresponsestatus.Name = "httpresponsestatus";
            this.httpresponsestatus.Size = new System.Drawing.Size(0, 17);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(97, 28);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(58, 19);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Reload";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.Reload_Click_1);
            // 
            // addfavouritebtn
            // 
            this.addfavouritebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addfavouritebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addfavouritebtn.Location = new System.Drawing.Point(851, 28);
            this.addfavouritebtn.Name = "addfavouritebtn";
            this.addfavouritebtn.Size = new System.Drawing.Size(68, 20);
            this.addfavouritebtn.TabIndex = 4;
            this.addfavouritebtn.Text = "Add to Fav";
            this.addfavouritebtn.UseVisualStyleBackColor = true;
            this.addfavouritebtn.Click += new System.EventHandler(this.addfavouritebtn_Click);
            // 
            // httpresponsecode
            // 
            this.httpresponsecode.Name = "httpresponsecode";
            this.httpresponsecode.Size = new System.Drawing.Size(0, 17);
            // 
            // CWBrowser
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.addfavouritebtn);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.download);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "CWBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CWBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.RichTextBox contentBox;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHomeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCurrentPageToFavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkDownloadToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setCurrentAsHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadMultiplePagesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel httpresponsestatus;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFavouritesToolStripMenuItem;
        private System.Windows.Forms.Button addfavouritebtn;
        private System.Windows.Forms.ToolStripMenuItem historyhomepage;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel httpresponsecode;
    }
}

