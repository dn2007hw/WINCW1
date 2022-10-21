using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CWBrowser01
{
    [Serializable]
    class Page
    {

        private string _pageName;
        private string _pageURL;

        // public properties to access the data
        public string pageName
        {
            get { return _pageName; }
            set { _pageName = value; }
        }

        public string pageURL
        {
            get { return _pageURL; }
            set { _pageURL = value; }
        }

        public Page(string pageName, string pageURL)
        {
            this.pageName = pageName;
            this.pageURL = pageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", this.pageName, this.pageURL);
        }
        public string getPageName()
        {
            return pageName;
        }
        public string getPageURL()
        {
            return pageURL;
        }
        public void updatePage(string pageName, string pageURL)
        {
            this.pageName = pageName;
            this.pageURL = pageURL;

        }
    }

    [Serializable]
    class Favourites : List<Page>
    {
       
        public Page GetByPage(string pageName)
        {
            return this.FirstOrDefault(page => page.pageName == pageName);
        }

        public Page GetByPageURL(string pageURL)
        {
            return this.FirstOrDefault(page => page.pageURL == pageURL);
        }

        public void addtofavourites()
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream streamOut = new FileStream("favourites.bin", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(streamOut, this);
                    streamOut.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Favourites loadfavourites()
        {
            Favourites localfav = new Favourites();
            string filename = "favourites.bin";
            if (File.Exists(filename))
            {

                try
                {
                    IFormatter formatter = new BinaryFormatter();
                    using (Stream streamIn = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        localfav = (Favourites)formatter.Deserialize(streamIn);
                        streamIn.Close();
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            return localfav;
        }
    }
}