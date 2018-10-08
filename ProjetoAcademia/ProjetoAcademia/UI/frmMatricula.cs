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
    public partial class frmMatricula : Form
    {
        BLL.Matricula mat = new BLL.Matricula();
        DAL.MatriculaDAL matDAL = new DAL.MatriculaDAL();

        //importando as classes DAL e BLL plano
        BLL.plano plano = new BLL.plano();
        DAL.PlanoDAL planoDAL = new DAL.PlanoDAL();

        //importando as classes DAL e BLL aluno
        BLL.Aluno aluno = new BLL.Aluno();
        DAL.AlunoDAL alunoDAL = new DAL.AlunoDAL();

        bool editar = false;

        public frmMatricula()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            mat.CodPlano = Convert.ToInt16(cmbPlano.SelectedValue);
            mat.CodAluno = Convert.ToInt16(cmbAluno.SelectedValue);
            mat.DataMatricula = Convert.ToDateTime(mtxtDataMat.Text);
            mat.DataVencimento = Convert.ToDateTime(mtxtDataVenc.Text);

            if (editar == false)
            {
                matDAL.Cadastrar(mat);
            }
            else
            {
                matDAL.Atualizar(mat);
            }

            MessageBox.Show("Dados Gravados com Sucesso!");

            dgvConsulta.DataSource = matDAL.ConsultarTodos();
            limpar();
        }

        private void frmMatricula_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = matDAL.ConsultarTodos();

            //preeencher planos combobox
            cmbPlano.DataSource = planoDAL.ConsultarTodos();
            cmbPlano.DisplayMember = "Nome do Plano";//O que aparece
            cmbPlano.ValueMember = "Código";///o que pega

            //preeencher alunos do combobox
            cmbAluno.DataSource = alunoDAL.ConsultarTodos();
            cmbAluno.DisplayMember = "Nome";//O que aparece
            cmbAluno.ValueMember = "Código";///o que pega


        }

        private void btnLimparAlu_Click(object sender, EventArgs e)
        {
            limpar();  
        }

        public void limpar()
        {
            cmbPlano.Text = "";
            cmbAluno.Text = "";
            mtxtDataMat.Text = "";
            mtxtDataVenc.Text = "";
            mtxtDataMat.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            aluno.Nome = txtFiltro.Text;
            dgvConsulta.DataSource = matDAL.ConsultarporNome(aluno);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esta Matricula?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            mat.CodMatricula = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
            matDAL.Excluir(mat);
            dgvConsulta.DataSource = matDAL.ConsultarTodos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //executar metodos de retorno
            if (dgvConsulta.RowCount > 0)
            {
                //Executar metodo de retorno dos dadoss
                mat.CodMatricula = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
                mat = matDAL.RetornarDados(mat);

                //preenchendo txts
                cmbAluno.SelectedValue = mat.CodAluno;
                cmbPlano.SelectedValue = mat.CodPlano;
                mtxtDataMat.Text = Convert.ToDateTime(mat.DataMatricula).ToString();
                mtxtDataVenc.Text = Convert.ToDateTime(mat.DataVencimento).ToString();

                //redirecionando para a primeira aba
                tabMatricula.SelectedTab = tbpCadastro;

                //editar para verdadeiro
                editar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void mtxtDataVenc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
