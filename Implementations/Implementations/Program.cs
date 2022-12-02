//using my school DB ("actor" table to be specific :D)

//Domain model
//  Project is separated into layers (Presentation, Bussiness, Data)
//  + one extra layer for data structures

//RowDataGateway
//  in Data layer

//Identity map
//  in Bussiness layer

using BussinessLayer;
using MyDataStructures;

namespace Implementations{
    class Program{
        static void Main(string[] args){

            //IDENTITY MAP
            //load same data twice
            //first time it takes longer because it is getting data from DB
            //second time it is instant because it takes already saved data
            IdentityMap identityMap = new IdentityMap();
            
           
            for (int i = 1; i <= 50; i++)
            {
                Actor a = identityMap.GetItem(i);
                Console.WriteLine($"[{a.actor_id}]\t{a.first_name}, {a.last_name}");
            }
            for (int i = 1; i <= 50; i++)
            {
                Actor a = identityMap.GetItem(i);
                Console.WriteLine($"[{a.actor_id}]\t{a.first_name}, {a.last_name}");
            }
        }
    }  
}