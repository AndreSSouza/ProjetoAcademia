using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL
{
    class Aluno
    {
        int codAluno;

        public int CodAluno
        {
            get { return codAluno; }
            set { codAluno = value; }
        }

        String nome, cpf, rg, email;

        DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
    }
}
