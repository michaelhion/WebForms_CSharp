using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace TesteAccessBrasil2.Models
{
    public class Regra
    {
        string connectionString = "Data Source=NOTE\\SQLEXPRESS;Initial Catalog=Carros;Integrated Security=True";

        string sqlInserir = "insert into dbo.Carro (Codigo, Codigo_Marca, Modelo, Ano, Cor) values(@Codigo,@Codigo_Marca,@Modelo,@Ano,@Cor)";
        public void Add(Carro car)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            {
                SqlCommand cmd = new SqlCommand(sqlInserir, conn);
                cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = car.Codigo;
                cmd.Parameters.Add("@Codigo_Marca", SqlDbType.Int).Value = car.CodMarca;
                cmd.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = car.Modelo;
                cmd.Parameters.Add("@Ano", SqlDbType.Int).Value = car.Ano;
                cmd.Parameters.Add("@Cor", SqlDbType.VarChar).Value = car.Cor;

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

        public Carro Encontrar(int? id)
        {

            Carro car = new Carro();
            SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("select * from dbo.Carro where id=" + id, conn);


            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    car.Codigo = Convert.ToInt32(reader.GetValue(1));
                    car.CodMarca = Convert.ToInt32(reader.GetValue(2));
                    car.Modelo = Convert.ToString(reader.GetValue(3));
                    car.Ano = Convert.ToInt32(reader.GetValue(4));
                    car.Cor = Convert.ToString(reader.GetValue(5));
                }
                
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return car;

        }

        public void Atualizar(int id)
        {
            Carro car = new Carro();

            String update = "update dbo.Carro Set Codigo = @Codigo, Codigo_Marca = @Codigo_Marca, Modelo = @Modelo, Ano = @Ano, Cor = @Cor where id=" + id;
            SqlConnection conn = new SqlConnection(connectionString);
            {
                SqlCommand cmd = new SqlCommand(update, conn);
                
                cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = car.Codigo;
                cmd.Parameters.Add("@Codigo_Marca", SqlDbType.Int).Value = car.CodMarca;
                cmd.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = car.Modelo;
                cmd.Parameters.Add("@Ano", SqlDbType.Int).Value = car.Ano;
                cmd.Parameters.Add("@Cor", SqlDbType.VarChar).Value = car.Cor;

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



        public void excluir(int id) 
        {
            Carro car = new Carro();
            SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Delete from dbo.Carro where id=" + id, conn);


            try
            {
                conn.Open();
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = car.Id;
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

    


