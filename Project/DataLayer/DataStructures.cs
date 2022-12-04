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
            public string phone { get; set; } = "";
            public DateTime validationDate { get; set; }
            public List<Book> books { get; set; }

            public Customer()
            {
                books = new List<Book>();
            }
            public bool IsValid { get { return validationDate.AddYears(1) < DateTime.Today; } }
            public void Validate()
            {
                validationDate = DateTime.Today;
            }
            public void Borrow(Book book)
            {
                books.Add(book);
                book.borrowed = true;
            }

            public void Return(Book book)
            {
                books.Remove(book);
                book.borrowed = false;
            }
        }

        public class Book
        {
            public int id { get; set; }
            public string title { get; set; } = "";
            public int author_id { get; set; }
            public int genre_id { get; set; }
            public int language_id { get; set; }
            public string description { get; set; } = "";
            public bool borrowed { get; set; }
            public override string ToString()
            {
                return $"[{id}]\t{title}";
            }
        }

        public class Librarian
        {
            int id { get; set; }
            string email { get; set; } = "";
            string password { get; set; } = "";
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
