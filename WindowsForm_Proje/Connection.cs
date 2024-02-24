using System;
using System.Collections.Generic;
using System.Data.SqlClient;  
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_Proje
{
    internal class Connection
    {
        public SqlConnection connection;
        public Connection() 
        {
             connection = new SqlConnection("Server=DESKTOP-KK1TKIO\\SQLDERS;Database=Yemeksepeti;Trusted_Connection=True;");
        } 
    }
}
