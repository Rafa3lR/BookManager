using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookManager._1_Modulo1
{
    public partial class CadBooks : Form
    {
        public CadBooks()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (Main.openEdit)
            {
                case 0:
                    try
                    {
                        {
                            PopulatingLists();
                            int index = Main.id.Count() - 1;
                            DrawingNewBook(index);
                            Tdata aux = CreatingTreeAuxData();
                            InsertingAVLTree(aux);
                            SavingAndUpdatingDateFilters();
                            Main.quantBooksCreated++;
                            this.Close();
                            
                        }
                    } catch { }
                    break;

                default:
                    try
                    {
                        UpdatingBook();
                    } catch { }
                    
                    break;
            }
        }

        private static void DrawingNewBook(int index)
        {
            Main.books.Add(new Books());
            Main.books[index].ID = Main.id[index];
            Main.books[index].BookTitle = Main.title[index];
            Main.books[index].AuthorName = Main.author[index];
            Main.books[index].PubDate = Main.pubDate[index];
            Main.books[index].Index = index;
            DefiningBackColor();
            Main.books[index].BTNbooks = ColorTranslator.FromHtml(Main.situation[index]);
            Main.flowPanelBooks.Controls.Add(Main.books[index]);
        }

        private static void DefiningBackColor()
        {
            if (cbSituation.Text == "I want to read")
            {
                Main.situation.Add("DeepSkyBlue");
            }
            else if (cbSituation.Text == "Reading")
            {
                Main.situation.Add("Yellow");
            }
            else if (cbSituation.Text == "I've already read it")
            {
                Main.situation.Add("LawnGreen");
            }
            else if (cbSituation.Text == "Rereading")
            {
                Main.situation.Add("Orange");
            }
            else if (cbSituation.Text == "I've abandoned it")
            {
                Main.situation.Add("DimGray");
            }
        }

        private static void UpdatingBackColor()
        {
            if (cbSituation.Text == "I want to read")
            {
                Main.situation[Books.index] = "DeepSkyBlue";
            }
            else if (cbSituation.Text == "Reading")
            {
                Main.situation[Books.index] = "Yellow";
            }
            else if (cbSituation.Text == "I've already read it")
            {
                Main.situation[Books.index] = "LawnGreen";
            }
            else if (cbSituation.Text == "Rereading")
            {
                Main.situation[Books.index] = "Orange";
            }
            else if (cbSituation.Text == "I've abandoned it")
            {
                Main.situation[Books.index] = "DimGray";
            }
        }

        private void UpdatingBook()
        {
            Main.title[Books.index] = tbBookTitle.Text;
            Main.author[Books.index] = tbAuthor.Text;
            Main.pubDate[Books.index] = dateTimePubDate.Value;
            UpdatingBackColor();
            Main.books[Books.index].BTNbooks = ColorTranslator.FromHtml(Main.situation[Books.index]);
            SaveInTXT.WriteTXT();
            SaveInTXT.ReadTXT();
            Main.openEdit = 0;
            Main.flowPanelBooks.Controls.Remove(Main.books[Books.index]);
            Main.flowPanelBooks.Controls.Add(Main.books[Books.index]);
            this.Close();
        }

        private static void SavingAndUpdatingDateFilters()
        {
            SaveInTXT.WriteTXT();
            Main.dateTimePickerMin.Value = Main.pubDate.Min();
            Main.dateTimePickerMax.Value = Main.pubDate.Max();
        }

        private static void InsertingAVLTree(Tdata aux)
        {
            Main.tree.root = Main.tree.insert(Main.tree.root, aux);
        }

        private Tdata CreatingTreeAuxData()
        {
            Tdata aux = new Tdata();
            aux.id = Main.quantBooksCreated;
            aux.bookTitle = tbBookTitle.Text;
            aux.author = tbAuthor.Text;
            aux.pubDate = dateTimePubDate.Value;
            return aux;
        }

        private void PopulatingLists()
        {
            Main.id.Add(Main.quantBooksCreated);
            Main.title.Add(tbBookTitle.Text);
            Main.author.Add(tbAuthor.Text);
            Main.pubDate.Add(dateTimePubDate.Value);
        }

        private void CadBooks_Load(object sender, EventArgs e)
        {
            dateTimePubDate.Value = DateTime.Today;
            switch (Main.openEdit)
            {
                case 0:
                    btnDelete.Hide();
                    cbSituation.Text = "I want to read";
                    break;
                default:
                    tbBookTitle.Text = Main.title[Books.index].ToString();
                    tbAuthor.Text = Main.author[Books.index].ToString();
                    dateTimePubDate.Value = Main.pubDate[Books.index];
                    SettingCbSituation();
                    break;
            }
        }

        private static void SettingCbSituation()
        {
            if (Main.situation[Books.index] == "DeepSkyBlue")
            {
                cbSituation.Text = "I want to read";
            }
            else if (Main.situation[Books.index] == "Yellow")
            {
                cbSituation.Text = "Reading";
            }
            else if (Main.situation[Books.index] == "LawnGreen")
            {
                cbSituation.Text = "I've already read it";
            }
            else if (Main.situation[Books.index] == "Orange")
            {
                cbSituation.Text = "Rereading";
            }
            else if (Main.situation[Books.index] == "DimGray")
            {
                cbSituation.Text = "I've abandoned it";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = ConfirmationMessage();

            if (delete == DialogResult.OK)
            {
                DeleteAVLTree();
                DeleteList();
                //Main.flowPanelBooks.Controls.Remove(Main.books[Books.index]);
                Main.books.RemoveAt(Books.index);
                SavingAndUpdatingDateFilter();
                Main.FilterAndDrawBooks();
                this.Close();
            }
        }

        private static void SavingAndUpdatingDateFilter()
        {
            SaveInTXT.WriteTXT();
            Main.openEdit = 0;
            switch (Main.id.Count())
            {
                case > 0:
                    Main.dateTimePickerMin.Value = Main.pubDate.Min();
                    Main.dateTimePickerMax.Value = Main.pubDate.Max();
                    break;
                default:
                    Main.dateTimePickerMin.Value = DateTime.Today;
                    Main.dateTimePickerMax.Value = DateTime.Today;
                    break;
            }
        }

        private static void DeleteList()
        {
            Main.id.RemoveAt(Books.index);
            Main.title.RemoveAt(Books.index);
            Main.author.RemoveAt(Books.index);
            Main.pubDate.RemoveAt(Books.index);
            Main.situation.RemoveAt(Books.index);
        }

        private static void DeleteAVLTree()
        {
            Main.tree.root = Main.tree.deleteNode(Main.tree.root, Main.id[Books.index]);
        }

        private static DialogResult ConfirmationMessage()
        {
            return MessageBox.Show("Are you sure?", "Delete Book",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        private void CadBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.openEdit = 0;
        }

        private void CadBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
