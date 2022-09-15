using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS
{
    internal class LibraryDBSingleton
    {
        private LibraryDBSingleton() {
            SqlConnection = new SqlConnection("Server=localhost;Database=Library;Trusted_Connection=True;");
        }
        public SqlConnection SqlConnection { get; private set; }

        private static LibraryDBSingleton? _instance;
        public static LibraryDBSingleton GetSingleton
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LibraryDBSingleton();
                }
                return _instance;
            }
        }

    }
}
