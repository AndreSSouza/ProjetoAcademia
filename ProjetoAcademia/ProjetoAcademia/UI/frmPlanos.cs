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
    public partial class frmPlanos : Form
    {
        BLL.plano pla = new BLL.plano();
        DAL.PlanoDAL plaDAL = new DAL.PlanoDAL();
        bool editar = false;
 
        public frmPlanos()
        {
            InitializeComponent();
        }

        private void frmPlanos_Load(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = plaDAL.ConsultarTodos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pla.NomePlano = txtNomePla.Text;
            pla.ValorPlano = Convert.ToDecimal(txtValorPla.Text);
            
            if (editar == false)
            {
                plaDAL.Cadastrar(pla);
            }
            else
            {
                plaDAL.Atualizar(pla);
            }

            MessageBox.Show("Dados Gravados com Sucesso!");

            dgvConsulta.DataSource = plaDAL.ConsultarTodos();
            limpar();
        }

        private void btnLimparAlu_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar()
        {
            txtNomePla.Text = "";
            txtValorPla.Text = "";
            txtNomePla.Focus();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            pla.NomePlano = txtFiltro.Text;
            dgvConsulta.DataSource = plaDAL.ConsultarPorNome(pla);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este plano?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            pla.CodPlano = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
            plaDAL.Excluir(pla);
            dgvConsulta.DataSource = plaDAL.ConsultarTodos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //executar metodos de retorno
            if (dgvConsulta.RowCount > 0)
            {
                //Executar metodo de retorno dos dadoss
                pla.CodPlano = Convert.ToInt16(dgvConsulta.SelectedCells[0].Value);
                pla = plaDAL.RetornarDados(pla);

                //preenchendo txts
                txtNomePla.Text = pla.NomePlano;
                txtValorPla.Text = Convert.ToDecimal(pla.ValorPlano).ToString();

                //redirecionando para a primeira aba
                tabControl1.SelectedTab = tbpCadastro;

                //editar para verdadeiro
                editar = true;
            }
        }
    }
}
