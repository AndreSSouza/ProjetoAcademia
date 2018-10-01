using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL
{
    class Matricula
    {
        int codMatricula, codPlano, codAluno;

        public int CodAluno
        {
            get { return codAluno; }
            set { codAluno = value; }
        }

        public int CodPlano
        {
            get { return codPlano; }
            set { codPlano = value; }
        }

        public int CodMatricula
        {
            get { return codMatricula; }
            set { codMatricula = value; }
        }
        DateTime dataMatricula, dataVencimento;

        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        public DateTime DataMatricula
        {
            get { return dataMatricula; }
            set { dataMatricula = value; }
        }

    }
}
