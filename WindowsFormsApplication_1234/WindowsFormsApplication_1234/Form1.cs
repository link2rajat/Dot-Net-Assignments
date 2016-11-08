using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_1234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadEvent(object sender, EventArgs e)
        {
            // Entity Framework DBContext
            BooksEntities dbcontext =
               new BooksEntities();

            // get authors and ISBNs of each book they co-authored
            var authorsAndISBNs =
               from author in dbcontext.Authors
               from book in author.Titles
               orderby author.LastName, author.FirstName
               select new { author.FirstName, author.LastName, book.ISBN };

            outputTextBox.AppendText("Authors and ISBNs:");

            // display authors and ISBNs in tabular format
            foreach (var element in authorsAndISBNs)
            {
                outputTextBox.AppendText(
                   String.Format("\r\n\t{0,-10} {1,-10} {2,-10}",
                      element.FirstName, element.LastName, element.ISBN));
            } // end foreach

            // get authors and titles of each book they co-authored
            var authorsAndTitles =
               from book in dbcontext.Titles
               from author in book.Authors
               orderby author.LastName, author.FirstName, book.Title1
               select new
               {
                   author.FirstName,
                   author.LastName,
                   book.Title1
               };

            outputTextBox.AppendText("\r\n\r\nAuthors and titles:");

            // display authors and titles in tabular format
            foreach (var element in authorsAndTitles)
            {
                outputTextBox.AppendText(
                   String.Format("\r\n\t{0,-10} {1,-10} {2}",
                      element.FirstName, element.LastName, element.Title1));
            } // end foreach

            // get authors and titles of each book 
            // they co-authored; group by author
            var titlesByAuthor =
               from author in dbcontext.Authors
               orderby author.LastName, author.FirstName
               select new
               {
                   Name = author.FirstName + " " + author.LastName,
                   Titles =
                     from book in author.Titles
                     orderby book.Title1
                     select book.Title1
               };

            outputTextBox.AppendText("\r\n\r\nTitles grouped by author:");

            // display titles written by each author, grouped by author
            foreach (var author in titlesByAuthor)
            {
                // display author's name
                outputTextBox.AppendText("\r\n\t" + author.Name + ":");

                // display titles written by that author
                foreach (var title in author.Titles)
                {
                    outputTextBox.AppendText("\r\n\t\t" + title);
                } // end inner foreach
            } // end outer foreach

            //1. Get authors and titles and order by title
            var TitlesOrdered =
            from book in dbcontext.Titles
            from author in book.Authors
            orderby book.Title1
            select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("\r\n\r\nTitles Ordered:");

            // display authors and titles in tabular format
            foreach (var element in TitlesOrdered)
            {
                outputTextBox.AppendText(
                String.Format("\r\n\t{0,-10}\t {1,10} {2}",
                         element.Title1, element.FirstName, element.LastName));
            } // end foreach

            //2. Get authors and titles and order by title, author name
            var authorsAndTitlesOrdered =
            from book in dbcontext.Titles
            from author in book.Authors
            orderby book.Title1, author.LastName, author.FirstName
            select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("\r\n\r\nTitles and Authors Ordered:");

            // display authors and titles in tabular format
            foreach (var element in authorsAndTitlesOrdered)
            {
                outputTextBox.AppendText(
                String.Format("\r\n\t{0,-10}\t {1,10} {2}",
                         element.Title1, element.FirstName, element.LastName));
            } // end foreach
              // 3. get authors and titles of each book 
              //  group by titles, order by titles, author
            var authorsByTitleOrdered =
             from book in dbcontext.Titles
             orderby book.Title1
             select new
             {
                 Name = book.Title1,
                 Authors =
                    from author in book.Authors
                    orderby author.LastName, author.FirstName
                    select new { author.LastName, author.FirstName }
             };
            outputTextBox.AppendText("\r\n\r\nTitles grouped by author:");

            // to display titles written by each author, grouped by author
            foreach (var title in authorsByTitleOrdered)
            {
                // display author's name
                outputTextBox.AppendText("\r\n" + title.Name + ":");

                // display titles written by that author
                foreach (var author in title.Authors)
                {
                    outputTextBox.AppendText("\r\n\t\t" + author.FirstName + " " + author.LastName);
                } // end inner foreach
            } // end outer foreach



        }
    }
}
