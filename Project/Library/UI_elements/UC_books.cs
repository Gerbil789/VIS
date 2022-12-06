using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataLayer.DataStructures;

namespace PresentationLayer.UI_elements
{
    public partial class UC_books : UserControl
    {
        public UC_books()
        {
            InitializeComponent();
            flowLayoutPanel_books.Controls.Clear();
            panel_details.Visible = false;
        }

        public void ShowBooks(List<Book> books)
        {
            flowLayoutPanel_books.Controls.Clear();
            foreach (Book book in books)
            {
                BookUI item = new BookUI(book);
                flowLayoutPanel_books.Controls.Add(item);
                //item.MouseEnter += new EventHandler(OnMouseEnter);
                //item.MouseLeave += new EventHandler(OnMouseLeave);
                item.Click += new EventHandler(On_Click);
            }
        }


        //show book description
        void OnMouseEnter(object sender, EventArgs e)
        {
            BookUI obj = (BookUI)sender;
            label_details.Text = obj.book.description;
            panel_details.Visible = true;
        }

        //hide book description
        void OnMouseLeave(object sender, EventArgs e)
        {
            label_details.Text = "";
            panel_details.Visible = false;
        }

        void On_Click(object sender, EventArgs e)
        {
            BookUI obj = (BookUI)sender;
            label_details.Text = obj.book.description;
            panel_details.Visible = true;

        }




    }
}
