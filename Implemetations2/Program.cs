using Implemetations2;

namespace Implementations{
    class Program{
        static void Main(string[] args)
        {
            DataGateway gateway = new DataGateway();

            //FOREIGN KEY MAPPING
            //more info in "DataStructures.cs"
            List<Book> books = new List<Book>();
            for(int i = 1; i <= 10; i++)
            {
                books.Add(gateway.FindBook(i));
                Console.WriteLine(books[i-1]);
            }


            //SINGLE TABLE INHERITANCE
            //Multiple classes inheriting from "Employee" class
            //in DB everything is in one table
            //----------------------
            //LAYER SUPERTYPE
            //more info in "DataGateway.cs" and "DataStructures.cs"


            Programmer programmer1 = gateway.GetProgrammer(1);
            Console.WriteLine("Programmer:\t" + programmer1.name + "\tLanguage: " + programmer1.language);
            Programmer programmer2 = gateway.GetProgrammer(2);
            Console.WriteLine("Programmer:\t" + programmer2.name + "\tLanguage: " + programmer2.language);
            Producer producer = gateway.GetProducer(3);
            Console.WriteLine("Producer:\t" + producer.name + "\tStyle: " + producer.music_style);
            Artist artist = gateway.GetArtist(4);
            Console.WriteLine("Artist:\t\t" + artist.name + "\tArt Style: " + artist.art_style);
        }
    }
}