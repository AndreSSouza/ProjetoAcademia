namespace ProjetoAcademia.UI
{
    partial class frmPrincipal
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
            this.btnMatriculas = new System.Windows.Forms.Button();
            this.btnPlanos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMatriculas
            // 
            this.btnMatriculas.BackColor = System.Drawing.Color.Gray;
            this.btnMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatriculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnMatriculas.Location = new System.Drawing.Point(612, 12);
            this.btnMatriculas.Name = "btnMatriculas";
            this.btnMatriculas.Size = new System.Drawing.Size(177, 43);
            this.btnMatriculas.TabIndex = 3;
            this.btnMatriculas.Text = "Matriculas";
            this.btnMatriculas.UseVisualStyleBackColor = false;
            this.btnMatriculas.Click += new System.EventHandler(this.btnMatriculas_Click);
            // 
            // btnPlanos
            // 
            this.btnPlanos.BackColor = System.Drawing.Color.Gray;
            this.btnPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnPlanos.Location = new System.Drawing.Point(416, 12);
            this.btnPlanos.Name = "btnPlanos";
            this.btnPlanos.Size = new System.Drawing.Size(177, 43);
            this.btnPlanos.TabIndex = 2;
            this.btnPlanos.Text = "Planos";
            this.btnPlanos.UseVisualStyleBackColor = false;
            this.btnPlanos.Click += new System.EventHandler(this.btnPlanos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Gray;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnUsuarios.Location = new System.Drawing.Point(24, 12);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(177, 43);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.Gray;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnAluno.ForeColor = System.Drawing.Color.Black;
            this.btnAluno.Location = new System.Drawing.Point(220, 12);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(177, 43);
            this.btnAluno.TabIndex = 0;
            this.btnAluno.Text = "Alunos";
            this.btnAluno.UseVisualStyleBackColor = false;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoAcademia.Properties.Resources.academia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 796);
            this.Controls.Add(this.btnMatriculas);
            this.Controls.Add(this.btnPlanos);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnUsuarios);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMatriculas;
        private System.Windows.Forms.Button btnPlanos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnAluno;
    }
}