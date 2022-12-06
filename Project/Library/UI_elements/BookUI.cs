using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataLayer.DataStructures;

namespace PresentationLayer
{
    public partial class BookUI : UserControl
    {
        public Book book = new Book();
        public BookUI(Book book)
        {
            InitializeComponent();
            this.MouseEnter += new EventHandler(OnMouseEnter);
            this.MouseLeave += new EventHandler(OnMouseExit);
            this.book = book;
            label_id.Text = "[" + book.id.ToString() + "]";
            label_title.Text = book.title;
            label_author.Text = book.author;
            label_genre.Text = book.genre;
            label_language.Text = book.language;
            if (book.borrowed)
            {
                DateTime date = DateTime.Today;
                if (book.return_date != null)
                {
                    date = (DateTime)book.return_date;
                }
                label_borrowed.Text = "Borrowed - Return date: " + date.ToString("dd.MM.yyyy");
            }
            else
            {
                label_borrowed.Text = "Available";
            }

            
        }
   

        void OnMouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        void OnMouseExit(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
