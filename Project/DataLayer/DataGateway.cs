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
                command.CommandText = $"SELECT book_id, title, author_id, genre_id, language_id, description FROM vis_book WHERE book_id = {id};";

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
                        book.author_id = reader.GetInt32(2);
                        book.genre_id = reader.GetInt32(3);
                        book.language_id = reader.GetInt32(4);
                        book.description = reader.GetString(5);
                    }
                }
            }
            return book;
        }

        //table data gateway - return multiple rows
        public static List<Book> GetBooks(string title)
        {
            List<Book> books = new List<Book>();

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT book_id, title, author_id, genre_id, language_id, description FROM vis_book WHERE title LIKE('%{title}%');";

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
                            book.author_id = reader.GetInt32(i++);
                            book.genre_id = reader.GetInt32(i++);
                            book.language_id = reader.GetInt32(i++);
                            book.description = reader.GetString(i++);

                            books.Add(book);
                        }
                    }
                }
            }
            return books;
        }
    }
    
 
}
