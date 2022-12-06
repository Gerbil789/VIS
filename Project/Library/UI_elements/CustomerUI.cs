using LogicLayer;
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
using static System.Reflection.Metadata.BlobBuilder;

namespace PresentationLayer
{
    public partial class CustomerUI : UserControl
    {
        public Customer customer = new Customer();
        public CustomerUI(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            this.BackColor = Color.White;
            this.MouseEnter += new EventHandler(OnMouseEnter);
            this.MouseLeave += new EventHandler(OnMouseExit);

            label_past_return_date_count.Visible = false;
            label_borrowed_books_count.Visible = false;

            label_name.Text = customer.first_name + " " + customer.last_name;
            label_borrowed_books_count.Text = "Borrowed books: " + customer.books.Count;
            if(customer.books.Count > 0)
            {
                label_borrowed_books_count.Text = $"[{customer.books.Count}]";
                label_borrowed_books_count.Visible = true;
            }
            
        }

        public void UpdateBooksCount()
        {
            if (customer.books.Count > 0)
            {
                label_borrowed_books_count.Text = $"[{customer.books.Count}]";
                label_borrowed_books_count.Visible = true;
            }
            else
            {
                label_borrowed_books_count.Visible = false;
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
