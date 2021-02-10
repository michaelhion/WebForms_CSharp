using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace TesteAccessBrasil2.Models
{
    public class RegraMarca
    {
        string connectionString = "Data Source=NOTE\\SQLEXPRESS;Initial Catalog=Carros;Integrated Security=True";

        string sqlInserir = "insert into dbo.Marca (Codigo,Nome) values(@Codigo,@Nome)";
        public void Add(Marca marca)
        {
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlInserir, conn);
                cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = marca.Codigo;
                cmd.Parameters.Add("@Nome", SqlDbType.Int).Value = marca.Nome;
               

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}