using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL
{
    class plano
    {
        int codPlano;
        String nomePlano;
        decimal valorPlano;

        public int CodPlano { get => codPlano; set => codPlano = value; }
        public string NomePlano { get => nomePlano; set => nomePlano = value; }
        public decimal ValorPlano { get => valorPlano; set => valorPlano = value; }
    }
}
