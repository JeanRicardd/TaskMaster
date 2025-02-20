using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster_Dev.Classes
{
    internal class Conexao
    {
        private static SQLiteConnection sqliteConnection;
        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=./dados/basedados.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void FecharConexao()
        {
            if (sqliteConnection != null && sqliteConnection.State == ConnectionState.Open)
            {
                sqliteConnection.Close();
            }
        }
    }
}
