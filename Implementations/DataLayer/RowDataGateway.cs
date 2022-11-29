using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    
    internal class RowDataGateway
    {
        string select10actors = "SELECT TOP 10 first_nameFROM actor;";
        
        public List<string> GetActors()
        {
            
            return new List<string>();
        }
    }
}
