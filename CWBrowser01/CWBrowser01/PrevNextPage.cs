using System;

namespace CWBrowser01
{
    public class PrevNextPage
    {

        private string pageURL;
        private PrevNextPage prevpage;
        private PrevNextPage nextpage;

        // constructors
        public PrevNextPage()
        {
            this.pageURL = "";
            this.prevpage = null;
            this.nextpage = null;
        }
        public PrevNextPage(string goURL)
        {
            this.pageURL = goURL;
            this.prevpage = null;
            this.nextpage = null;
        }
        public PrevNextPage AddPage(string goURL)
        {
            PrevNextPage newpage = new PrevNextPage(goURL);
            return newpage;
        }

        public PrevNextPage AddPageWR(PrevNextPage fromAddpage, string goURL)
        {

            PrevNextPage newpage = new PrevNextPage(goURL);
            if (fromAddpage != null)
            {
                    fromAddpage.nextpage = newpage;
                    newpage.prevpage = fromAddpage;
             }

            return newpage;
        }

        public string getPage()
        {
            return pageURL;
        }

        public PrevNextPage getPrev()
        {
            return prevpage;
        }

        public PrevNextPage getNext()
        {
            return nextpage;
        }
       
    }

    public class PageMaster
    {
        public PageMaster()
        {
         //   first = null;
        }
        public PrevNextPage AddPage(string goURL)
        {
            PrevNextPage passthru = new PrevNextPage();
            passthru = passthru.AddPage(goURL);
            return passthru;
        }

        public PrevNextPage AddPageWR(PrevNextPage fromAddpage, string goURL)
        {

            PrevNextPage passthru = new PrevNextPage();
            passthru = passthru.AddPageWR(fromAddpage, goURL);
            return passthru;

        }
    }
}