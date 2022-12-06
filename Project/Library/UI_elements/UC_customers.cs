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
    public partial class UC_customers : UserControl
    {
        public CustomerUI selected_customer;
        public UC_customers()
        {
            InitializeComponent();
            flowLayoutPanel_customers.Controls.Clear();
            panel_customer_info.Visible = false;
            panel_borrow_book.Visible = false;
        }

        public void ShowCustomers(List<Customer> customers)
        {
            flowLayoutPanel_customers.Controls.Clear();
            foreach (Customer customer in customers)
            {
                CustomerUI item = new CustomerUI(customer);
                flowLayoutPanel_customers.Controls.Add(item);
                item.Click += new EventHandler(On_Click); 
            }
        }

        void On_Click(object sender, EventArgs e)
        {
            CustomerUI obj = (CustomerUI)sender;
            selected_customer = obj;
            SelectCustomer(obj.customer);
        }

        public void SelectCustomer(Customer customer)
        {
            flowLayoutPanel_borrowed_books.Controls.Clear();
            label_name.Text = customer.first_name + " " + customer.last_name;
            label_email.Text = customer.email;
            label_phone.Text = customer.phone;
            label_address.Text = customer.address;
            label_postal_code.Text = customer.postal_code.ToString();
            if (customer.IsValid)
            {
                label_validation.Text = "Valid    " + customer.validationDate.ToString("dd.MM.yyyy");
                label_validation.ForeColor = Color.Green;
            }
            else
            {
                label_validation.Text = "Not Valid";
                label_validation.ForeColor = Color.Red;
            }
            foreach(int id in customer.books)
            {
                Book? book = BookMapper.GetBook(id);
                if(book != null)
                {
                    BorrowedBookUI item = new BorrowedBookUI(book, selected_customer);
                    
                    flowLayoutPanel_borrowed_books.Controls.Add(item);
                    
                }
            }
            panel_customer_info.Visible = true;
        }


        private void button_borrow_Click(object sender, EventArgs e)
        {
            textBox_book_id.Text = "";
            panel_borrow_book.Visible = true;  
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            panel_borrow_book.Visible = false;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if(textBox_book_id.Text == "" )
            {
                label_error.Text = "wrong input";
                label_error.Visible = true;
                return;
            }

            if (textBox_book_id.Text == "0")
            {
                label_error.Text = "book not found";
                label_error.Visible = true;
                return;
            }
            foreach (Char c in textBox_book_id.Text)
            {
                if (c < '0' || c > '9')
                {
                    label_error.Text = "wrong input";
                    label_error.Visible = true;
                    return;
                }
            }

            int? id = int.Parse(textBox_book_id.Text);
            if(id != null)
            {
                Book? book = BookMapper.GetBook((int)id);
                if(book == null)
                {
                    label_error.Text = "book not found";
                    label_error.Visible = true;
                    return;
                }
                if (book.borrowed)
                {
                    label_error.Text = "book already borrowed";
                    label_error.Visible = true;
                    return;
                }
                label_error.Visible = false;

                selected_customer.customer.Borrow(book);
                BookMapper.BorrowBook(book);

                panel_borrow_book.Visible = false;
                DataLogger.LogData($"book[{book.id}] borrowed to customer [{book.customer_id}]");
                selected_customer.UpdateBooksCount();
                SelectCustomer(selected_customer.customer);
            }
        }
    }
}
