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
    public partial class frmAlunos : Form
    {
        BLL.Aluno alu = new BLL.Aluno();
        DAL.AlunoDAL aluDAL = new DAL.AlunoDAL();
        bool editar = false;

        public frmAlunos()
        {
            InitializeComponent();
        }

        public void limpar()
        {
            txtNomeAlu.Text = "";
            txtRgAlu.Text = "";
            txtEmailAlu.Text = "";
            txtCpfAlu.Text = "";
            mtxtDataNascimentoAlu.Text = "";
            txtNomeAlu.Focus();
            editar = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {

        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = aluDAL.ConsultarTodos();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            alu.Nome = txtNomeAlu.Text;
            alu.Cpf = txtCpfAlu.Text;
            alu.Rg = txtRgAlu.Text;
            alu.Email = txtEmailAlu.Text;
            alu.DataNascimento = Convert.ToDateTime(mtxtDataNascimentoAlu.Text);

            if (editar == false)
            {
                aluDAL.Cadastrar(alu);
            }
            else
            {
                aluDAL.Atualizar(alu);
            }            

            MessageBox.Show("Dados Gravados com Sucesso!");
            
            dgvConsulta.DataSource = aluDAL.ConsultarTodos();
            limpar();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este aluno?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            alu.CodAluno = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
            aluDAL.Excluir(alu);
            dgvConsulta.DataSource = aluDAL.ConsultarTodos();
        }

        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            alu.Nome = txtFiltro.Text;
            dgvConsulta.DataSource = aluDAL.ConsultarPorNome(alu);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            //executar metodos de retorno
            if (dgvConsulta.RowCount > 0)
            {
                //Executar metodo de retorno dos dadoss
                alu.CodAluno = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
                alu = aluDAL.RetornarDados(alu);

                //preenchendo txts
                txtNomeAlu.Text = alu.Nome;
                txtRgAlu.Text = alu.Rg;
                txtEmailAlu.Text = alu.Email;
                txtCpfAlu.Text = alu.Cpf;
                mtxtDataNascimentoAlu.Text = Convert.ToDateTime(alu.DataNascimento).ToString();                
                //redirecionando para a primeira aba
                tbcAlunos.SelectedTab = tbpCadastro;

                //editar para verdadeiro
                editar = true;
            }
        }
    }
}
