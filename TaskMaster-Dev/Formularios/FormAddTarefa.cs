using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMaster_Dev.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskMaster_Dev.Formularios
{
    public partial class FormAddTarefa : Form
    {
        public event Action DadosAtualizados; public event Action DadosExcluidos;

        public FormAddTarefa()
        {
            InitializeComponent(); txtHoraInicioTarefa.Text = "00:00";
            this.Text = "TaskMaster - Adicionar nova tarefa";
            FormAtualizarExcluirInformacao();
        }

        private void CarregarInformacoesTarefa()
        {
            txtTituloTarefa.Text = Variaveis_Static.Titulo_tarefa_static;
            txtDescricaoTarefa.Text = Variaveis_Static.Descricao_tarefa_static;
            txtHoraInicioTarefa.Text = Variaveis_Static.Hora_tarefa_static;
            dtTarefa.Text = Variaveis_Static.Data_tarefa_static;
            cbStatus.Text = Variaveis_Static.Status_tarefa_static;
        }

        private void btnCriarTarefa_Click(object sender, EventArgs e)
        {
            if (btnCriarTarefa.Text == "Criar tarefa")
            {
                if (txtTituloTarefa.Text == string.Empty || string.IsNullOrWhiteSpace(txtHoraInicioTarefa.Text) || txtHoraInicioTarefa.Text == "00:00" || dtTarefa.Text == null)
                {
                    MessageBox.Show("Existe campos importantes vazios, verifique os campos e tente novamente", "Registro de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                RegistrarTarefa();
                DadosExcluidos?.Invoke();
                DadosAtualizados?.Invoke();
                Close();
            }
            else if (btnCriarTarefa.Text == "Editar tarefa")
            {
                if (txtTituloTarefa.Text == string.Empty || string.IsNullOrWhiteSpace(txtHoraInicioTarefa.Text) || txtHoraInicioTarefa.Text == "00:00" || dtTarefa.Text == null)
                {
                    MessageBox.Show("Existe campos importantes vazios, verifique os campos e tente novamente", "Registro de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                AtualizarTarefa();
                DadosExcluidos?.Invoke(); 
                DadosAtualizados?.Invoke(); 
                Close();
            }

        }

        void FormAtualizarExcluirInformacao()
        {
            if (Variaveis_Static.Decisao_Form == 1)
            {
                //Botões visiveis
                chkHabilitarEdicao.Visible = true;
                btnExcluirTarefa.Visible = true;
                cbStatus.Visible = true;
                lblStatus.Visible = true;

                CarregarInformacoesTarefa();

                //Botões habilitados
                txtTituloTarefa.ReadOnly = true;
                txtDescricaoTarefa.ReadOnly = true;
                txtHoraInicioTarefa.ReadOnly = true;
                dtTarefa.Enabled = false;

                //Renomeações
                btnCriarTarefa.Text = "Editar tarefa";
                this.Text = "TaskMaster - Editar tarefa";
            }
        }

        void RegistrarTarefa()
        {
            Variaveis v = new Variaveis();
            Funcoes f = new Funcoes();

            v.Titulo_tarefa = txtTituloTarefa.Text;
            v.Descricao_tarefa = txtDescricaoTarefa.Text;
            v.Data_tarefa = dtTarefa.Text;
            v.Hora_tarefa = txtHoraInicioTarefa.Text;
            v.Status_tarefa = "Pendente";
            v.Categoria_tarefa = cbCategoria.Text;
            string msg = f.RegistrarNovaTarefa(v);

            MessageBox.Show(msg, "Registro de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        void AtualizarTarefa()
        {
            Variaveis v = new Variaveis();
            Funcoes f = new Funcoes();

            v.Id_tarefa = Variaveis_Static.Id_tarefa_static;
            v.Titulo_tarefa = txtTituloTarefa.Text;
            v.Descricao_tarefa = txtDescricaoTarefa.Text;
            v.Data_tarefa = dtTarefa.Text;
            v.Hora_tarefa = txtHoraInicioTarefa.Text;
            v.Categoria_tarefa = cbCategoria.Text;
            if (cbStatus.Text == string.Empty)
            {
                MessageBox.Show("Campo de status está vazio", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                v.Status_tarefa = cbStatus.Text;
            }
            string msg = f.AtualizarTarefa(v);
            MessageBox.Show(msg, "Atualização da tarefas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        void ExcluirAtividade()
        {
            Variaveis v = new Variaveis(); Funcoes f = new Funcoes();

            v.Id_tarefa = Variaveis_Static.Id_tarefa_static;

            string mensagem = f.DeletarTarefa(v.Id_tarefa);
            MessageBox.Show(mensagem, "Atualização da tarefas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormAddTarefa_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Botões visiveis
            chkHabilitarEdicao.Visible = false;
            btnExcluirTarefa.Visible = false;
            cbStatus.Visible = false;
            lblStatus.Visible = false;
            Variaveis_Static.Decisao_Form = 0;
            this.Text = "TaskMaster - Adicionar nova tarefa";
            btnCriarTarefa.Text = "Criar tarefa";
        }

        private void chkHabilitarEdicao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitarEdicao.Checked == true)
            {
                txtTituloTarefa.ReadOnly = false;
                txtDescricaoTarefa.ReadOnly = false;
                txtHoraInicioTarefa.ReadOnly = false;
                cbStatus.Enabled = true;
                dtTarefa.Enabled = true;
            }
            else if (chkHabilitarEdicao.Checked == false)
            {
                txtTituloTarefa.ReadOnly = true;
                txtDescricaoTarefa.ReadOnly = true;
                txtHoraInicioTarefa.ReadOnly = true;
                dtTarefa.Enabled = false;
                cbStatus.Enabled = false;
                CarregarInformacoesTarefa();
            }
        }

        private void btnExcluirTarefa_Click(object sender, EventArgs e)
        {
            ExcluirAtividade(); DadosExcluidos?.Invoke(); DadosAtualizados?.Invoke(); Close();
        }

        private void FormAddTarefa_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Add("Pendente");
            cbStatus.Items.Add("Concluida");


            CarregarComboBox();
        }

        public void CarregarComboBox()
        {
            var f = new Funcoes();
            cbCategoria.DataSource = f.ObterCategoriaNaComboBox();
            cbCategoria.DisplayMember = "Categoria_tarefa"; // O que será exibido na combobox
            cbCategoria.ValueMember = "Categoria_tarefa"; // Valor que será utilizado internamente
        }
    }
}
