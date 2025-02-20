namespace TaskMaster_Dev.Formularios
{
    partial class FormGerenciarCategorias
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
            this.btnInserirCategoria = new System.Windows.Forms.Button();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.dtListarCategorias = new System.Windows.Forms.DataGridView();
            this.btnExcluirCategoria = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtListarCategorias)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserirCategoria
            // 
            this.btnInserirCategoria.Location = new System.Drawing.Point(282, 12);
            this.btnInserirCategoria.Name = "btnInserirCategoria";
            this.btnInserirCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnInserirCategoria.TabIndex = 0;
            this.btnInserirCategoria.Text = "Inserir";
            this.btnInserirCategoria.UseVisualStyleBackColor = true;
            this.btnInserirCategoria.Click += new System.EventHandler(this.btnInserirCategoria_Click);
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(15, 14);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(261, 20);
            this.txtNomeCategoria.TabIndex = 1;
            // 
            // dtListarCategorias
            // 
            this.dtListarCategorias.AllowUserToAddRows = false;
            this.dtListarCategorias.AllowUserToDeleteRows = false;
            this.dtListarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListarCategorias.Location = new System.Drawing.Point(12, 78);
            this.dtListarCategorias.Name = "dtListarCategorias";
            this.dtListarCategorias.ReadOnly = true;
            this.dtListarCategorias.Size = new System.Drawing.Size(371, 215);
            this.dtListarCategorias.TabIndex = 2;
            this.dtListarCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListarCategorias_CellClick);
            this.dtListarCategorias.Click += new System.EventHandler(this.dtListarCategorias_Click);
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.Location = new System.Drawing.Point(12, 296);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(98, 23);
            this.btnExcluirCategoria.TabIndex = 3;
            this.btnExcluirCategoria.Text = "Excluir categoria";
            this.btnExcluirCategoria.UseVisualStyleBackColor = true;
            this.btnExcluirCategoria.Visible = false;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnInserirCategoria);
            this.panel1.Controls.Add(this.txtNomeCategoria);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 46);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome da categoria:";
            // 
            // FormGerenciarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcluirCategoria);
            this.Controls.Add(this.dtListarCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormGerenciarCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar categorias de tarefas";
            this.Click += new System.EventHandler(this.FormGerenciarCategorias_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtListarCategorias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserirCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.DataGridView dtListarCategorias;
        private System.Windows.Forms.Button btnExcluirCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}