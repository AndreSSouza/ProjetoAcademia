using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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
            set { senha = GerarSHA1(value); }
        }

        public String NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public string GerarMD5(string valor)
        {
            // Cria uma nova intância do objeto que implementa o algoritmo para criptografia MD5
            //está criptografia não tem uma maneira de descriptografar
            //gera um hash de tamanho fixo de 32 caracteres
            MD5 md5Hasher = MD5.Create();
            // Criptografa o valor passado
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(valor));

            // Cria um StringBuilder para passarmos os bytes gerados para ele. Está classe faz a concatenação de string mais rápido
            StringBuilder strBuilder = new StringBuilder();

            // Converte cada byte em um valor hexadecimal e adiciona ao string builder (concatenando)
            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                strBuilder.Append(valorCriptografado[i].ToString("x2"));// converte um valor em hexadecimal
            }
            // retorna o valor criptografado como string
            return strBuilder.ToString();
        }

        public string GerarSHA1(string valor)
        {
            // Cria uma nova intância do objeto que implementa o algoritmo para criptografia MD5
            //está criptografia não tem uma maneira de descriptografar
            //gera um hash de tamanho fixo de 32 caracteres
            SHA1 sha1Hasher = SHA1.Create();
            // Criptografa o valor passado
            byte[] valorCriptografado = sha1Hasher.ComputeHash(Encoding.Default.GetBytes(valor));

            // Cria um StringBuilder para passarmos os bytes gerados para ele. Está classe faz a concatenação de string mais rápido
            StringBuilder strBuilder = new StringBuilder();

            // Converte cada byte em um valor hexadecimal e adiciona ao string builder (concatenando)
            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                strBuilder.Append(valorCriptografado[i].ToString("x2"));// converte um valor em hexadecimal
            }
            // retorna o valor criptografado como string
            return strBuilder.ToString();
        }

    }
}
