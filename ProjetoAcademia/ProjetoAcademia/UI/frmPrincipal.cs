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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void matriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            UI.frmAlunos alu = new UI.frmAlunos();
            alu.MdiParent = this;
            alu.Show();
        }

        private void btnPlanos_Click(object sender, EventArgs e)
        {
            UI.frmPlanos pla = new UI.frmPlanos();
            pla.MdiParent = this;
            pla.Show();

        }

        private void btnMatriculas_Click(object sender, EventArgs e)
        {
            UI.frmMatricula mat = new frmMatricula();
            mat.MdiParent = this;
            mat.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UI.frmUsuarios usu = new frmUsuarios();
            usu.MdiParent = this;
            usu.Show();
        }
    }
}
