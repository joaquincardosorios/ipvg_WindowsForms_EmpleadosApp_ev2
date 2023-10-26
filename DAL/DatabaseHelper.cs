using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DatabaseHelper
    {
        // Clase Helper para instanciar conexion a la base de datos a traves de un arquitectura singleton
        private static DatabaseHelper instance = new DatabaseHelper();

        public static DatabaseHelper Instance
        {
            get { return instance; }
        }

        private static string CONNECTION_STRING = "Data Source=DESKTOP-NEQ7ASB\\SQLEXPRESS; Initial Catalog=Tareas; Integrated Security=True ";

        // Ejecuta una consulta SQL que modifica la base de datos y devuelve la cantidad de filas afectadas.
        public int ExecuteNonQuery(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            return cmd.ExecuteNonQuery();
        }

        // Ejecuta una consulta SQL que recupera datos de la base de datos y devuelve los resultados en un DataTable
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(CONNTECTION_STRING);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

    }
}
