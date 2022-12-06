using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataStructures
    {
        public class Customer
        {
            public int id { get; set; }
            public string first_name { get; set; } = "";
            public string last_name { get; set; } = "";
            public string email { get; set; } = "";
            public string? phone { get; set; }
            public string address { get; set; } = "";
            public int postal_code { get; set; }
            public DateTime validationDate { get; set; }
            public List<int> books { get; set; }

            public Customer()
            {
                books = new List<int>();
            }
            public bool IsValid { get { return validationDate.AddYears(1) > DateTime.Today; } }
            public void Validate()
            {
                validationDate = DateTime.Today;
            }
            public void Borrow(Book book)
            {
                book.Borrow(this.id);
                books.Add(book.id);
               
            }

            public void Return(Book book)
            {
                books.Remove(book.id);
                book.Return();
            }
        }

        public class Book
        {
            public int id { get; set; }
            public string title { get; set; } = "";
            public string author { get; set; } = "";
            public string genre { get; set; } = "";
            public string language { get; set; } = "";
            public string description { get; set; } = "";
            public DateTime? borrow_date { get; set; } = null;
            public DateTime? return_date { get; set; } = null;
            public int? customer_id { get; set; } = null;
            public bool borrowed 
            { 
                get { return (return_date != null); }
            }

            public void Borrow(int customer_id)
            {
                this.customer_id = customer_id;
                borrow_date = DateTime.Today;
                return_date = DateTime.Today.AddMonths(1);
            }

            public void Return()
            {
                this.customer_id = null;
                borrow_date = null;
                return_date = null;
            }
        }

        public class Librarian
        {
            public int id { get; set; }
            public string email { get; set; } = "";
            public string password { get; set; } = "";
            public bool ChangePassword(string old_password, string new_password)
            {
                if (password == old_password)
                {
                    password = new_password;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
