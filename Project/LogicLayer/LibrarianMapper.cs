using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataLayer.DataStructures;

namespace LogicLayer
{
    public static class LibrarianMapper
    {
        public static Librarian? GetLibrarian(string email, string password)
        {
            Librarian? librarian = null;
            librarian = DataGateway.GetLIbrarian(email, password);

            return librarian;
        }

    }
}
