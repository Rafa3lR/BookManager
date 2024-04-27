using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookManager._1_Modulo1
{
    internal class SaveInTXT
    {
        public static void ReadTXT()
        {
            int max = Main.id.Count();
            for (int i = 0; i < max; i++)
            {
                Main.id.RemoveAt(0);
                Main.title.RemoveAt(0);
                Main.author.RemoveAt(0);
                Main.pubDate.RemoveAt(0);
                Main.situation.RemoveAt(0);
            }

            StreamWriter ID1 = new StreamWriter("id.txt", true);
            ID1.Close();
            using (StreamReader sr = new StreamReader("id.txt"))
            {
                string ID;
                while ((ID = sr.ReadLine()) != null)
                {
                    Main.id.Add(Convert.ToInt32(ID));
                }
            }
            StreamWriter bookTitle1 = new StreamWriter("BookTitle.txt", true);
            bookTitle1.Close();
            using (StreamReader sr = new StreamReader("BookTitle.txt"))
            {
                string bookTitle;
                while ((bookTitle = sr.ReadLine()) != null)
                {
                    Main.title.Add(bookTitle);
                }
            }
            StreamWriter author1 = new StreamWriter("Author.txt", true);
            author1.Close();
            using (StreamReader sr = new StreamReader("Author.txt"))
            {
                string author;
                while ((author = sr.ReadLine()) != null)
                {
                    Main.author.Add(author);
                }
            }
            StreamWriter pubDate1 = new StreamWriter("PubDate.txt", true);
            pubDate1.Close();
            using (StreamReader sr = new StreamReader("PubDate.txt"))
            {
                string pubDate;
                while ((pubDate = sr.ReadLine()) != null)
                {
                    Main.pubDate.Add(Convert.ToDateTime(pubDate));
                }
            }
            StreamWriter situation1 = new StreamWriter("Situation.txt", true);
            situation1.Close();
            using (StreamReader sr = new StreamReader("Situation.txt"))
            {
                string situation;
                while ((situation = sr.ReadLine()) != null)
                {
                    Main.situation.Add(situation);
                }
            }
            StreamWriter quantBooksCreated1 = new StreamWriter("QuantBooksCreated.txt", true);
            quantBooksCreated1.Close();
            using (StreamReader sr = new StreamReader("QuantBooksCreated.txt"))
            {
                string quantBooksCreated;
                while ((quantBooksCreated = sr.ReadLine()) != null)
                {
                    Main.quantBooksCreated = Convert.ToInt32(quantBooksCreated);
                }
            }
            
            max = Main.id.Count();
            for (int i = 0; i < max; i++)
            {
                Tdata aux = new Tdata();
                aux.id = Main.id[i];
                aux.bookTitle = Main.title[i];
                aux.author = Main.author[i];
                aux.pubDate = Main.pubDate[i];
                Main.tree.root = Main.tree.insert(Main.tree.root, aux);
            }
        }

        public static void WriteTXT()
        {
            StreamWriter id = new StreamWriter("id.txt", false);
            id.Close();
            StreamWriter bookTitle = new StreamWriter("BookTitle.txt", false);
            bookTitle.Close();
            StreamWriter author = new StreamWriter("Author.txt", false);
            author.Close();
            StreamWriter pubDate = new StreamWriter("PubDate.txt", false);
            pubDate.Close();
            StreamWriter situation = new StreamWriter("Situation.txt", false);
            situation.Close();

            using (StreamWriter sw = new StreamWriter("QuantBooksCreated.txt", false))
            {
                sw.Write(Main.quantBooksCreated);
            }

            int max = Main.id.Count();
            for (int i = 0; i < max; i++)
            {
                using (StreamWriter sw = new StreamWriter("id.txt", true))
                {
                    sw.WriteLine(Main.id[i]);
                }
                using (StreamWriter sw = new StreamWriter("BookTitle.txt", true))
                {
                    sw.WriteLine(Main.title[i]);
                }
                using (StreamWriter sw = new StreamWriter("Author.txt", true))
                {
                    sw.WriteLine(Main.author[i]);
                }
                using (StreamWriter sw = new StreamWriter("PubDate.txt", true))
                {
                    sw.WriteLine(Main.pubDate[i]);
                }
                using (StreamWriter sw = new StreamWriter("Situation.txt", true))
                {
                    sw.WriteLine(Main.situation[i]);
                }
            }
        }
    }
}
