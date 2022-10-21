using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWBrowser01
{
    public partial class CWBrowser : Form
    {

        private static HttpClient Client = new HttpClient();
        private PageMaster masterpage = new PageMaster(); 
        private PrevNextPage prevnextpage = new PrevNextPage();
        private PrevNextPage currpage = new PrevNextPage();
        private Favourites favourites = new Favourites();

        bool historylistempty = true;
        bool favouritelistempty = true;
        
        public CWBrowser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            prevnextpage = null;
            currpage = null;

            loadFavouritesFromBin(listToolStripMenuItem);
            loadHistory(historyListToolStripMenuItem);
            loadHomepage();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            loadHomepage();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            currpage = currpage.getPrev();
            _ = gotoPageAsync(currpage.getPage(), false, false);
        }
        private void Next_Click(object sender, EventArgs e)
        {
            currpage = currpage.getNext();
            _ = gotoPageAsync(currpage.getPage(), false, false);
        }

        private void Reload_Click_1(object sender, EventArgs e)
        {
            _ = gotoPageAsync(string.Format(urlBox.Text.Trim()), false, true);
        }

        private void urlBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                _ = gotoPageAsync(string.Format(urlBox.Text.Trim()), true, false);
            }
        }
        private void Go_Click(object sender, EventArgs e)
        {
            _ = gotoPageAsync(string.Format(urlBox.Text.Trim()), true, false);
            prevnextpage = masterpage.AddPage(string.Format(urlBox.Text.Trim()));
        }

        private void addfavouritebtn_Click(object sender, EventArgs e)
        {
            string pagename = string.Format(this.Text.Trim());
            if (pagename == "")
            {
                pagename = string.Format(urlBox.Text.Trim());
            }
            addFavourites(pagename);
        }
        private void bulkDownload_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                performbulkdownload(openFileDialog1.FileName);
                openFileDialog1.FileName = "bulk";
            }
            this.Opacity = 1;
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadHomepage();
        }

        private void setCurrentAsHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.Format(urlBox.Text.Trim()) != "")
            {
                writeintoFile("homepage.txt", string.Format(urlBox.Text.Trim()), false, false);
            }
        }

        private void editHomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string homepage = string.Format(returnHomePage().Trim());
      
                this.Opacity = 0.2;
                updatepageinfo upiform = new updatepageinfo();
                upiform.Text = "Update Home Page";
                upiform.pagecontent = homepage;
                upiform.ShowDialog();
                string pagename = string.Format(upiform.pagecontent.Trim());
                this.Opacity = 1;

                if (pagename != "" && pagename != homepage)
                {
                    writeintoFile("homepage.txt", pagename, false, false);
                }
        }

        private void addCurrentPageToFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
            updatepageinfo upiform = new updatepageinfo();
            upiform.Text = "Add to Favourites";
            if (string.Format(this.Text.Trim()) != "")
            {
                upiform.pagecontent = string.Format(this.Text.Trim());
            }
            else
            {
                upiform.pagecontent = string.Format(urlBox.Text.Trim());
            }
            upiform.ShowDialog();
            string pagename = string.Format(upiform.pagecontent.Trim());
            this.Opacity = 1;
            if (pagename != "")
            {
                addFavourites(pagename);
            }

        }

        private void addFavourites(string pagename)
        {
            favourites.Add(new Page(pagename, urlBox.Text));
            favourites.addtofavourites();
            AddtoFavouriteMenu(listToolStripMenuItem, pagename);
            addfavouritebtn.Enabled = false;
            addCurrentPageToFavouritesToolStripMenuItem.Enabled = false;
        }

        private void editFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editfavourites editfav = new editfavourites();
            editfav.Owner = this;
            this.Opacity = 0.20;
            editfav.ShowDialog();
            this.Opacity = 1;

            loadFavouritesFromBin(listToolStripMenuItem);
            checkFavouriteExists(string.Format(urlBox.Text.Trim()));
        }
        private void histopryhomepage_Click(object sender, EventArgs e)
        {
            loadHomepage();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.20;
            DialogResult confirmation = MessageBox.Show("Are you sure to delete your browsing history ?", "Confirmation", MessageBoxButtons.YesNo);
            this.Opacity = 1;
            if (confirmation == DialogResult.Yes)
            {
                writeintoFile("history.txt", "", false, true);
                
                historyListToolStripMenuItem.DropDownItems.Clear();
                historyListToolStripMenuItem.DropDownItems.Add("<empty list>");
                historylistempty = true;

                Next.Enabled = false;
                Prev.Enabled = false;
                addfavouritebtn.Enabled = false;
                addCurrentPageToFavouritesToolStripMenuItem.Enabled = false;

                prevnextpage = null;
                currpage = null;

                contentBox.Text = "";
                urlBox.Text = "";
                this.httpresponsestatus.Text = "";
                this.Text = "CWBrowser";
            }
        }

        private void downloadMultiplePagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.20;
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
            {
                performbulkdownload(openFileDialog1.FileName);
                openFileDialog1.FileName = "bulk";
            }
            this.Opacity = 1;
        }

        private void loadHomepage()
        {
            string getURL = returnHomePage();
            _ = gotoPageAsync(string.Format(getURL.Trim()), true, false);
            urlBox.Text = string.Format(getURL.Trim());
        }

        private string returnHomePage()
        {
            string filename = "homepage.txt";

            if (!File.Exists(filename))
            {
                writeintoFile(filename, "https://www.hw.ac.uk", false, false);
            }
            
            string[] linesreadfromfile = loadFile(filename);
            return linesreadfromfile[0];
        }

        private async Task gotoPageAsync(string goURL, bool historyflag, bool reloadflag) 
        {

            goURL = constructURL(goURL);
            if (validateURL(goURL))
            {
                checkFavouriteExists(goURL);
                if (historyflag)
                {
                    writeintoFile("history.txt", goURL, true, false);
                    AddtoHistoryMenu(historyListToolStripMenuItem, goURL);

                    if (currpage == null)
                    {
                        prevnextpage = masterpage.AddPage(goURL);
                    }
                    else
                    {
                        prevnextpage = masterpage.AddPageWR(currpage, goURL);
                    }

                    currpage = prevnextpage;
                }
                    if (currpage.getPrev() == null)
                    {
                        Prev.Enabled = false;
                    }
                    else
                    {
                        Prev.Enabled = true;
                    }

                    if (currpage.getNext() == null)
                    {
                        Next.Enabled = false;
                    }
                    else
                    {
                        Next.Enabled = true;
                    }
                
                try
                {
                    this.Text = "CWBrowser";
                    urlBox.Text = goURL;
                    var resultStatus = await Client.GetAsync(goURL);
                    var pageContents = await resultStatus.Content.ReadAsStringAsync();
                    string titleAsync = Regex.Match(pageContents, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;
                    this.Text = String.Format(titleAsync.Trim());
                    httpresponsecode.Text = "HTTP Response Status Code: " + (int)resultStatus.StatusCode;
                    httpresponsestatus.Text = "HTTP Response Status Message: " + resultStatus.StatusCode.ToString();

                    if (resultStatus.IsSuccessStatusCode)
                    {
                        contentBox.Text = pageContents;
                    }
                    else
                    {
                        contentBox.Text = "HTTP Response Status Code: " + (int)resultStatus.StatusCode + "\nHTTP Response Status Message: " + resultStatus.StatusCode.ToString();
                    }

                    if (this.Text == "")
                     {
                            this.Text = goURL;
                     }                
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                    contentBox.Text = e.Message;
                    contentBox.Text += "\n Please check and re-try with valid URL.";

                    this.httpresponsestatus.Text = "";
                    this.Text = "CWBrowser";
                }
            }
            else
            {
                contentBox.Text = "Blank URL, try again with a valid URL.";
                addfavouritebtn.Enabled = false;
                addCurrentPageToFavouritesToolStripMenuItem.Enabled = false;
            }

        }

        private bool validateURL(string goURL)
        {
            if (goURL.Equals("about:blank") || goURL.Equals(""))
            {
                contentBox.Text = "";
                httpresponsestatus.Text = "";
                this.Text = "CWBrowser";
                return false;
            }
            else
            {
                return true;
            }

        }

        private string constructURL(string goURL)
        {
            string temp="";
            if (goURL.StartsWith("http://") || goURL.StartsWith("https://") || goURL == "")
            {
                temp = goURL;
            }
            else if (goURL.Contains("."))
            {
                temp = String.Format("https://www." + goURL);
            }
            else
            {
                temp = String.Format("https://www." + goURL + ".com");
            }
            return temp;
        }



        private void AddHomePage(string homePageURL)
        {
            writeintoFile("homepage.txt", homePageURL,false,false);
        }

        private void AddtoFavouriteMenu(ToolStripMenuItem listToolStripMenuItem, string pagename)
        {
            if (favouritelistempty)
            {
                listToolStripMenuItem.DropDownItems.Clear();
                favouritelistempty = false;
            }

            ToolStripMenuItem favsubmenu = new ToolStripMenuItem(pagename.Trim());
            favsubmenu.Click += Favsubmenu_Click;
            listToolStripMenuItem.DropDownItems.Add(favsubmenu);
        }

        private void AddtoHistoryMenu(ToolStripMenuItem historyToolStripMenuItem, string pageURL)
        {
            if (historylistempty)
            {
                historyListToolStripMenuItem.DropDownItems.Clear();
                historylistempty = false;
            }

            ToolStripMenuItem histsubmenu = new ToolStripMenuItem(pageURL);
            histsubmenu.Click += HisSubmenu_Click;
            historyToolStripMenuItem.DropDownItems.Add(histsubmenu);
        }

        private void HisSubmenu_Click(object sender, EventArgs e)
        {
            string url = sender.ToString();
            _ = gotoPageAsync(url, true, false);

        }

        private void loadFavouritesFromBin(ToolStripMenuItem listToolStripMenuItem)
        {

            listToolStripMenuItem.DropDownItems.Clear();
            favouritelistempty = true;
     
            favourites = favourites.loadfavourites();
            foreach (Page page in favourites)
            {
                ToolStripMenuItem favsubmenu = new ToolStripMenuItem(page.getPageName());
                favsubmenu.Click += Favsubmenu_Click;
                listToolStripMenuItem.DropDownItems.Add(favsubmenu);
                favouritelistempty = false;
            }

            if (favouritelistempty)
            {
                listToolStripMenuItem.DropDownItems.Add("<empty list>");

            }
        }

        private void Favsubmenu_Click(object sender, EventArgs e)
        {
            string pagename = sender.ToString();
            Page page = favourites.GetByPage(pagename);
            string url = page.getPageURL();
            _ = gotoPageAsync(url, true, false);

        }

        private void checkFavouriteExists(string pageURL)
        {
            Page page = favourites.GetByPageURL(pageURL);
            if (page == null)
            {
                addfavouritebtn.Enabled = true;
                addCurrentPageToFavouritesToolStripMenuItem.Enabled = true;

            }
            else
            {
                addfavouritebtn.Enabled = false;
                addCurrentPageToFavouritesToolStripMenuItem.Enabled = false;
            }
        }
        
        private void loadHistory(ToolStripMenuItem historyToolStripMenuItem)
        {
            historyToolStripMenuItem.DropDownItems.Clear();
            string filename = "history.txt";
            historylistempty = true;
            if (File.Exists(filename))
            {
                string[] linesreadfromfile = loadFile(filename);
                foreach (string lineread in linesreadfromfile)
                {
                    if (lineread != "")
                    {
                        ToolStripMenuItem histsubmenu = new ToolStripMenuItem(lineread);
                        histsubmenu.Click += HisSubmenu_Click;
                        historyToolStripMenuItem.DropDownItems.Add(histsubmenu);
                        historylistempty = false;
                    }
                }
            }
        }
        
        private void performbulkdownload(string filename)
        {
            contentBox.Text = "";
            httpresponsestatus.Text = "Bulk download in progress...";

            string[] linesreadfromfile = loadFile(filename);
            foreach (string lineread in linesreadfromfile)
            {
                if (lineread != "")
                {
                    _ = gotoPageAsyncBD(lineread);
                }
            }
            this.httpresponsestatus.Text = "Bulk download complete.";
        }
        
        private async Task gotoPageAsyncBD(string goURL)
        {

            int displaystatuscode = 0;
            int bytecount = 0;

            try
            {
                var resultStatus = await Client.GetAsync(goURL);
                var pageContents = await resultStatus.Content.ReadAsByteArrayAsync();
                displaystatuscode = (int)resultStatus.StatusCode;
                bytecount = pageContents.Length * sizeof(char);
                
                if (resultStatus.IsSuccessStatusCode)
                {
                    contentBox.Text += string.Format("<" + displaystatuscode.ToString() + "> <" + bytecount.ToString() + "> <" + goURL + ">\n");
                 }

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught! for URL:" + goURL);
                Console.WriteLine("Message :{0} ", e.Message);
            }
            
        }

        private void exitBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string[] loadFile(string filename)
        {
            List<string> linesread = new List<string>();

            if (File.Exists(filename))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        string lineread = "";
                        while ((lineread = sr.ReadLine()) != null)
                        {
                            linesread.Add(lineread);
                        }
                    sr.Close();
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Exception thrown while reading file " + filename);
                    Console.WriteLine(ex.Message);
                }
             }
            return linesread.ToArray();
        }

        private void  writeintoFile(string filename, string dataline, bool appendstatus, bool clearfile)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename, append: appendstatus))
                {
                    if (clearfile)
                    {
                        sw.Flush();
                    }
                    else 
                    {
                        sw.WriteLine(dataline);
                    }
                    sw.Close();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception thrown while writing into file " + filename);
                Console.WriteLine(ex.Message);
            }

        }
        /*end of code*/
    }
}
