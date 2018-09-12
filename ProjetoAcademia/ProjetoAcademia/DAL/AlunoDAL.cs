using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//precisa
using System.Data.SqlClient;//precisa

namespace ProjetoAcademia.DAL
{
    class AlunoDAL
    {
        Conexao conexao = new Conexao();

        //Cadastrar Aluno
        public void Cadastrar(BLL.Aluno alu)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Aluno (Nome, Cpf, Rg, Email, DataNascimento) VALUES (@Nome, @Cpf, @Rg, @Email, @DataNascimento)");

            cmd.Connection = conexao.Conectar();//abrindo conexão 

            //referindo os parametros da consulta
            cmd.Parameters.AddWithValue("@Nome", alu.Nome);
            cmd.Parameters.AddWithValue("@Cpf", alu.Cpf);
            cmd.Parameters.AddWithValue("@Rg", alu.Rg);
            cmd.Parameters.AddWithValue("@Email", alu.Email);
            cmd.Parameters.AddWithValue("@DataNascimento", alu.DataNascimento);

            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //Atualizar Aluno
        public void Atualizar(BLL.Aluno alu)
        {
            SqlCommand cmd = new SqlCommand(@"UPADATE ALUNO SET Nome = @Nome, Cpf = @Cpf, Rg = @Rg, Email = @Email, DataNascimento = @DataNascimento");

            cmd.Connection = conexao.Conectar();

            cmd.Parameters.AddWithValue("@Nome", alu.Nome);
            cmd.Parameters.AddWithValue("@Cpf", alu.Cpf);
            cmd.Parameters.AddWithValue("@Rg", alu.Rg);
            cmd.Parameters.AddWithValue("@Email", alu.Email);
            cmd.Parameters.AddWithValue("@DataNascimento", alu.DataNascimento);

            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //Consultar Todos
        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CodAluno 'Código', Nome, Cpf CPF, Rg RG, Email 'E-mail', DataNascimento 'Data de Nascimento' FROM Aluno ORDER BY Nome", conexao.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        //Consultar por Nome
        public DataTable ConsultarPorNome(BLL.Aluno alu)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CodAluno 'Código', Nome, Cpf CPF, Rg RG, Email 'E-mail', DataNascimento 'Data de Nascimento' FROM Aluno WHERE Nome LIKE @Nome ORDER BY Nome", conexao.Conectar());

            da.SelectCommand.Parameters.AddWithValue("@Nome", alu.Nome + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            conexao.Desconectar();
            return dt;             
        }

        //Excluir Aluno
        public void Excluir(BLL.Aluno alu)
        {
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Aluno WHERE CodAluno = @CodAluno");
            cmd.Connection = conexao.Conectar();
            cmd.Parameters.AddWithValue("@CodAluno", alu.CodAluno);
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        //Retornar dados
        public BLL.Aluno RetornarDados(BLL.Aluno alu)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Aluno WHERE CodAluno = @CodAluno");        
            cmd.Connection = conexao.Conectar();
            cmd.Parameters.AddWithValue("@CodAluno", alu.CodAluno);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                alu.CodAluno = Convert.ToInt16(dr["CodAluno"]);
                alu.Nome = dr["Nome"].ToString();
                alu.Cpf = dr["Cpf"].ToString();
                alu.Rg = dr["Rg"].ToString();
                alu.Email = dr["Email"].ToString();
                alu.DataNascimento = dr["DataNascimento"].ToString();
            }

            dr.Close();
            conexao.Desconectar();
            return alu;              
        }


    }
}
