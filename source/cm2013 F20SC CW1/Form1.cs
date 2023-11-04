using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace cm2013_F20SC_CW1
{
    public partial class Form1 : Form
    {
        // Default home page on startup
        private static string home = "https://www.hw.ac.uk/";
        private static string url = home;
        // Stacks used for storing the pages backwards and forth of the current accessed page.
        private static Stack<String> prevPage = new Stack<String>();
        private static Stack<String> nextPage = new Stack<String>();

        // Two Linked Lists of type HistoryItem and BookmarkItem for storing the dynamically changing history and favourites lsits.
        private static LinkedList<HistoryItem> historyLink = new LinkedList<HistoryItem>();
        private static LinkedList<BookmarkItem> bookmarkLink = new LinkedList<BookmarkItem>();
        private static string title;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
            loadHTML(url);

        }

        // Button for going back a page
        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Pushes the current page to the forth page stack
            // Enables the next page button to be accessed
            nextPage.Push(url);
            btnNext.Enabled = true;

            // Pops the contents of the previous page stack and sets it to the URL for the browser
            string tempURL = prevPage.Pop();
            textBoxURL.Text = tempURL;
            url = tempURL;
            loadHTML(url);

            // IF statement that will disable the button once the stack's empty.
            if (prevPage.Count == 0)
            {
                btnPrev.Enabled = false;
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void toolTipHome_Popup(object sender, PopupEventArgs e)
        {

        }
        // Button for going forward a page
        private void btnForward_Click(object sender, EventArgs e)
        {
            // Pushes the current page to the backwards page stack
            // Enables the previous page button to be accessed
            prevPage.Push(url);
            btnPrev.Enabled = true;

            // Pops the contents of the next page stack and sets it to the URL for the browser
            string tempURL = nextPage.Pop();
            textBoxURL.Text = tempURL;
            url = tempURL;
            loadHTML(url);

            // IF statement that will disable the button once the stack is empty.
            if (nextPage.Count == 0)
            {
                btnNext.Enabled = false;
            }
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {

        }

        // Button that will load the URL into HTML
        // loadHTML() will automatically display the contents into the appropriate text boxes for the status code, title and contents.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            nextPage.Clear();
            btnNext.Enabled = false;

            // We must push the previous page to the prev page stack so we can go back to it if need be.
            prevPage.Push(url);

            // Gets the URL from current contents of the URL text box.
            url = textBoxURL.Text;
            loadHTML(url);
            btnPrev.Enabled = true;
        }
        // Function for loading the HTML code of a website.
        public void loadHTML(string url)
        {
            // Creation of the web request using the passed in URL to initialise.
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                // Tries a response from the web request and stores it as result
                // Stores the contents of the HTML content through reading the entire stream
                HttpWebResponse result = (HttpWebResponse)request.GetResponse();
                Stream stream = result.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string html = reader.ReadToEnd();

                // Sets the textBoxHTML to the html contents of the loaded web page
                // Sets the textBoxStatus to the status code of the loaded web page (200 OK since loaded)
                textBoxStatus.Text = Convert.ToString(result.StatusCode);
                textBoxHTML.Text = html;

                // Regex patternm for finding the title within the HTML contents
                // PageTitle regex group for collecting the content between <title> </title>
                string pattern = @"\<title\b[^>]*\>*(?<PageTitle>[\s\S]*?)\</title\>";
                // trim() since I found an evil website that had white space and new lines in it's title statement
                title = Regex.Match(html, pattern,
                    RegexOptions.IgnoreCase).Groups["PageTitle"].Value.Trim();

                // Sets the textBoxTitle to the title found in the HTML contents
                // Calls write history to record the accessed page.
                textBoxTitle.Text = title;
                writeHistory();

            }
            // Catch exception if the page is unable to be loaded.
            catch (WebException e)
            {
                textBoxHTML.Text = string.Empty;
                textBoxStatus.Text = e.Message;
            }
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
            // https://savanttools.com/test-http-status-codes to test error codes
        }
        // Button on menu strip that will take user to designated home page
        private void editHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prevPage.Push(url);
            url = home;
            loadHTML(url);
            textBoxURL.Text = home;
        }
        // Button in the top bar menu will set the home to the current web page.
        // Doing so in a file stored in the directory bin
        private void editHomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home = url;
            File.WriteAllText(@"home.txt", home);
        }
        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // Sets the textBoxHTML to empty then loads the url back into the loadHTML function
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBoxHTML.Text = "";
            loadHTML(url);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Function for making the list box where the history is stored visible to the user.
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Updates listbox with refreshHistory()
            refreshHistory();
            // Makes the list box visible, along with a button to close it
            listBoxHistory.Visible = true;
            btnHideHistory.Visible = true;
            listBoxBookmarks.Visible = false;
            btnHideBookmarks.Visible = false;

        }

        // Object for allowing for the linked list to be used as a data source with a key and value for the history list box
        public class HistoryItem 
        {
            private string title;
            private string URL;

            public HistoryItem(string Time, string Title, string URL)
            {
                this.title = Time + " " + Title;
                this.URL = URL;
            }
            public string historytitle
            {
                get
                {
                    return this.title;
                }
            }
            public string historyurl
            {
                get
                {
                    return this.URL;
                }
            }
        }
        // Object for allowing for the lionked list to be used as a data source with a key and value for the bookmarks/favourites list box
        public class BookmarkItem
        {
            private string title;
            private string URL;
            public BookmarkItem(string Title, string URL)
            {
                this.title = Title;
                this.URL = URL;
            }
            public string bookmarktitle
            {
                get
                {
                    return this.title;
                }
                set
                {
                    this.title = value;
                }
            }
            public string bookmarkurl
            {
                get
                {
                    return this.URL;
                }
            }
        }

        // Event for loading the currently selected item in the list box into the URL text box so that it can be searched
        private void listBoxHistory_DoubleClick(Object sender, EventArgs e)
        {
            url = listBoxHistory.GetItemText(listBoxHistory.SelectedValue);
            textBoxURL.Text = url;
            // Hides it after.
            listBoxHistory.Visible = false;
            btnHideHistory.Visible = false;
        }

        // Initialises the history and bookmarks list and reads in the stored value for the home page.
        public void loadSettings()
        {
            loadHistory();
            loadBookmarks();
            var homeContents = File.ReadAllText(@"home.txt");
            home = homeContents;
            textBoxURL.Text = home;
            url = home;
        }
        // When History button is pressed, will refresh history so current session visited pages are added to the listbox
        public void refreshHistory()
        {
            listBoxHistory.Refresh();
            listBoxHistory.DataSource = new BindingSource(historyLink, null);
            listBoxHistory.DisplayMember = "historytitle";
            listBoxHistory.ValueMember = "historyurl";
        }
        // Function loads the history
        public void loadHistory()
        {
            // Reads the contents in from the history file
            var historyContents = File.ReadAllLines(@"history.txt");
            // For every 3 lines, adds an object HistoryItem onto an ArrayList historyList
            // 1st line is the time of history page, 2nd line is the title, 3rd line is the URL, all in 1 object HistoryItem for the linked list
            if (historyContents.Length != 0)
            {
                for (int i = 0; i < historyContents.Length; i = i + 3)
                {
                    historyLink.AddLast(new HistoryItem(historyContents[i], historyContents[i + 1], historyContents[i + 2]));
                }
                listBoxHistory.DataSource = new BindingSource(historyLink, null);
                listBoxHistory.DisplayMember = "historytitle";
                listBoxHistory.ValueMember = "historyurl";
            }



        }
        // Function that will write the browser's history to a txt file
        public void writeHistory()
        {
            // Gets the current date and time, then strips the time value so it's just left with the date.
            string time = Convert.ToString(DateTime.Today);
            time = time.Substring(0, 10);

            // Reads all the values from the file.
            var tempContent = File.ReadAllLines(@"history.txt");
            // Array string that will be able to be written into the file by each line for each element
            string[] tempString = { time, title, url };
            // Write the tempString from the browser's current values as that will mean it'll be read in first next time and hence appear top of the history list box
            File.WriteAllLines(@"history.txt", tempString);
            File.AppendAllLines(@"history.txt", tempContent);
            // Adds to the history linked list so it'll add onto the history list box.
            historyLink.AddFirst(new HistoryItem(time, title, url));

        }
        
        private void favouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshBookmarks();
            btnHideBookmarks.Visible = true;
            listBoxBookmarks.Visible = true;
            listBoxHistory.Visible = false;
            btnHideHistory.Visible = false;

        }
        // Redundant code
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //listBoxHistory.Visible = false;
            }
        }

        // Button to hide the history if the user wishes to do nothing
        private void btnHideHistory_Click(object sender, EventArgs e)
        {
            listBoxHistory.Visible = false;
            btnHideHistory.Visible = false;
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hideListBoxes();
        }


        // Function for writing the bookmark to file.
        public void writeBookmark()
        {
            string[] tempString = { title, url };
            File.AppendAllLines(@"bookmarks.txt", tempString);
            bookmarkLink.AddLast(new BookmarkItem(tempString[0], tempString[1]));
        }

        // Button to hide the bookmark tab if the user wishes to do nothing
        private void btnHideBookmarks_Click(object sender, EventArgs e)
        {
            listBoxBookmarks.Visible = false;
            btnHideBookmarks.Visible = false;
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshBookmarks();
        }
        public void refreshBookmarks()
        {
            listBoxBookmarks.Refresh();
            listBoxBookmarks.DataSource = new BindingSource(bookmarkLink, null);
            listBoxBookmarks.DisplayMember = "bookmarkTitle";
            listBoxBookmarks.ValueMember = "bookmarkURL";

            refreshBookmarkTXT();
        }

        // Used to refresh the bookmark storage txt folder for everytime a change is made
        private void refreshBookmarkTXT()
        {
            // Adds the first bookmark index onm it's own so that we can clear the file from previous contents
            // Allowing us just to append to the end of it whenever adding a new bookmark item
            string[] firstBookmark = { bookmarkLink.First.Value.bookmarktitle, bookmarkLink.First.Value.bookmarkurl };
            File.WriteAllLines(@"bookmarks.txt", firstBookmark);

            // Linked list node for iterating through the linked list
            LinkedListNode<BookmarkItem> currentNode = bookmarkLink.First.Next;

            // Reads in every BookmarkItem in the linked list and adds each one seperately to the bookmark.txt file
            for (int i = 0; i < bookmarkLink.Count-1; i++)
            {
                string[] newBookmarkLine = { currentNode.Value.bookmarktitle, currentNode.Value.bookmarkurl };
                File.AppendAllLines(@"bookmarks.txt", newBookmarkLine);
                currentNode = currentNode.Next;
            }
        }
        // Loads the bookmarks from the file located in the bin
        public void loadBookmarks()
        {
            // Reads all the lines from the bookmarks
            var bookmarkContents = File.ReadAllLines(@"bookmarks.txt");
            // Reads the contents into the listBoxBookmarks object if there is content present
            if(bookmarkContents.Length != 0)
            {
                // Loop that iterates by 2 as we read 2 lines at a time
                // first index is for the web page title
                // second index is for the web page url
                // combined in the listBoxBookmarks to show the title whilst having the URL as it's value underneath
                for(int i = 0; i < bookmarkContents.Length; i = i + 2)
                {
                    bookmarkLink.AddLast(new BookmarkItem(bookmarkContents[i], bookmarkContents[i + 1]));
                }
                listBoxBookmarks.DataSource = new BindingSource(bookmarkLink, null);
                listBoxBookmarks.DisplayMember = "bookmarkTitle";
                listBoxBookmarks.ValueMember = "bookmarkURL";
            }
            // Very first bookmark will be the home page
            else
            {
                bookmarkLink.AddLast(new BookmarkItem(title, url));
            }
        }
        private void listBoxBookmarks_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void listBoxBookmarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            contextMenuStripBookmark.Show(listBoxBookmarks, new Point(250, listBoxBookmarks.Top+50));
        }

        // Function that will take the currently selected item in the listBox and load it into the URL text box
        // Hides the associated objects after.
        private void listBoxBookmarks_DoubleClick(object sender, EventArgs e)
        {
            url = listBoxBookmarks.GetItemText(listBoxBookmarks.SelectedValue);
            textBoxURL.Text = url;
            listBoxBookmarks.Visible = false;
            btnHideBookmarks.Visible = false;
            contextMenuStripBookmark.Visible = false;
        }

        // Rename bookmark option
        // Gets user to input their value into a dialog box and searches it through the linked list and chagnes its value
        private void renameBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates a dialog box for the user to input a new value for the bookmark
            string promptValue = DialogBox.ShowDialog("Provide a new title for the bookmark:", "Rename bookmark");

            // Creates an instance of the first node in the linked list
            // index for storing the current index selected in the bookmarks
            LinkedListNode<BookmarkItem> currentNode = bookmarkLink.First;
            int index = listBoxBookmarks.SelectedIndex;

            // if statement to make sure we've not been given an empty value from the user
            // Message box to notify user if so
            if(promptValue == "")
            {
                MessageBox.Show("Empty value given");
            }
            // Otherwise proceeds
            else
            {
                // For all the linked nodes present, iterates through the linked list,
                // until we get to the node we wish to rename the title for in the linked list
                for (int i = 0; i < bookmarkLink.Count; i++)
                {
                    if (index == i)
                    {
                        bookmarkLink.Find(currentNode.Value).Value.bookmarktitle = promptValue;
                    }
                    currentNode = currentNode.Next;
                }
            }

            // Refreshes the bookmark tab, showing the newly renamed bookmark title in the list.
            refreshBookmarks();
        }
        // Delete bookmark option
        private void deleteBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates an instance of the first node in the linked list
            // index for storing the current index selected in the bookmarks
            LinkedListNode<BookmarkItem> currentNode = bookmarkLink.First;
            int index = listBoxBookmarks.SelectedIndex;


            for (int i = 0; i < bookmarkLink.Count; i++)
            {
                if (index == i)
                {
                    bookmarkLink.Remove(currentNode);
                    currentNode = bookmarkLink.First;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
                
            }

            // Refreshes the bookmark tab, showing the deleted bookmark not in the list
            refreshBookmarks();
        }

        // General function that will hide the history and bookmark tabs.
        private void hideListBoxes()
        {
            listBoxBookmarks.Visible = false;
            listBoxHistory.Visible = false;
            btnHideBookmarks.Visible = false;
            btnHideHistory.Visible = false;
        }
        // Button for initiating a bulk downlaod through the given bulk.txt file
        private void bulkDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        // Extra HTML handling function designed for the bulk download, different as it returns a string array,
        private string[] retrieveHTML(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                HttpWebResponse result = (HttpWebResponse)request.GetResponse();
                Stream stream = result.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                // returns both the HTTP status message and the html contents through 1 array of stirngs
                string[] html = { Convert.ToString(result.StatusCode), reader.ReadToEnd() };
                return html;
            }
            // Catch branch that will allow for web pages unable to load to be recorded.
            catch (WebException e)
            {
                // If statements to record the appropriate code for whatever status code it ends up being
                if (e.Message.Contains("403"))
                {
                    string[] html = { "403", string.Empty };
                    return html;
                }
                else if (e.Message.Contains("404")) 
                {
                    string[] html = { "404", string.Empty };
                    return html;
                }
                else
                {
                    string[] html = {e.Message, string.Empty };
                    return html;
                }
                
            }
            
        }

        private void btnHideBookmarks_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStripBookmark_Opening(object sender, CancelEventArgs e)
        {

        }

        private void bulkDownloadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Hides bookmark and history tabs if they're both open
            hideListBoxes();
            // Puts column headers at the top of the HTML text box
            textBoxHTML.Text = "<code>    <size>         <url>";
            textBoxHTML.AppendText(Environment.NewLine);

            // Reads in the URL contents from the bulk.txt file
            string[] bulkContent = File.ReadAllLines(@"bulk.txt");

            // For every line in the bulk.txt file
            for (int i = 0; i < bulkContent.Length; i++)
            {
                // Retrives the HTML code and the status code from the retrieveHTML url
                string[] htmlContent = retrieveHTML(bulkContent[i]);
                // Writes the HTML code to a file so that we can see how large the contents are
                File.WriteAllText(@"bulktest.txt", htmlContent[1]);

                // Captures the size of the file
                // bulkLine concatenates all of the contents required for a line output of <code> <size> <url>
                long fileSize = new FileInfo(@"bulktest.txt").Length;
                string bulkLine = (htmlContent[0] + "         " + Convert.ToString(fileSize) + " bytes       " + bulkContent[i]);

                // Writes the contents of the loaded file into the HTML text box and adds a new line for the new bulk line.
                textBoxHTML.AppendText(bulkLine);
                textBoxHTML.AppendText(Environment.NewLine);
            }
        }

        private void bookmarkPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            writeBookmark();
            refreshBookmarks();
            MessageBox.Show("Web page: " + title + " BOOKMARKED!", "Bookmark confirmation");
            contextMenuStripBookmark.Visible = false;
        }
    }
    // Dialog box form creation that will create a prompt during rename to ask the user to enter
    // a new value for the selected bookmark's title
    public static class DialogBox
    {
        public static string ShowDialog(string text, string caption)
        {
            // Initialises form properties 
            Form prompt = new Form()
            {
                Width = 400,
                Height = 125,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent
            };
            // textLabel to tell user purpose of prompt
            // textBox to input new title
            Label textLabel = new Label() { Left = 25, Top = 10, Text = text };
            TextBox textBox = new TextBox() { Left = 25, Top = 30, Width = 300 };
            Button confirmation = new Button() { Text = "Ok", Left = 225, Width = 100, Top = 60, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            // Adds all the controls to the prompt box
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
