using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL
{
    class Matricula
    {
        int CodMatricula, CodPlano, CodAluno;
        String DataMatricula, DataVencimento;

        public int CodMatricula1 { get => CodMatricula; set => CodMatricula = value; }
        public int CodPlano1 { get => CodPlano; set => CodPlano = value; }
        public int CodAluno1 { get => CodAluno; set => CodAluno = value; }
        public string DataMatricula1 { get => DataMatricula; set => DataMatricula = value; }
        public string DataVencimento1 { get => DataVencimento; set => DataVencimento = value; }
    }
}
