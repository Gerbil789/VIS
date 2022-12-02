using Implementations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Implemetations2
{
    public class DataGateway
    {
        public Book FindBook(int id)
        {
            Book book = new Book();

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT book_id, title, description, author_id, genre_id, language_id FROM vis_book WHERE book_id = {id};";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        book.book_id = reader.GetInt32(0);
                        book.title = reader.GetString(1);
                        book.description = reader.GetString(2);
                        book.author_id = reader.GetInt32(3);
                        book.genre_id = reader.GetInt32(4);
                        book.language_id = reader.GetInt32(5);
                    }
                }
            }
            return book;
        }

        //Find Author, Genre or Language
        public T Find<T>(int id) where T : INameTable, new()
        {
            string typeName = typeof(T).Name.ToLower();
            T item = new T();

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT name FROM vis_{typeName} WHERE {typeName}_id = {id}";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        item.name = reader.GetString(0);
                    }
                }
            }
            return item;
        }
        // Layer Supertype
        // one main "Get" method that does most of the work
        // other "Get" methods use main "Get" method
        public T GetEmployee<T>(int id, string parameter) where T:Employee, new()
        {
            Employee employee = new T();

            using (SqlConnection connection = new SqlConnection(ConnectionBuilder.GetBuilder().ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT name, {parameter} FROM vis_employee WHERE employee_id = {id} AND type = '{typeof(T).Name}'";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {  
                        if(typeof(T).Name == "Programmer")
                        {
                            Programmer programmer = new Programmer();
                            programmer.name = reader.GetString(0);
                            programmer.language = reader.GetString(1);
                            employee = programmer;
                        }
                        if (typeof(T).Name == "Producer")
                        {
                            Producer producer = new Producer();
                            producer.name = reader.GetString(0);
                            producer.music_style = reader.GetString(1);
                            employee = producer;
                        }
                        if (typeof(T).Name == "Artist")
                        {
                            Artist artist = new Artist();
                            artist.name = reader.GetString(0);
                            artist.art_style = reader.GetString(1);
                            employee = artist;
                        }
                    }
                }
            }
            return (T)employee;
        }

        public Programmer GetProgrammer(int id)
        {
            Programmer programmer = GetEmployee<Programmer>(id, "language");
            return programmer;
        }

        public Producer GetProducer(int id)
        {
            Producer producer = GetEmployee<Producer>(id, "music_style");
            return producer;
        }

        public Artist GetArtist(int id)
        {
            Artist artist = GetEmployee<Artist>(id, "art_style");
            return artist;
        }
    }
}



