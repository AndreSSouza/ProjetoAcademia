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
        String nome, cpf, rg, email, dataNascimento;

        public int CodAluno { get => codAluno; set => codAluno = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Email { get => email; set => email = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    }
}
