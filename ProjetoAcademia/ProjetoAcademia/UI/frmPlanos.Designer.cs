namespace ProjetoAcademia.UI
{
    partial class frmPlanos
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorPla = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomePla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.sifra = new System.Windows.Forms.Label();
            this.btnLimparAlu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.tbpCadastro.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(485, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 30);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Gray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(381, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 30);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(82, 11);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(280, 29);
            this.txtFiltro.TabIndex = 27;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.dgvConsulta);
            this.tbpConsulta.Controls.Add(this.btnEditar);
            this.tbpConsulta.Controls.Add(this.btnExcluir);
            this.tbpConsulta.Controls.Add(this.txtFiltro);
            this.tbpConsulta.Controls.Add(this.label5);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 33);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulta.Size = new System.Drawing.Size(590, 278);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consulta";
            this.tbpConsulta.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(0, 49);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(594, 229);
            this.dgvConsulta.TabIndex = 25;
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
            // txtValorPla
            // 
            this.txtValorPla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorPla.Location = new System.Drawing.Point(177, 89);
            this.txtValorPla.Name = "txtValorPla";
            this.txtValorPla.Size = new System.Drawing.Size(146, 29);
            this.txtValorPla.TabIndex = 48;
            this.txtValorPla.TextChanged += new System.EventHandler(this.txtValorPla_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Gray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(157, 187);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 35);
            this.btnCadastrar.TabIndex = 46;
            this.btnCadastrar.Text = "Gravar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNomePla
            // 
            this.txtNomePla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomePla.Location = new System.Drawing.Point(177, 39);
            this.txtNomePla.Name = "txtNomePla";
            this.txtNomePla.Size = new System.Drawing.Size(391, 29);
            this.txtNomePla.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nome do Plano:";
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.sifra);
            this.tbpCadastro.Controls.Add(this.btnLimparAlu);
            this.tbpCadastro.Controls.Add(this.txtValorPla);
            this.tbpCadastro.Controls.Add(this.label2);
            this.tbpCadastro.Controls.Add(this.btnCadastrar);
            this.tbpCadastro.Controls.Add(this.txtNomePla);
            this.tbpCadastro.Controls.Add(this.label1);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 33);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(590, 278);
            this.tbpCadastro.TabIndex = 0;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // sifra
            // 
            this.sifra.AutoSize = true;
            this.sifra.Location = new System.Drawing.Point(329, 91);
            this.sifra.Name = "sifra";
            this.sifra.Size = new System.Drawing.Size(33, 24);
            this.sifra.TabIndex = 64;
            this.sifra.Text = "R$";
            this.sifra.Click += new System.EventHandler(this.sifra_Click);
            // 
            // btnLimparAlu
            // 
            this.btnLimparAlu.BackColor = System.Drawing.Color.Gray;
            this.btnLimparAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparAlu.ForeColor = System.Drawing.Color.Black;
            this.btnLimparAlu.Location = new System.Drawing.Point(313, 187);
            this.btnLimparAlu.Name = "btnLimparAlu";
            this.btnLimparAlu.Size = new System.Drawing.Size(114, 35);
            this.btnLimparAlu.TabIndex = 63;
            this.btnLimparAlu.Text = "Limpar";
            this.btnLimparAlu.UseVisualStyleBackColor = false;
            this.btnLimparAlu.Click += new System.EventHandler(this.btnLimparAlu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Valor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpCadastro);
            this.tabControl1.Controls.Add(this.tbpConsulta);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic);
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 315);
            this.tabControl1.TabIndex = 5;
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
            this.lblAlunos.Text = "Planos";
            this.lblAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblAlunos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 46);
            this.panel1.TabIndex = 4;
            // 
            // frmPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(598, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPlanos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPlanos_Load);
            this.tbpConsulta.ResumeLayout(false);
            this.tbpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TabPage tbpConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorPla;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomePla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimparAlu;
        private System.Windows.Forms.Label sifra;
        private System.Windows.Forms.DataGridView dgvConsulta;
    }
}