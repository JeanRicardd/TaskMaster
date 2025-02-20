namespace TaskMaster_Dev.Formularios
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.dtListarTarefasPendentes = new System.Windows.Forms.DataGridView();
            this.Titulo_tarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_tarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_tarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao_tarefa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTarefa = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVersionamento = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtListarTarefasRealizadas = new System.Windows.Forms.DataGridView();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerTarefas = new System.Windows.Forms.Timer(this.components);
            this.timerGrid = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtListarTarefasPendentes)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListarTarefasRealizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListarTarefasPendentes
            // 
            this.dtListarTarefasPendentes.AllowUserToAddRows = false;
            this.dtListarTarefasPendentes.AllowUserToDeleteRows = false;
            this.dtListarTarefasPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListarTarefasPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo_tarefa,
            this.Data_tarefa,
            this.Hora_tarefa,
            this.Descricao_tarefa});
            this.dtListarTarefasPendentes.Location = new System.Drawing.Point(3, 3);
            this.dtListarTarefasPendentes.Name = "dtListarTarefasPendentes";
            this.dtListarTarefasPendentes.ReadOnly = true;
            this.dtListarTarefasPendentes.Size = new System.Drawing.Size(628, 308);
            this.dtListarTarefasPendentes.TabIndex = 3;
            this.dtListarTarefasPendentes.DoubleClick += new System.EventHandler(this.dtListarTarefas_DoubleClick);
            // 
            // Titulo_tarefa
            // 
            this.Titulo_tarefa.DataPropertyName = "Titulo_tarefa";
            this.Titulo_tarefa.Frozen = true;
            this.Titulo_tarefa.HeaderText = "Tarefa";
            this.Titulo_tarefa.Name = "Titulo_tarefa";
            this.Titulo_tarefa.ReadOnly = true;
            // 
            // Data_tarefa
            // 
            this.Data_tarefa.DataPropertyName = "Data_tarefa";
            this.Data_tarefa.Frozen = true;
            this.Data_tarefa.HeaderText = "Data da Tarefa";
            this.Data_tarefa.Name = "Data_tarefa";
            this.Data_tarefa.ReadOnly = true;
            // 
            // Hora_tarefa
            // 
            this.Hora_tarefa.DataPropertyName = "Hora_tarefa";
            this.Hora_tarefa.Frozen = true;
            this.Hora_tarefa.HeaderText = "Hora da Tarefa";
            this.Hora_tarefa.Name = "Hora_tarefa";
            this.Hora_tarefa.ReadOnly = true;
            // 
            // Descricao_tarefa
            // 
            this.Descricao_tarefa.DataPropertyName = "Descricao_tarefa";
            this.Descricao_tarefa.Frozen = true;
            this.Descricao_tarefa.HeaderText = "Descricão da Tarefa";
            this.Descricao_tarefa.Name = "Descricao_tarefa";
            this.Descricao_tarefa.ReadOnly = true;
            // 
            // btnAddTarefa
            // 
            this.btnAddTarefa.Location = new System.Drawing.Point(551, 380);
            this.btnAddTarefa.Name = "btnAddTarefa";
            this.btnAddTarefa.Size = new System.Drawing.Size(96, 23);
            this.btnAddTarefa.TabIndex = 2;
            this.btnAddTarefa.Text = "Adicionar tarefa";
            this.btnAddTarefa.UseVisualStyleBackColor = true;
            this.btnAddTarefa.Click += new System.EventHandler(this.btnAddTarefa_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersionamento});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(661, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVersionamento
            // 
            this.lblVersionamento.BackColor = System.Drawing.SystemColors.Control;
            this.lblVersionamento.Name = "lblVersionamento";
            this.lblVersionamento.Size = new System.Drawing.Size(86, 17);
            this.lblVersionamento.Text = "versionamento";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.configuraçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem1});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.configuraçõesToolStripMenuItem.Text = "Mais opções";
            this.configuraçõesToolStripMenuItem.Visible = false;
            // 
            // configuraçõesToolStripMenuItem1
            // 
            this.configuraçõesToolStripMenuItem1.Name = "configuraçõesToolStripMenuItem1";
            this.configuraçõesToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem1.Text = "Configurações";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarCategoriasToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // gerenciarCategoriasToolStripMenuItem
            // 
            this.gerenciarCategoriasToolStripMenuItem.Name = "gerenciarCategoriasToolStripMenuItem";
            this.gerenciarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gerenciarCategoriasToolStripMenuItem.Text = "Gerenciar categorias";
            this.gerenciarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.gerenciarCategoriasToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 340);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtListarTarefasPendentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(633, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtListarTarefasRealizadas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Realizadas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtListarTarefasRealizadas
            // 
            this.dtListarTarefasRealizadas.AllowUserToAddRows = false;
            this.dtListarTarefasRealizadas.AllowUserToDeleteRows = false;
            this.dtListarTarefasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListarTarefasRealizadas.Location = new System.Drawing.Point(3, 3);
            this.dtListarTarefasRealizadas.Name = "dtListarTarefasRealizadas";
            this.dtListarTarefasRealizadas.ReadOnly = true;
            this.dtListarTarefasRealizadas.Size = new System.Drawing.Size(628, 308);
            this.dtListarTarefasRealizadas.TabIndex = 7;
            this.dtListarTarefasRealizadas.DoubleClick += new System.EventHandler(this.dtListarTarefasRealizadas_DoubleClick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // TimerTarefas
            // 
            this.TimerTarefas.Enabled = true;
            this.TimerTarefas.Interval = 3000;
            this.TimerTarefas.Tick += new System.EventHandler(this.TimerTarefas_Tick);
            // 
            // timerGrid
            // 
            this.timerGrid.Enabled = true;
            this.timerGrid.Interval = 3000;
            this.timerGrid.Tick += new System.EventHandler(this.timerGrid_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(661, 434);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAddTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskMaster-Dev";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Resize += new System.EventHandler(this.FormPrincipal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dtListarTarefasPendentes)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListarTarefasRealizadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListarTarefasPendentes;
        private System.Windows.Forms.Button btnAddTarefa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVersionamento;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtListarTarefasRealizadas;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer TimerTarefas;
        private System.Windows.Forms.Timer timerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo_tarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_tarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_tarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao_tarefa;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarCategoriasToolStripMenuItem;
    }
}