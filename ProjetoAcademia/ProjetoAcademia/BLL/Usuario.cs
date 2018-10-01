using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia.BLL
{
    class Usuario
    {
        int codUsuario;

        public int CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }
        String nomeUsuario, senha, tipoUsuario;

        public String TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public String NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

    }
}
