using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GoMartApplication
{
     class DbConnect
    {
       private  SqlConnection conn=new SqlConnection("Data Source=DESKTOP-C5UDHUG;Initial Catalog=GoMartDb;Integrated Security=true"); 
        


        public SqlConnection getDbConnection() { 
            
            
            return conn;
        }
        public void openDbConnection()
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void closeDbConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }

    
}
