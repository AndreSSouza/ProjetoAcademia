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

        public int CodPlano
        {
            get { return codPlano; }
            set { codPlano = value; }
        }
        String nomePlano;

        public String NomePlano
        {
            get { return nomePlano; }
            set { nomePlano = value; }
        }
        decimal valorPlano;

        public decimal ValorPlano
        {
            get { return valorPlano; }
            set { valorPlano = value; }
        }

    }
}
