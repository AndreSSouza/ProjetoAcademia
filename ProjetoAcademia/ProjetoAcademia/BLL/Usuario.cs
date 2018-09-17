using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL
{
    class Usuario
    {
        int CodUsuario;
	    String NomeUsuario, Senha, TipoUsuario;

        public int CodUsuario1 { get => CodUsuario; set => CodUsuario = value; }
        public string NomeUsuario1 { get => NomeUsuario; set => NomeUsuario = value; }
        public string Senha1 { get => Senha; set => Senha = value; }
        public string TipoUsuario1 { get => TipoUsuario; set => TipoUsuario = value; }
    }
}
