using DataLayer;
using LogicLayer;
using PresentationLayer;
using static DataLayer.DataStructures;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Book> books = DataGateway.GetBooks(searchBox.Text);
            ShowBooks(books);
        }

        

        void ShowBooks(List<Book> books)
        {
            flowLayoutPanel1.Controls.Clear();
            
            foreach(Book book in books)
            {
                BookUI item = new BookUI();
                item.Title = book.title;
                item.Author = book.author_id.ToString();
                item.Genre = book.genre_id.ToString();
                item.Language = book.language_id.ToString();
                item.description = book.description;
                item.Borrowed = false;
                flowLayoutPanel1.Controls.Add(item);
                item.Click += new EventHandler(On_Click);
            }
        }

        void On_Click(object sender, EventArgs e)
        {
            BookUI obj = (BookUI)sender;
            label_description.Text = obj.description;
            panel_book_details.Visible = true;
            
            
        }

        
    }
}