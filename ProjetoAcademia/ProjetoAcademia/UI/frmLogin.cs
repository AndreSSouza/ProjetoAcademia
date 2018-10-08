using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia.UI
{
    public partial class frmLogin : Form
    {
        public static string nomeusuario;
        public static string tipousuario;
        public static bool logado;

    
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DAL.UsuarioDAL usuDAL = new DAL.UsuarioDAL();
            BLL.Usuario usu = new BLL.Usuario();
            usu.NomeUsuario = txtUsuario.Text;
            usu.Senha = txtSenha.Text;
            usu = usuDAL.Logar(usu);
            
            if(usu.CodUsuario == -1)
            {
                MessageBox.Show("Usuário Não Encontrado");
            }
            else
            {
                logado = true;
                nomeusuario = usu.NomeUsuario;
                tipousuario = usu.TipoUsuario;
                Close();
            }
        }
    }
}
