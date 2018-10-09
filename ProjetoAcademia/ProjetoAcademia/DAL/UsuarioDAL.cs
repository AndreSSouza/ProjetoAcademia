using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoAcademia.DAL
{
    class UsuarioDAL
    {
        Conexao conexao = new Conexao();

        
        public void Cadastrar(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO USUARIO (NomeUsuario, Senha, TipoUsuario) VALUES (@NomeUsuario, @Senha, @TipoUsuario)");

            cmd.Connection = conexao.Conectar();//abrindo conexão 

            //referindo os parametros da consulta
            cmd.Parameters.AddWithValue("@NomeUsuario", usu.NomeUsuario);
            cmd.Parameters.AddWithValue("@Senha", usu.Senha);
            cmd.Parameters.AddWithValue("@TipoUsuario", usu.TipoUsuario);
           

            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        
        public void Atualizar(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE USUARIO SET NomeUsuario = @NomeUsuario, Senha = @Senha, TipoUsuario = @TipoUsuario WHERE CodUsuario = @CodUsuario");

            cmd.Connection = conexao.Conectar();

            cmd.Parameters.AddWithValue("@CodUsuario", usu.CodUsuario);
            cmd.Parameters.AddWithValue("@NomeUsuario", usu.NomeUsuario);
            cmd.Parameters.AddWithValue("@Senha", usu.Senha);
            cmd.Parameters.AddWithValue("@TipoUsuario", usu.TipoUsuario);

            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //Consultar Todos
        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CodUsuario as 'Código', NomeUsuario as Nome, TipoUsuario as 'Tipo de Usúario'  FROM USUARIO ORDER BY Nome", conexao.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        //Consultar por Nome
        public DataTable ConsultarPorNome(BLL.Usuario usu)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CodUsuario as 'Código', NomeUsuario as Nome, Senha, TipoUsuario as 'Tipo de Usúario' FROM USUARIO WHERE NomeUsuario LIKE @NomeUsuario ORDER BY NomeUsuario", conexao.Conectar());

            da.SelectCommand.Parameters.AddWithValue("@NomeUsuario", usu.NomeUsuario + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            conexao.Desconectar();
            return dt;
        }


        public void Excluir(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM USUARIO WHERE CodUsuario = @CodUsuario");
            cmd.Connection = conexao.Conectar();
            cmd.Parameters.AddWithValue("@CodUsuario", usu.CodUsuario);
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //Retornar dados
        public BLL.Usuario RetornarDados(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIO WHERE CodUsuario = @CodUsuario");
            cmd.Connection = conexao.Conectar();
            cmd.Parameters.AddWithValue("@CodUsuario", usu.CodUsuario);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                usu.CodUsuario = Convert.ToInt16(dr["CodUsuario"]);
                usu.NomeUsuario = dr["NomeUsuario"].ToString();
                usu.Senha = dr["Senha"].ToString();
                usu.TipoUsuario = dr["TipoUsuario"].ToString();
               
            }

            dr.Close();
            conexao.Desconectar();
            return usu;
        }

        //Retornar dados LOGIN
        public BLL.Usuario Logar(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIO WHERE NomeUsuario = @NomeUsuario AND Senha = @Senha");
            cmd.Connection = conexao.Conectar();
            cmd.Parameters.AddWithValue("@NomeUsuario", usu.NomeUsuario);
            cmd.Parameters.AddWithValue("@Senha", usu.Senha);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                usu.CodUsuario = Convert.ToInt16(dr["CodUsuario"]);
                usu.NomeUsuario = dr["NomeUsuario"].ToString();
                usu.Senha = dr["Senha"].ToString();
                usu.TipoUsuario = dr["TipoUsuario"].ToString();

            }
            else
            {
                usu.CodUsuario = -1;
            }
            dr.Close();
            conexao.Desconectar();
            return usu;
        }
    }
    

}
