using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWBrowser01
{



    public partial class CWBrowser : Form
    {

        private static HttpClient Client = new HttpClient();
        public CWBrowser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string goURL = textBox1.Text;
            _ = gotoPageAsync(goURL);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                string goURL = textBox1.Text;
                _ = gotoPageAsync(goURL);

            }
        }

        private async Task gotoPageAsync(string goURL) 
        {

            try
            {
                var resultStatus = await Client.GetAsync(goURL);
                //   Console.WriteLine(result.StatusCode);
                //    Console.WriteLine(result.Headers);
                Console.WriteLine("After status call");
                Console.WriteLine("Result is {0}",resultStatus.StatusCode);
               // richTextBox1.Text = result;
            }
            catch (HttpRequestException e) {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                richTextBox1.Text = e.Message;
            }

            try
            {
                var resultContent = await Client.GetStringAsync(goURL);
                //   Console.WriteLine(result.StatusCode);
                //    Console.WriteLine(result.Headers);
                Console.WriteLine("After content call");
                Console.WriteLine(resultContent.Length);
                richTextBox1.Text = resultContent;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                richTextBox1.Text = e.Message;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            //            Console.WriteLine("Home clicked");
            //            AddHomePage("https://www.google.com");
            string getURL = returnHomePage();
            _ = gotoPageAsync(getURL);
            textBox1.Text = getURL;

        }

        public static void AddHomePage(string homePageURL)
        {
            Console.WriteLine("entered addhomepage");
            try
            {
                StreamWriter sw = new StreamWriter("homepage.txt");
                sw.WriteLine(homePageURL);
                sw.Close();
            }
            catch (IOException ex)
            {
             Console.WriteLine(ex.Message);   
            }
        }

        public static string returnHomePage()
        {
            Console.WriteLine("entered return home page");
            try
            {
                StreamReader sr = new StreamReader("homepage.txt");
                string inValue = "";
                while ((inValue = sr.ReadLine()) != null)
                    return (inValue);
                sr.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button clicked");
            Console.WriteLine(returnHomePage());

        }

        private void setCurrentAsHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHomePage(textBox1.Text);
        }
    }


}
