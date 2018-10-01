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
        bool editar = false;

        public frmMatricula()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            mat.CodPlano = Convert.ToInt16(txtCodPla.Text);
            mat.CodAluno = Convert.ToInt16(txtCodAlu.Text);
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
        }

        private void btnLimparAlu_Click(object sender, EventArgs e)
        {
            limpar();  
        }

        public void limpar()
        {
            txtCodPla.Text = "";
            txtCodAlu.Text = "";
            mtxtDataMat.Text = "";
            mtxtDataVenc.Text = "";
            txtCodPla.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            mat.CodPlano = Convert.ToUInt16(txtFiltro.Text);
            dgvConsulta.DataSource = matDAL.ConsultarporNome(mat);
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
                txtCodAlu.Text = Convert.ToInt16(mat.CodAluno).ToString();
                txtCodPla.Text = Convert.ToInt16(mat.CodPlano).ToString();
                mtxtDataMat.Text = Convert.ToDateTime(mat.DataMatricula).ToString();
                mtxtDataVenc.Text = Convert.ToDateTime(mat.DataVencimento).ToString();

                //redirecionando para a primeira aba
                tabMatricula.SelectedTab = tbpCadastro;

                //editar para verdadeiro
                editar = true;
            }
        }
    }
}
