using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Numerics;
using static DataLayer.DataStructures;

namespace DataLayer
{
    public static class DataGateway
    {
        //row data gateway - return only one row
        public static Book? GetBook(int id)
        {
            Book book = new Book();

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText =
                    $"SELECT vb.book_id, title, va.name, vg.name, vl.name, description, borrow_date, return_date, borrow.customer_id " +
                    $"FROM vis_book vb " +
                    $"JOIN vis_author va on vb.author_id = va.author_id " +
                    $"JOIN vis_genre vg on vb.genre_id = vg.genre_id " +
                    $"JOIN vis_language vl on vb.language_id = vl.language_id " +
                    $"LEFT JOIN vis_borrow borrow on vb.book_id = borrow.book_id " +
                    $"WHERE vb.book_id = {id};";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if(reader.GetInt32(0) != id)
                        {
                            return null;
                        }
                        book.id = reader.GetInt32(0);
                        book.title = reader.GetString(1);
                        book.author = reader.GetString(2);
                        book.genre = reader.GetString(3);
                        book.language = reader.GetString(4);
                        book.description = reader.GetString(5);
                        if (!reader.IsDBNull(6))
                        {
                            book.borrow_date = reader.GetDateTime(6);
                            book.return_date = reader.GetDateTime(7);
                            book.customer_id = reader.GetInt32(8);
                        }
                    }
                }
            }
            return book;
        }

        public static void BorrowBook(Book book)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                
                string INSERT = $"INSERT INTO vis_borrow(customer_id, book_id, borrow_date, return_date) VALUES({book.customer_id}, {book.id}, CAST('{book.borrow_date}' AS DateTime), CAST('{book.return_date}' AS DateTime));";
                connection.Open();
                using (SqlCommand writer = new SqlCommand(INSERT))
                {
                    writer.Connection = connection;
                    writer.ExecuteNonQuery();
                }
            }
        }

        public static void ReturnBook(Book book)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                string DELETE = $"DELETE FROM vis_borrow WHERE book_id = {book.id};";
                using (SqlCommand writer = new SqlCommand(DELETE))
                {
                    writer.Connection = connection;
                    writer.ExecuteNonQuery();
                }
            }
        }


        public static void BorrowedBooks(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT book_id FROM vis_borrow WHERE customer_id = {customer.id};";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int i = 0;
                        while (i < reader.FieldCount)
                        {
                            customer.books.Add(reader.GetInt32(i));
                            i++;
                        }
                    }
                }
            }
        }



        //table data gateway - return multiple rows
        public static List<Book> GetBooks(string title)
        {
            List<Book> books = new List<Book>();

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = 
                    $"SELECT vb.book_id, title, va.name, vg.name, vl.name, description, borrow_date, return_date, borrow.customer_id " +
                    $"FROM vis_book vb " +
                    $"JOIN vis_author va on vb.author_id = va.author_id " +
                    $"JOIN vis_genre vg on vb.genre_id = vg.genre_id " +
                    $"JOIN vis_language vl on vb.language_id = vl.language_id " +
                    $"LEFT JOIN vis_borrow borrow on vb.book_id = borrow.book_id " +
                    $"WHERE title LIKE('%{title}%');";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int i = 0;
                        while(i < reader.FieldCount)
                        {
                            Book book = new Book();
                            book.id = reader.GetInt32(i++);
                            book.title = reader.GetString(i++);
                            book.author = reader.GetString(i++);
                            book.genre = reader.GetString(i++);
                            book.language = reader.GetString(i++);
                            book.description = reader.GetString(i++);
                            if (!reader.IsDBNull(i))
                            {
                                book.borrow_date = reader.GetDateTime(i++);
                                book.return_date = reader.GetDateTime(i++);
                                book.customer_id = reader.GetInt32(i++);
                            }
                            else
                            {
                                i += 3;
                            }
                            
                            
                            books.Add(book);
                        }
                    }
                }
                
            }
            return books;
        }

        public static List<Customer> GetCustomers(string name)
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT customer_id, first_name, last_name, email, phone, validaton_date, address, postal_code FROM vis_customer WHERE first_name LIKE('%{name}%') OR last_name LIKE('%{name}%');";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int i = 0;
                        while (i < reader.FieldCount)
                        {
                            Customer customer = new Customer();
                            customer.id = reader.GetInt32(i++);
                            customer.first_name = reader.GetString(i++);
                            customer.last_name = reader.GetString(i++);
                            customer.email = reader.GetString(i++);
                            if(!reader.IsDBNull(i))
                            customer.phone = reader.GetString(i);
                            i++;
                            customer.validationDate = reader.GetDateTime(i++);
                            customer.address = reader.GetString(i++);
                            customer.postal_code = reader.GetInt32(i++);

                            customers.Add(customer);
                        }
                    }
                }
            }
            foreach(Customer customer in customers)
            {
                BorrowedBooks(customer);
            }
            return customers;
        }

        public static Customer? GetCustomer(int id)
        {
            Customer customer = new Customer();

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT customer_id, first_name, last_name, email, phone, validaton_date, address, postal_code FROM vis_customer WHERE customer_id = {id};";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customer.id = reader.GetInt32(0);
                        customer.first_name = reader.GetString(1);
                        customer.last_name = reader.GetString(2);
                        customer.email = reader.GetString(3);
                        if (!reader.IsDBNull(4))
                            customer.phone = reader.GetString(4);
                        customer.validationDate = reader.GetDateTime(5);
                        customer.address = reader.GetString(6);
                        customer.postal_code = reader.GetInt32(7);                        
                    }
                }
            }
            BorrowedBooks(customer);
            return customer;
        }

        public static Librarian? GetLIbrarian(string email, string password)
        {
            Librarian? librarian = null;

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT librarian_id, email, password FROM vis_librarian WHERE email = '{email}' AND password = '{password}';";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        librarian = new Librarian();
                        librarian.id = reader.GetInt32(0);
                        librarian.email = reader.GetString(1);
                        librarian.password = reader.GetString(2);
                    }
                }
            }
            return librarian;
        }
    }
}
