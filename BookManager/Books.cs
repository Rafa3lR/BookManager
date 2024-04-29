using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager._1_Modulo1
{
    public partial class Books : UserControl
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            TransparentBackgroundText();
        }

        private void TransparentBackgroundText()
        {
            lblBookTitle.Parent = btnBooks;
            lblBookTitle.BackColor = Color.Transparent;
            lblAuthorName.Parent = btnBooks;
            lblAuthorName.BackColor = Color.Transparent;
            lblID.Parent = btnBooks;
            lblID.BackColor = Color.Transparent;
            lblPubDate.Parent = btnBooks;
            lblPubDate.BackColor = Color.Transparent;
            btnBooks.Parent = panel1;
        }

        public static int index;

        private void btnBooks_Click(object sender, EventArgs e)
        {
            index = Main.id.IndexOf(Convert.ToInt32(lblID.Text));
            Main.openEdit = 1;
            CadBooks books = new CadBooks();
            books.Show();
        }

        private void lblBookTitle_MouseMove(object sender, MouseEventArgs e)
        {
            btnBooks.BackColor = Color.FromArgb(100, 50, 50, 50);
        }

        private void lblBookTitle_MouseLeave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.Transparent;
        }

        private void lblBookTitle_Click(object sender, EventArgs e)
        {
            index = Main.id.IndexOf(Convert.ToInt32(lblID.Text));
            Main.openEdit = 1;
            CadBooks books = new CadBooks();
            books.Show();
        }

        private void lblAuthorName_MouseMove(object sender, MouseEventArgs e)
        {
            btnBooks.BackColor = Color.FromArgb(100, 50, 50, 50);
        }

        private void lblAuthorName_MouseLeave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.Transparent;
        }

        private void lblAuthorName_Click(object sender, EventArgs e)
        {
            index = Main.id.IndexOf(Convert.ToInt32(lblID.Text));
            Main.openEdit = 1;
            CadBooks books = new CadBooks();
            books.Show();
        }

        private void lblID_MouseMove(object sender, MouseEventArgs e)
        {
            btnBooks.BackColor = Color.FromArgb(100, 50, 50, 50);
        }

        private void lblID_MouseLeave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.Transparent;
        }

        private void lblID_Click(object sender, EventArgs e)
        {
            index = Main.id.IndexOf(Convert.ToInt32(lblID.Text));
            Main.openEdit = 1;
            CadBooks books = new CadBooks();
            books.Show();
        }

        private void lblPubDate_MouseMove(object sender, MouseEventArgs e)
        {
            btnBooks.BackColor = Color.FromArgb(100, 50, 50, 50);
        }

        private void lblPubDate_MouseLeave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.Transparent;
        }

        private void lblPubDate_Click(object sender, EventArgs e)
        {
            index = Main.id.IndexOf(Convert.ToInt32(lblID.Text));
            Main.openEdit = 1;
            CadBooks books = new CadBooks();
            books.Show();
        }

        public string BookTitle
        {
            set { lblBookTitle.Text = value; }
        }

        public string AuthorName
        {
            set { lblAuthorName.Text = value; }
        }

        public int ID
        {
            set { lblID.Text = value.ToString(); }
        }

        public DateTime PubDate
        {
            set { lblPubDate.Text = value.ToString(); }
        }

        public Color BTNbooks
        {
            set { panel1.BackColor = value; }
        }
    }
}
