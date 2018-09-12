using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoAcademia.DAL
{
    class Conexao
    {   //DESKTOP-81NJOA4
        SqlConnection conexao = new SqlConnection(@"Data Source = .\sqlserver; Initial Catalog = ProjetoAcademia; Integrated Security = True;");

        public SqlConnection Conectar()
        {
            if (conexao.State == ConnectionState.Closed)           
                conexao.Open();            
            return conexao;
        }

        public void Desconectar()
        {
            if (conexao.State == ConnectionState.Open)            
                conexao.Close();            
        }
    }
}
