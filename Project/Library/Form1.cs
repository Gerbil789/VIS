using DataLayer;
using LogicLayer;
using PresentationLayer;
using PresentationLayer.UI_elements;
using static DataLayer.DataStructures;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel_container.Controls.Clear();
            button_select.BackColor = Color.GreenYellow;
            button_select.Visible = false;
        }


        void AddUserControll(UserControl userControl)
        {
            panel_container.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel_container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //Search
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (books_selected)
            {
                SelectBooks();
            }
            else
            {
                SelectCustomers();
            }
        }

        public bool books_selected = true;
        
        //select search type (books/customers)
        private void button_select_Click(object sender, EventArgs e)
        {
            if (books_selected)
            {
                SelectCustomers();
                button_select.Text = "Books";
                button_select.BackColor = Color.Yellow;
                books_selected = false;

                
            }
            else
            {
                SelectBooks();
                button_select.Text = "Customers";
                button_select.BackColor = Color.GreenYellow;
                books_selected = true;
            }
        }

        void SelectBooks()
        {
            UC_books uc = new UC_books();
            AddUserControll(uc);

            List<Book> books = BookMapper.GetBooks(searchBox.Text);
            uc.ShowBooks(books);
        }

        void SelectCustomers()
        {
            UC_customers uc = new UC_customers(); ;
            AddUserControll(uc);

            List<Customer> customers = CustomerMapper.GetCustomers(searchBox.Text);
            uc.ShowCustomers(customers);
        }

        public bool logged = false;
        public Librarian? librarian = null;

        //Login / Logout
        private void button_login_logout_Click(object sender, EventArgs e)
        {
            if (logged)
            {
                LogOut();
            }
            else
            {
                ShowLoginForm();
            }
        }

        void ShowLoginForm()
        {
            label_login_error.Visible = false;
            textBox_login_email.Text = "vojta.rubes@gmail.com";
            textBox_login_password.Text = "password";
            panel_login_form.Visible = true;
        }



        void LogOut()
        {
            label_librarian.Visible = false;
            
            button_login_logout.Text = "Log in";
            button_login_logout.BackColor = Color.FromArgb(0,192,0);
            button_select.Visible = false;
            books_selected = true;
            panel_container.Controls.Clear();
            logged = false;
            DataLogger.LogData($"librarian [{librarian.id}] logged out");
            librarian = null;
        }

        private void button_login_back_Click(object sender, EventArgs e)
        {
            panel_login_form.Visible = false;
        }

        private void button_login_confirm_Click(object sender, EventArgs e)
        {
            librarian = LibrarianMapper.GetLibrarian(textBox_login_email.Text, textBox_login_password.Text);
            if(librarian == null)
            {
                label_login_error.Text = "wrong email or password";
                label_login_error.Visible = true;
                return;
            }

            label_librarian.Text = librarian.email;
            label_librarian.Visible = true;
            button_login_logout.Text = "Log out";
            button_login_logout.BackColor = Color.FromArgb(193,49,13);
            button_select.Visible = true;
            panel_login_form.Visible = false;

            logged = true;
            DataLogger.LogData($"librarian [{librarian.id}] logged in");
        }
    }
}