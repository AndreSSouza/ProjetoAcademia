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
    public partial class frmUsuarios : Form
    {
        BLL.Usuario usu = new BLL.Usuario();
        DAL.UsuarioDAL usuDAL = new DAL.UsuarioDAL();
        bool editar = false;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = usuDAL.ConsultarTodos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            usu.NomeUsuario = txtNome.Text;
            usu.Senha = txtNome.Text;
            usu.TipoUsuario = txtTipo.Text;

            if (editar == false)
            {
                usuDAL.Cadastrar(usu);
            }
            else
            {
                usuDAL.Atualizar(usu);                    
            }
            
            MessageBox.Show("Dados Gravados com Sucesso!");

            dgvConsulta.DataSource = usuDAL.ConsultarTodos();
            limpar();
        }

        private void btnLimparAlu_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar()
        {
            txtNome.Text = "";
            txtSenha.Text = "";
            txtTipo.Text = "";
            txtNome.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = usuDAL.ConsultarTodos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este Usuario?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            usu.CodUsuario = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
            usuDAL.Excluir(usu);
            dgvConsulta.DataSource = usuDAL.ConsultarTodos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //executar metodos de retorno
            if (dgvConsulta.RowCount > 0)
            {
                //Executar metodo de retorno dos dadoss
                usu.CodUsuario = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
                usu = usuDAL.RetornarDados(usu);

                //preenchendo txts
                txtNome.Text = usu.NomeUsuario;
                txtSenha.Text = usu.Senha;
                txtTipo.Text = usu.TipoUsuario;

                //redirecionando para a primeira aba
                tabControl1.SelectedTab = tbpCadastro;

                //editar para verdadeiro
                editar = true;
            }
        }
    }
}
