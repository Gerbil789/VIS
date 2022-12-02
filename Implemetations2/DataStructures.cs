using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implemetations2
{
    //Foreign Key Mapping
    //class "Book" has foreign keys (ids)
    public class Book
    {
        public int book_id { get; set; }    //PK
        public string title { get; set; } = "";
        public string? description { get; set; }   
        public int author_id { get; set; }  //FK
        public int genre_id { get; set; }   //FK
        public int language_id {get; set; } //FK

        //instance of gateway here is not ideal :d
        //but it looks clean in main() :D
        DataGateway gateway = new DataGateway();
        public override string ToString()
        {
            return $"[{book_id}]\t{title}\t" +
                $"{gateway.Find<Author>(author_id).name}, " +
                $"{gateway.Find<Genre>(genre_id).name}, " +
                $"{gateway.Find<Language>(language_id).name}" +
                $"\n\n{description}\n";
        }
    }





    //convenient interface for polymorph data gateway
    public interface INameTable
    {
        string name { get; set; }  
    };
    

    public class Author : INameTable
    {
        public int author_id { get; set; }
        public string name { get; set; } = "";

    }
    public class Genre : INameTable
    {
        public int genre_id { get; set; }
        public string name { get; set; } = "";
    }
    public class Language : INameTable
    {
        public int language_id { get; set; }
        public string name { get; set; } = "";
    }




    //Single Table Inheritence
    //Multiple classes inheriting from "Employee" class
    //in DB everything is in one table
    public class Employee
    {
        public string name { get; set; } = "";
    }

    public class Programmer : Employee
    {
        public string language { get; set; } = "";
    }
    public class Artist : Employee
    {
        public string art_style { get; set; } = "";
    }
    public class Producer : Employee
    {
        public string music_style { get; set; } = "";
    }
}
