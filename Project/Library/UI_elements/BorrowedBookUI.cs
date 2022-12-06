using DataLayer;
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

namespace PresentationLayer.UI_elements
{
    public partial class BorrowedBookUI : UserControl
    {
        public Book book = new Book();
        CustomerUI selected_customer;
        public BorrowedBookUI(Book book, CustomerUI selected_customer)
        {
            this.selected_customer = selected_customer;
            this.book = book;
            InitializeComponent();
            label_borrowed_book_id.Text = $"[{book.id.ToString()}]";
            label_borrowed_book_title.Text = book.title;
            label_return_date.Text = $"Return date: {book.return_date?.ToString("dd.MM.yyyy")}";
            label_return_date.ForeColor = DateTime.Now > book.return_date ? Color.Red : Color.Black;
        }

        public void button_return_book_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerMapper.GetCustomer((int)book.customer_id);
            customer.Return(book);
            BookMapper.ReturnBook(book);
            FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)this.Parent;
            DataLogger.LogData($"book[{book.id}] returned");
            flowLayoutPanel.Controls.Remove(this);
            selected_customer.UpdateBooksCount();
        }
    }
}
