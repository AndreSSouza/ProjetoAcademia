using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoAcademia.DAL
{
    class MatriculaDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Matricula mat)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Matricula
( CodPlano, CodAluno, DataMatricula, DataVencimento)
VALUES
( @CodPlano, @CodAluno, @DataMatricula, @DataVencimento)");

            cmd.Connection = con.Conectar();

            cmd.Parameters.AddWithValue("@CodMatricula",mat.CodMatricula);
            cmd.Parameters.AddWithValue("@CodPlano",mat.CodPlano);
            cmd.Parameters.AddWithValue("@CodAluno",mat.CodAluno);
            cmd.Parameters.AddWithValue("@DataMatricula",mat.DataMatricula);
            cmd.Parameters.AddWithValue("@DataVencimento",mat.DataVencimento);

            cmd.ExecuteNonQuery();
            con.Desconectar();

        }
        public void Atualizar(BLL.Matricula mat)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE Matricula SET
( CodPlano = @CodPlano, CodAluno = @CodAluno, DataMatricula = @DataMatricula, DataVencimento = @DataVencimento)
VALUES");

            cmd.Connection = con.Conectar();

            cmd.Parameters.AddWithValue("@CodMatricula",mat.CodMatricula);
            cmd.Parameters.AddWithValue("@CodPlano",mat.CodPlano);
            cmd.Parameters.AddWithValue("@CodAluno",mat.CodAluno);
            cmd.Parameters.AddWithValue("@DataMatricula",mat.DataMatricula);
            cmd.Parameters.AddWithValue("@DataVencimento",mat.DataVencimento);

            cmd.ExecuteNonQuery();
            con.Desconectar();
            cmd.ExecuteNonQuery(); //executando comando
            con.Desconectar();//fechando conexao

        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT
                CodMatricula AS 'Código da Matricula',
                CodPlano AS 'Código do Plano',
                CodAluno AS 'Código do Aluno',
                DataMatricula AS 'Data de Matricula',
                DataVencimento AS 'Data de Vencimento' 
                FROM Matricula ORDER BY CodMatricula", con.Conectar());//passando comando sql
            DataTable dt = new DataTable();//criando o Datatable
            da.Fill(dt); //preenchendo o datatable
            con.Desconectar();//fecha conexao
            return dt;//retorna o datatable preenchido com dados
        }

        public DataTable ConsultarporNome(BLL.Matricula mat)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT
CodMatricula AS 'Código da Matricula',
CodPlano AS 'Código do Plano',
CodAluno AS 'Código do Aluno',
DataMatricula AS 'Data de Matricula',
DataVencimento AS 'Data de Vencimento'
FROM Matricula
WHERE CodMatricula LIKE @CodMatricula", con.Conectar());//passando comando sql
            da.SelectCommand.Parameters.AddWithValue("@CodMatricula",mat.CodMatricula + "%");
            DataTable dt = new DataTable();//criando o Datatable
            da.Fill(dt); //preenchendo o datatable
            con.Desconectar();//fecha conexao
            return dt;//retorna o datatable preenchido com dados
        }

        public void Excluir(BLL.Matricula mat)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Matricula WHERE CodMatricula = @CodMatricula");
            cmd.Connection = con.Conectar();
            cmd.Parameters.AddWithValue("@CodMatricula",mat.CodMatricula);
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public BLL.Matricula RetornarDados(BLL.Matricula mat)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Matricula WHERE CodMatricula = @CodMatricula");
            cmd.Connection = con.Conectar(); //abrindo conexao
            cmd.Parameters.AddWithValue("@CodMatricula",mat.CodMatricula);
            SqlDataReader dr = cmd.ExecuteReader(); //executa a leitura

            if (dr.Read())//conseguindo encontrar o registro
            {
                //preenchendo atributos com dados vindos do bd

               mat.CodMatricula = Convert.ToInt16(dr["CodMatricula"]);
               mat.CodPlano = Convert.ToInt16(dr["CodPlano"]);
               mat.CodAluno = Convert.ToInt16(dr["CodAluno"]);
               mat.DataMatricula = Convert.ToDateTime(dr["DataMatricula"]);
               mat.DataVencimento = Convert.ToDateTime(dr["DataVencimento"]);
            }

            dr.Close();
            con.Desconectar(); //fechando conexao
            return mat; //retornando objeto com dados preenchidos


        }

    }
}

