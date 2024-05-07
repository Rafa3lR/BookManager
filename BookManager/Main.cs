using System;
using System.Reflection;
using System.Xml.Linq;

namespace BookManager._1_Modulo1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SaveInTXT.ReadTXT();
            UpdatingDateFilters();
            cbSituationFilter.Text = "All";
            FilterAndDrawBooks();
        }

        private static void UpdatingDateFilters()
        {
            switch (id.Count())
            {
                case > 0:
                    dateTimePickerMin.Value = pubDate.Min();
                    dateTimePickerMax.Value = pubDate.Max();
                    break;
                default:
                    dateTimePickerMin.Value = DateTime.Today;
                    dateTimePickerMax.Value = DateTime.Today;
                    break;
            }
        }

        public static int quantBooksCreated = 1, openEdit = 0;
        public static List<string> title = new List<string>();
        public static List<string> author = new List<string>();
        public static List<int> id = new List<int>();
        public static List<string> situation = new List<string>();
        public static List<DateTime> pubDate = new List<DateTime>();
        public static List<Books> books = new List<Books>();
        public static AVLTree tree = new AVLTree();

        public static void FilterAndDrawBooks()
        {
            SaveInTXT.ReadTXT();
            flowPanelBooks.Controls.Clear();
            if (tbID.Text != "Search ID")
            {
                try
                {
                    cbSituationFilter.Text = "All";
                    Node foundNode;
                    SearchingAVLTree(out foundNode);
                    BookFound(foundNode);
                    flowPanelBooks.Controls.Add(books[0]);
                }
                catch { }
            }
            else
            {
                //Title, Author and ID Filters
                for (int i = 0; i < id.Count(); i++)
                {
                    if (cbSituationFilter.Text == "All")
                    {
                        TextBoxFilters(i);
                    }
                    else if (cbSituationFilter.Text == "I want to read")
                    {
                        if (situation[i] == "DeepSkyBlue")
                        {
                            TextBoxFilters(i);
                        }
                    }
                    else if (cbSituationFilter.Text == "Reading")
                    {
                        if (situation[i] == "Yellow")
                        {
                            TextBoxFilters(i);
                        }
                    }
                    else if (cbSituationFilter.Text == "I've already read it")
                    {
                        if (situation[i] == "LawnGreen")
                        {
                            TextBoxFilters(i);
                        }
                    }
                    else if (cbSituationFilter.Text == "Rereading")
                    {
                        if (situation[i] == "Orange")
                        {
                            TextBoxFilters(i);
                        }
                    }
                    else if (cbSituationFilter.Text == "I've abandoned it")
                    {
                        if (situation[i] == "DimGray")
                        {
                            TextBoxFilters(i);
                        }
                    }
                }
            }
        }

        private static void TextBoxFilters(int i)
        {
            if (tbID.Text == "Search ID" && tbTitle.Text == "Search Title" && tbAuthor.Text == "Search Author")
            {
                if (pubDate[i] >= dateTimePickerMin.Value && pubDate[i] <= dateTimePickerMax.Value)
                {
                    PopulateBooks(i);
                }
            }
            else if (tbTitle.Text != "" && tbAuthor.Text == "Search Author")
            {
                if (pubDate[i] >= dateTimePickerMin.Value && pubDate[i] <= dateTimePickerMax.Value && title[i].ToLower().StartsWith(tbTitle.Text.ToLower()))
                {
                    PopulateBooks(i);
                }
            }
            else if (tbAuthor.Text != "" && tbTitle.Text == "Search Title")
            {
                if (pubDate[i] >= dateTimePickerMin.Value && pubDate[i] <= dateTimePickerMax.Value && author[i].ToLower().StartsWith(tbAuthor.Text.ToLower()))
                {
                    PopulateBooks(i);
                }
            }
            else if (tbTitle.Text != "" && tbAuthor.Text != "")
            {
                if (pubDate[i] >= dateTimePickerMin.Value && pubDate[i] <= dateTimePickerMax.Value && title[i].ToLower().StartsWith(tbTitle.Text.ToLower()) && author[i].ToLower().StartsWith(tbAuthor.Text.ToLower()))
                {
                    PopulateBooks(i);
                }
            }
        }

        private static void BookFound(Node foundNode)
        {
            books.Add(new Books());
            books[0].ID = foundNode.data.id;
            books[0].BookTitle = foundNode.data.bookTitle;
            books[0].AuthorName = foundNode.data.author;
            books[0].PubDate = foundNode.data.pubDate;
        }

        private static void SearchingAVLTree(out Node foundNode)
        {
            foundNode = tree.Search(tree.root, Convert.ToInt32(tbID.Text));
        }

        public static void PopulateBooks(int i)
        {
            books.Add(new Books());

            books[i].ID = id[i];
            books[i].BookTitle = title[i];
            books[i].AuthorName = author[i];
            books[i].PubDate = pubDate[i];
            books[i].BTNbooks = Color.FromName(situation[i]);

            flowPanelBooks.Controls.Add(books[i]);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            CadBooks books = new CadBooks();
            books.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FilterAndDrawBooks();
        }

        private void tbID_Enter(object sender, EventArgs e)
        {
            if (tbID.Text == "Search ID")
            {
                tbID.Text = "";
                tbID.ForeColor = Color.Black;
                tbTitle.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbTitle.Text = "Search Title";
                tbAuthor.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbAuthor.Text = "Search Author";
            }
        }

        private void tbID_Leave(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                tbID.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbID.Text = "Search ID";
            }
        }

        private void tbTitle_Enter(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Search Title")
            {
                tbTitle.Text = "";
                tbTitle.ForeColor = Color.Black;
                tbID.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbID.Text = "Search ID";
            }
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                tbTitle.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbTitle.Text = "Search Title";
            }
        }

        private void tbAuthor_Enter(object sender, EventArgs e)
        {
            if (tbAuthor.Text == "Search Author")
            {
                tbAuthor.Text = "";
                tbAuthor.ForeColor = Color.Black;
                tbID.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbID.Text = "Search ID";
            }
        }

        private void tbAuthor_Leave(object sender, EventArgs e)
        {
            if (tbAuthor.Text == "")
            {
                tbAuthor.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbAuthor.Text = "Search Author";
            }
        }

        private void tbID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbID.Text == "")
                {
                    tbID.ForeColor = Color.FromArgb(100, 114, 114, 114);
                    tbID.Text = "Search ID";
                }
                FilterAndDrawBooks();
            }
        }

        private void tbTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbTitle.Text == "")
                {
                    tbTitle.ForeColor = Color.FromArgb(100, 114, 114, 114);
                    tbTitle.Text = "Search Title";
                }
                FilterAndDrawBooks();
            }
        }

        private void tbAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbAuthor.Text == "")
                {
                    tbAuthor.ForeColor = Color.FromArgb(100, 114, 114, 114);
                    tbAuthor.Text = "Search Author";
                }
                FilterAndDrawBooks();
            }
        }

        private void dateTimePickerMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterAndDrawBooks();
            }
        }

        private void dateTimePickerMax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterAndDrawBooks();
            }
        }

        private void cbSituationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAndDrawBooks();
        }
    }
}
