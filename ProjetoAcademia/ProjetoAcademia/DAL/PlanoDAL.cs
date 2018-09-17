using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoAcademia.DAL
{
    class PlanoDAL
    {
        Conexao conexao = new Conexao();

        //Cadastrar Plano
        public void Cadastrar(BLL.plano pla)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Plano (NomePlano, ValorPlano) VALUES (@NomePlano, @ValorPlano)");

            cmd.Connection = conexao.Conectar();//abrindo conexão 

            //referindo os parametros da consulta
            cmd.Parameters.AddWithValue("@NomePlano", pla.NomePlano);
            cmd.Parameters.AddWithValue("@ValorPlano", pla.ValorPlano);            

            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //Atualizar Plano
        public void Atualizar(BLL.plano pla)
        {
            SqlCommand cmd = new SqlCommand(@"UPADATE Plano SET NomePlano = @NomePlano, ValorPlano = @ValorPlano WHERE CodPlano = @CodPlano");

            cmd.Connection = conexao.Conectar();

            cmd.Parameters.AddWithValue("@NomePlano", pla.NomePlano);
            cmd.Parameters.AddWithValue("@ValorPlano", pla.ValorPlano);
            cmd.Parameters.AddWithValue("@CodPlano", pla.CodPlano);

            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //Consultar Todos
        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CodPlano 'Código', NomePlano 'Nome do Plano',valorPlano 'Valor do Plano' FROM Plano ORDER BY NomePlano", conexao.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        //Consultar por Nome
        public DataTable ConsultarPorNome(BLL.plano pla)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CodPlano AS 'Código', NomePlano AS 'Nome do Plano',valorPlano AS 'Valor do Plano' FROM Plano WHERE NomePlano LIKE @NomePlano ORDER BY NomePlano", conexao.Conectar());

            da.SelectCommand.Parameters.AddWithValue("@NomePlano", pla.NomePlano + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        //Excluir plano
        public void Excluir(BLL.plano pla)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Plano WHERE CodPlano = @CodPlano");
            cmd.Connection = conexao.Conectar();
            cmd.Parameters.AddWithValue("@CodPlano", pla.CodPlano);
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //Retornar dados
        public BLL.plano RetornarDados(BLL.plano pla)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Plano WHERE CodPlano = @CodPlano");
            cmd.Connection = conexao.Conectar();
            cmd.Parameters.AddWithValue("@CodPlano", pla.CodPlano);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                pla.CodPlano = Convert.ToInt16(dr["CodPlano"]);
                pla.NomePlano = dr["NomePlano"].ToString();
                pla.ValorPlano = Convert.ToDecimal(dr["ValorPlano"]);
            }

            dr.Close();
            conexao.Desconectar();
            return pla;
        }    
    }
}
