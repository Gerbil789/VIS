using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static DataLayer.DataStructures;

namespace LogicLayer
{
    public static class BookMapper
    {
        public static Dictionary<int, Book> pool = new Dictionary<int, Book>();

        public static void AddBook(Book book)
        {
            int id = book.id;
            if (!pool.ContainsKey(id))
            {
                pool.Add(id, book);
                return;
            }

            pool[id] = book;
        }

        public static void BorrowBook(Book book)
        {
            int id = book.id;
            if (!pool.ContainsKey(id))
            {
                return;
            }

            DataGateway.BorrowBook(book);
        }

        public static void ReturnBook(Book book)
        {
            int id = book.id;
            if (!pool.ContainsKey(id))
            {
                return;
            }

            DataGateway.ReturnBook(book);
        }


        public static bool RemoveBook(int id)
        {
            if (!pool.ContainsKey(id))
                return false;

            return pool.Remove(id);
        }

        public static Book? GetBook(int id)
        {
            if (!pool.ContainsKey(id))
            {
                Book? book = DataGateway.GetBook(id);
                if(book != null)
                {
                    AddBook(book);
                }
            }
            if (!pool.ContainsKey(id))
            {
                return null;
            }
            return pool[id];
        }

        public static List<Book> GetBooks(string name)
        {
            List<Book> books = DataGateway.GetBooks(name);
            foreach (Book book in books)
            {
                if(!pool.ContainsKey(book.id))
                AddBook(book);
            }
            return books;
        }
    }
}
