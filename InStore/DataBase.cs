using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace InStore
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-A0C2RGL; Initial Catalog = Интернет магазин; Integrated Security = True");


        public void OpenConection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {  
                sqlConnection.Open(); 
            }
                
        }

        public void CloseConection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

    }
}