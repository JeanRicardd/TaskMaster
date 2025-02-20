using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMaster_Dev.Classes;
using TaskMaster_Dev.Formularios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TaskMaster_Dev.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {

            InitializeComponent();
            VerificarExistenciaBaseDados();
            NotificacaoMinimizado();
            Variaveis_Static.Decisao_Form = 0;
        }

        void NotificacaoMinimizado()
        {
            // Configurar NotifyIcon
            notifyIcon.Icon = this.Icon; // Substitua pelo ícone desejado
            notifyIcon.Text = "TaskMaster";
            notifyIcon.Visible = true;
            notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            NotificacaoIcone_1();
        }

        private void VerificarExistenciaBaseDados()
        {
            Funcoes f = new Funcoes();

            var localidade = "./dados/basedados.sqlite";

            // Verifica se a pasta existe, se não, cria a pasta
            var pasta = Path.GetDirectoryName(localidade);
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(localidade))
            {
                try
                {
                    SQLiteConnection.CreateFile(localidade);
                    f.CriarTabelaTarefas();
                    MessageBox.Show("Não foi encontrada uma base de dados, por isso, foi criada uma nova base", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void ListarNaGridTodasAsTarefasPendentes()
        {
            dtListarTarefasPendentes.DataSource = null;
            // Vincule os dados ao DataGridView
            Funcoes f = new Funcoes();
            BindingSource bs = new BindingSource();
            DataTable dt = f.ListarTodasTarefasPendentes();

            bs.DataSource = dt;
            dtListarTarefasPendentes.DataSource = bs;

            // Esconda a coluna "id"
            dtListarTarefasPendentes.Columns["Id_tarefa"].Visible = false;
            dtListarTarefasPendentes.Columns["Data_tarefa"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dtListarTarefasPendentes.Columns["Titulo_tarefa"].HeaderText = "Titulo da Tarefa";
            dtListarTarefasPendentes.Columns["Data_tarefa"].HeaderText = "Data";
            dtListarTarefasPendentes.Columns["Hora_tarefa"].HeaderText = "Horário";
            dtListarTarefasPendentes.Columns["Descricao_tarefa"].HeaderText = "Descrição";
            dtListarTarefasPendentes.Columns["Categoria_tarefa"].HeaderText = "Categoria";
            dtListarTarefasPendentes.Columns["Status_tarefa"].HeaderText = "Status";

        }

        private void ListarNaGridTodasAsTarefasRealizadas()
        {
            dtListarTarefasRealizadas.DataSource = null;
            // Vincule os dados ao DataGridView
            Funcoes f = new Funcoes();
            BindingSource bs = new BindingSource();
            DataTable dt = f.ListarTodasTarefasRealizadas();

            bs.DataSource = dt;
            dtListarTarefasRealizadas.DataSource = bs;

            // Esconda a coluna "id"
            dtListarTarefasRealizadas.Columns["Id_tarefa"].Visible = false;
            dtListarTarefasRealizadas.Columns["Data_tarefa"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dtListarTarefasRealizadas.Columns["Titulo_tarefa"].HeaderText = "Titulo da Tarefa";
            dtListarTarefasRealizadas.Columns["Data_tarefa"].HeaderText = "Data";
            dtListarTarefasRealizadas.Columns["Hora_tarefa"].HeaderText = "Horário";
            dtListarTarefasRealizadas.Columns["Descricao_tarefa"].HeaderText = "Descrição";
            dtListarTarefasRealizadas.Columns["Categoria_tarefa"].HeaderText = "Categoria";
            dtListarTarefasRealizadas.Columns["Status_tarefa"].HeaderText = "Status";
        }

        private void btnAddTarefa_Click(object sender, EventArgs e)
        {
            Formularios.FormAddTarefa formAddTarefa = new FormAddTarefa();
            formAddTarefa.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Inicia minimizado
            this.Hide(); // Oculta a janela
            this.ShowInTaskbar = false;

            ListarNaGridTodasAsTarefasPendentes();
            ListarNaGridTodasAsTarefasRealizadas();
            Version versao = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersionamento.Text = "Versão: " + versao.ToString();
        }

        private void dtListarTarefas_DoubleClick(object sender, EventArgs e)
        {
            if (dtListarTarefasPendentes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dtListarTarefasPendentes.SelectedRows[0];
                Variaveis_Static.Decisao_Form = 1;
                Variaveis_Static.Id_tarefa_static = Int32.Parse(row.Cells[0].Value.ToString());
                Variaveis_Static.Titulo_tarefa_static = row.Cells[1].Value.ToString();
                Variaveis_Static.Data_tarefa_static = row.Cells[2].Value.ToString();
                Variaveis_Static.Hora_tarefa_static = row.Cells[3].Value.ToString();
                Variaveis_Static.Descricao_tarefa_static = row.Cells[4].Value.ToString();
                Variaveis_Static.Status_tarefa_static = row.Cells[5].Value.ToString();
                Variaveis_Static.Categoria_tarefa_static = row.Cells[6].Value.ToString();

                //Interpretar se alguma das variáveis estão preenchidas, caso contrario, deverá mostrar mensagem de erro
                string data = Variaveis_Static.Data_tarefa_static.ToString();

                if (data == string.Empty)
                {
                    MessageBox.Show("Nenhum resultado encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    return;
                }

                FormAddTarefa formAddTarefa = new FormAddTarefa();
                FormAlertaTarefa formAlertaTarefa = new FormAlertaTarefa();
                formAddTarefa.DadosAtualizados += ListarNaGridTodasAsTarefasPendentes; 
                formAddTarefa.DadosAtualizados += ListarNaGridTodasAsTarefasRealizadas;
                formAlertaTarefa.DadosAtualizados += ListarNaGridTodasAsTarefasRealizadas;
                formAlertaTarefa.DadosAtualizados += ListarNaGridTodasAsTarefasPendentes;
                formAddTarefa.DadosExcluidos += ListarNaGridTodasAsTarefasPendentes;
                formAddTarefa.DadosExcluidos += ListarNaGridTodasAsTarefasRealizadas;
                formAddTarefa.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Restaurar o formulário ao clicar duas vezes no ícone da bandeja
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        void NotificacaoIcone_1()
        {
            notifyIcon.BalloonTipTitle = "TaskMaster";
            notifyIcon.BalloonTipText = "Aplicação iniciada minimizada ";
            notifyIcon.Icon = this.Icon;
            notifyIcon.ShowBalloonTip(3000);
        }



        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // Exibe uma notificação ao minimizar
                notifyIcon.Visible = true;
                this.Hide(); // Oculta a janela
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza de que deseja fechar a aplicação?", "Fechar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true; // Cancela o evento de fechamento do formulário
            }
        }

        private List<int> tarefasNotificadas5M = new List<int>();
        private List<int> tarefasNotificadas = new List<int>();

        private void TimerTarefas_Tick(object sender, EventArgs e)
        {
            /*
            DateTime agora = DateTime.Now;
            TimeSpan intervalo = TimeSpan.FromMinutes(5);
            TaskRepository taskRepository = new TaskRepository();

            DataTable tarefasProximas = taskRepository.ObterTarefasProximas(agora, intervalo);

            // Obtém tarefas agendadas para o exato momento
            DataTable tarefasExatas = taskRepository.ObterTarefasExatas(agora);

            foreach (DataRow row in tarefasProximas.Rows)
            {
                int idTarefa = Convert.ToInt32(row["Id_tarefa"]);

                // Verifica se a tarefa já foi notificada
                if (!tarefasNotificadas5M.Contains(idTarefa))
                {
                    MostrarAlerta(row);
                    tarefasNotificadas5M.Add(idTarefa); // Marca como notificada
                }
            }

            // Notificar a tarefa na hora exata
            foreach (DataRow row in tarefasExatas.Rows)
            {
                int idTarefa = Convert.ToInt32(row["Id_tarefa"]);

                // Verifica se a tarefa já foi notificada
                if (!tarefasNotificadas.Contains(idTarefa))
                {
                    string descricao = row["Titulo_tarefa"].ToString();
                    DateTime dataTarefa = Convert.ToDateTime(row["Data_tarefa"]);
                    TimeSpan horaTarefa = TimeSpan.Parse(row["Hora_tarefa"].ToString());

                    // Atualiza as variáveis estáticas com os dados da tarefa
                    Variaveis_Static.Titulo_tarefa_static = descricao;
                    Variaveis_Static.Data_tarefa_static = dataTarefa.ToString("dd/MM/yyyy");
                    Variaveis_Static.Hora_tarefa_static = horaTarefa.ToString();

                    // Mostra o formulário de notificação
                    using (FormAlertaTarefa formAlertaTarefa = new FormAlertaTarefa())
                    {
                        formAlertaTarefa.ShowDialog();
                    }

                    // Adiciona a tarefa à lista de notificadas
                    tarefasNotificadas.Add(idTarefa);
                }
            }*/

            try
            {
                // Obtem o horário atual
                DateTime agora = DateTime.Now;
                TimeSpan intervalo = TimeSpan.FromMinutes(5);
                TaskRepository taskRepository = new TaskRepository();

                // Obtém tarefas próximas
                DataTable tarefasProximas = taskRepository.ObterTarefasProximas(agora, intervalo);

                foreach (DataRow row in tarefasProximas.Rows)
                {
                    int idTarefa = Convert.ToInt32(row["Id_tarefa"]);

                    // Verifica se já foi notificada nos últimos 5 minutos
                    if (!tarefasNotificadas5M.Contains(idTarefa))
                    {
                        MostrarAlerta(row);
                        tarefasNotificadas5M.Add(idTarefa); // Marca como notificada
                    }
                }

                // Obtém tarefas exatas
                DataTable tarefasExatas = taskRepository.ObterTarefasExatas(agora);

                foreach (DataRow row in tarefasExatas.Rows)
                {
                    int idTarefa = Convert.ToInt32(row["Id_tarefa"]);

                    // Verifica se já foi notificada no momento exato
                    if (!tarefasNotificadas.Contains(idTarefa))
                    {
                        string titulo = row["Titulo_tarefa"].ToString();
                        string descricao = row["Descricao_tarefa"].ToString();
                        string categoria = row["Categoria_tarefa"].ToString();
                        DateTime dataTarefa = Convert.ToDateTime(row["Data_tarefa"]);
                        TimeSpan horaTarefa = TimeSpan.Parse(row["Hora_tarefa"].ToString());


                        // Atualiza variáveis estáticas
                        Variaveis_Static.Titulo_tarefa_static = titulo;
                        Variaveis_Static.Descricao_tarefa_static = descricao;
                        Variaveis_Static.Data_tarefa_static = dataTarefa.ToString("dd/MM/yyyy");
                        Variaveis_Static.Hora_tarefa_static = horaTarefa.ToString();

                        // Desativa temporariamente o Timer durante a exibição do formulário
                        TimerTarefas.Enabled = false;
                        try
                        {
                            using (FormAlertaTarefa formAlertaTarefa = new FormAlertaTarefa())
                            {
                                formAlertaTarefa.ShowDialog();
                            }
                        }
                        finally
                        {
                            TimerTarefas.Enabled = true; // Reativa o Timer
                        }

                        // Adiciona a tarefa à lista de notificadas
                        tarefasNotificadas.Add(idTarefa);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no Timer: {ex.Message}");
            }

        }

        private void MostrarAlerta(DataRow tarefa)
        {
            string descricao = tarefa["Titulo_tarefa"].ToString();
            DateTime dataTarefa = Convert.ToDateTime(tarefa["Data_tarefa"]);
            TimeSpan horaTarefa = TimeSpan.Parse(tarefa["Hora_tarefa"].ToString());

            notifyIcon.BalloonTipTitle = "TaskMaster";
            notifyIcon.BalloonTipText = $"Tarefa: {descricao}\nData: {dataTarefa:dd/MM/yyyy}\nHora: {horaTarefa}";
            notifyIcon.Icon = this.Icon;
            notifyIcon.ShowBalloonTip(3000);
        }

        private void dtListarTarefasRealizadas_DoubleClick(object sender, EventArgs e)
        {
            if (dtListarTarefasRealizadas.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dtListarTarefasRealizadas.SelectedRows[0];
                Variaveis_Static.Decisao_Form = 1;
                Variaveis_Static.Id_tarefa_static = Int32.Parse(row.Cells[0].Value.ToString());
                Variaveis_Static.Titulo_tarefa_static = row.Cells[1].Value.ToString();
                Variaveis_Static.Data_tarefa_static = row.Cells[2].Value.ToString();
                Variaveis_Static.Hora_tarefa_static = row.Cells[3].Value.ToString();
                Variaveis_Static.Descricao_tarefa_static = row.Cells[4].Value.ToString();
                Variaveis_Static.Status_tarefa_static = row.Cells[5].Value.ToString();

                //Interpretar se alguma das variáveis estão preenchidas, caso contrario, deverá mostrar mensagem de erro
                string data = Variaveis_Static.Data_tarefa_static.ToString();

                if (data == string.Empty)
                {
                    MessageBox.Show("Nenhum resultado encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FormAddTarefa formAddTarefa = new FormAddTarefa();
                FormAlertaTarefa formAlertaTarefa = new FormAlertaTarefa();
                formAlertaTarefa.DadosAtualizados += ListarNaGridTodasAsTarefasRealizadas;
                formAlertaTarefa.DadosAtualizados += ListarNaGridTodasAsTarefasPendentes;
                formAddTarefa.DadosAtualizados += ListarNaGridTodasAsTarefasPendentes;
                formAddTarefa.DadosAtualizados += ListarNaGridTodasAsTarefasRealizadas;
                formAddTarefa.DadosExcluidos += ListarNaGridTodasAsTarefasPendentes;
                formAddTarefa.DadosExcluidos += ListarNaGridTodasAsTarefasRealizadas;

                formAddTarefa.ShowDialog();
            }
        }

        private void timerGrid_Tick(object sender, EventArgs e)
        {
            ListarNaGridTodasAsTarefasPendentes();
            ListarNaGridTodasAsTarefasRealizadas();
        }

        private void gerenciarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciarCategorias formGerenciarCategorias = new FormGerenciarCategorias();
            formGerenciarCategorias.ShowDialog();
        }
    }
}
