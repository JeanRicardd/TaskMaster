namespace TaskMaster_Dev.Formularios
{
    partial class FormAddTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTarefa));
            this.btnCriarTarefa = new System.Windows.Forms.Button();
            this.txtHoraInicioTarefa = new System.Windows.Forms.MaskedTextBox();
            this.txtTituloTarefa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.dtTarefa = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescricaoTarefa = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkHabilitarEdicao = new System.Windows.Forms.CheckBox();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarTarefa
            // 
            this.btnCriarTarefa.Location = new System.Drawing.Point(538, 274);
            this.btnCriarTarefa.Name = "btnCriarTarefa";
            this.btnCriarTarefa.Size = new System.Drawing.Size(75, 23);
            this.btnCriarTarefa.TabIndex = 0;
            this.btnCriarTarefa.Text = "Criar tarefa";
            this.btnCriarTarefa.UseVisualStyleBackColor = true;
            this.btnCriarTarefa.Click += new System.EventHandler(this.btnCriarTarefa_Click);
            // 
            // txtHoraInicioTarefa
            // 
            this.txtHoraInicioTarefa.Location = new System.Drawing.Point(389, 7);
            this.txtHoraInicioTarefa.Mask = "90:00";
            this.txtHoraInicioTarefa.Name = "txtHoraInicioTarefa";
            this.txtHoraInicioTarefa.Size = new System.Drawing.Size(34, 20);
            this.txtHoraInicioTarefa.TabIndex = 1;
            this.txtHoraInicioTarefa.ValidatingType = typeof(System.DateTime);
            // 
            // txtTituloTarefa
            // 
            this.txtTituloTarefa.Location = new System.Drawing.Point(12, 7);
            this.txtTituloTarefa.Name = "txtTituloTarefa";
            this.txtTituloTarefa.Size = new System.Drawing.Size(291, 20);
            this.txtTituloTarefa.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.dtTarefa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtTituloTarefa);
            this.panel1.Controls.Add(this.txtHoraInicioTarefa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 256);
            this.panel1.TabIndex = 3;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(429, 6);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(163, 21);
            this.cbCategoria.TabIndex = 8;
            // 
            // dtTarefa
            // 
            this.dtTarefa.Location = new System.Drawing.Point(312, 7);
            this.dtTarefa.Mask = "00/00/0000";
            this.dtTarefa.Name = "dtTarefa";
            this.dtTarefa.Size = new System.Drawing.Size(71, 20);
            this.dtTarefa.TabIndex = 7;
            this.dtTarefa.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição da tarefa (opcional):";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDescricaoTarefa);
            this.panel2.Location = new System.Drawing.Point(5, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 205);
            this.panel2.TabIndex = 4;
            // 
            // txtDescricaoTarefa
            // 
            this.txtDescricaoTarefa.Location = new System.Drawing.Point(3, 7);
            this.txtDescricaoTarefa.Name = "txtDescricaoTarefa";
            this.txtDescricaoTarefa.Size = new System.Drawing.Size(583, 193);
            this.txtDescricaoTarefa.TabIndex = 0;
            this.txtDescricaoTarefa.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titulo da tarefa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inicio da tarefa:";
            // 
            // chkHabilitarEdicao
            // 
            this.chkHabilitarEdicao.AutoSize = true;
            this.chkHabilitarEdicao.Location = new System.Drawing.Point(12, 278);
            this.chkHabilitarEdicao.Name = "chkHabilitarEdicao";
            this.chkHabilitarEdicao.Size = new System.Drawing.Size(100, 17);
            this.chkHabilitarEdicao.TabIndex = 5;
            this.chkHabilitarEdicao.Text = "Habilitar Edição";
            this.chkHabilitarEdicao.UseVisualStyleBackColor = true;
            this.chkHabilitarEdicao.Visible = false;
            this.chkHabilitarEdicao.CheckedChanged += new System.EventHandler(this.chkHabilitarEdicao_CheckedChanged);
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.Location = new System.Drawing.Point(118, 274);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(87, 23);
            this.btnExcluirTarefa.TabIndex = 6;
            this.btnExcluirTarefa.Text = "Excluir tarefa";
            this.btnExcluirTarefa.UseVisualStyleBackColor = true;
            this.btnExcluirTarefa.Visible = false;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.cbStatus.Enabled = false;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(415, 276);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(117, 21);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(369, 279);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            this.lblStatus.Visible = false;
            // 
            // FormAddTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(625, 309);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnExcluirTarefa);
            this.Controls.Add(this.chkHabilitarEdicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCriarTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar tarefa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddTarefa_FormClosing);
            this.Load += new System.EventHandler(this.FormAddTarefa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarTarefa;
        private System.Windows.Forms.MaskedTextBox txtHoraInicioTarefa;
        private System.Windows.Forms.TextBox txtTituloTarefa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtDescricaoTarefa;
        private System.Windows.Forms.CheckBox chkHabilitarEdicao;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.MaskedTextBox dtTarefa;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
    }
}