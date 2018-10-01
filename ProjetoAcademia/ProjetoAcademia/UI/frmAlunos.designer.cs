namespace ProjetoAcademia.UI
{
    partial class frmAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.tbcAlunos = new System.Windows.Forms.TabControl();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtDataNascimentoAlu = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailAlu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRgAlu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCpfAlu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeAlu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnLimparAlu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tbcAlunos.SuspendLayout();
            this.tbpCadastro.SuspendLayout();
            this.tbpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lblAlunos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 46);
            this.panel1.TabIndex = 2;
            // 
            // lblAlunos
            // 
            this.lblAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Location = new System.Drawing.Point(254, 9);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(97, 31);
            this.lblAlunos.TabIndex = 0;
            this.lblAlunos.Text = "Alunos";
            this.lblAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbcAlunos
            // 
            this.tbcAlunos.Controls.Add(this.tbpCadastro);
            this.tbcAlunos.Controls.Add(this.tbpConsulta);
            this.tbcAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic);
            this.tbcAlunos.Location = new System.Drawing.Point(0, 46);
            this.tbcAlunos.Name = "tbcAlunos";
            this.tbcAlunos.SelectedIndex = 0;
            this.tbcAlunos.Size = new System.Drawing.Size(603, 476);
            this.tbcAlunos.TabIndex = 3;
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.btnLimparAlu);
            this.tbpCadastro.Controls.Add(this.label3);
            this.tbpCadastro.Controls.Add(this.mtxtDataNascimentoAlu);
            this.tbpCadastro.Controls.Add(this.txtEmailAlu);
            this.tbpCadastro.Controls.Add(this.label7);
            this.tbpCadastro.Controls.Add(this.txtRgAlu);
            this.tbpCadastro.Controls.Add(this.label6);
            this.tbpCadastro.Controls.Add(this.txtCpfAlu);
            this.tbpCadastro.Controls.Add(this.label2);
            this.tbpCadastro.Controls.Add(this.btnCadastrar);
            this.tbpCadastro.Controls.Add(this.txtNomeAlu);
            this.tbpCadastro.Controls.Add(this.label1);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 33);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(595, 439);
            this.tbpCadastro.TabIndex = 0;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Data Nascimento:";
            // 
            // mtxtDataNascimentoAlu
            // 
            this.mtxtDataNascimentoAlu.Location = new System.Drawing.Point(207, 216);
            this.mtxtDataNascimentoAlu.Mask = "00/00/0000";
            this.mtxtDataNascimentoAlu.Name = "mtxtDataNascimentoAlu";
            this.mtxtDataNascimentoAlu.Size = new System.Drawing.Size(114, 29);
            this.mtxtDataNascimentoAlu.TabIndex = 56;
            this.mtxtDataNascimentoAlu.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmailAlu
            // 
            this.txtEmailAlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAlu.Location = new System.Drawing.Point(207, 179);
            this.txtEmailAlu.Name = "txtEmailAlu";
            this.txtEmailAlu.Size = new System.Drawing.Size(199, 29);
            this.txtEmailAlu.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "E-mail:";
            // 
            // txtRgAlu
            // 
            this.txtRgAlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRgAlu.Location = new System.Drawing.Point(207, 143);
            this.txtRgAlu.Name = "txtRgAlu";
            this.txtRgAlu.Size = new System.Drawing.Size(199, 29);
            this.txtRgAlu.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "RG:";
            // 
            // txtCpfAlu
            // 
            this.txtCpfAlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpfAlu.Location = new System.Drawing.Point(207, 108);
            this.txtCpfAlu.Name = "txtCpfAlu";
            this.txtCpfAlu.Size = new System.Drawing.Size(199, 29);
            this.txtCpfAlu.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "CPF:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(207, 302);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 35);
            this.btnCadastrar.TabIndex = 46;
            this.btnCadastrar.Text = "Gravar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // txtNomeAlu
            // 
            this.txtNomeAlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeAlu.Location = new System.Drawing.Point(207, 75);
            this.txtNomeAlu.Name = "txtNomeAlu";
            this.txtNomeAlu.Size = new System.Drawing.Size(346, 29);
            this.txtNomeAlu.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nome:";
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.btnEditar);
            this.tbpConsulta.Controls.Add(this.btnExcluir);
            this.tbpConsulta.Controls.Add(this.txtFiltro);
            this.tbpConsulta.Controls.Add(this.label5);
            this.tbpConsulta.Controls.Add(this.dgvConsulta);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 33);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulta.Size = new System.Drawing.Size(595, 439);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consulta";
            this.tbpConsulta.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(485, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 30);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(381, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 30);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(82, 11);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(280, 29);
            this.txtFiltro.TabIndex = 27;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Filtrar:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(3, 49);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(589, 388);
            this.dgvConsulta.TabIndex = 25;
            // 
            // btnLimparAlu
            // 
            this.btnLimparAlu.Location = new System.Drawing.Point(364, 302);
            this.btnLimparAlu.Name = "btnLimparAlu";
            this.btnLimparAlu.Size = new System.Drawing.Size(114, 35);
            this.btnLimparAlu.TabIndex = 58;
            this.btnLimparAlu.Text = "Limpar";
            this.btnLimparAlu.UseVisualStyleBackColor = true;
            this.btnLimparAlu.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 522);
            this.Controls.Add(this.tbcAlunos);
            this.Controls.Add(this.panel1);
            this.Name = "frmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.frmAlunos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcAlunos.ResumeLayout(false);
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.tbpConsulta.ResumeLayout(false);
            this.tbpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.TabControl tbcAlunos;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.TabPage tbpConsulta;
        private System.Windows.Forms.TextBox txtCpfAlu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeAlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimentoAlu;
        private System.Windows.Forms.TextBox txtEmailAlu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRgAlu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimparAlu;
    }
}