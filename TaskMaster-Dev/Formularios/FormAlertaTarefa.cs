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

namespace TaskMaster_Dev.Formularios
{
    public partial class FormAlertaTarefa : Form
    {
        public event Action DadosAtualizados;

        public FormAlertaTarefa()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Variaveis v = new Variaveis();
            Funcoes f = new Funcoes();

            v.Id_tarefa = Variaveis_Static.Id_tarefa_static;
            v.Status_tarefa = "Concluida";

            string msg = f.AtualizarStatusTarefa(v);

            DadosAtualizados?.Invoke();
            Close();
        }

        private void FormAlertaTarefa_Load(object sender, EventArgs e)
        {
            lblTituloTarefa.Text = Variaveis_Static.Titulo_tarefa_static;
            if (Variaveis_Static.Descricao_tarefa_static != string.Empty)
            {
                lblDescricaoTarefa.Text = Variaveis_Static.Descricao_tarefa_static;
            }
            lblCategoriaTarefa.Text = Variaveis_Static.Categoria_tarefa_static;
            lblDataInicio.Text = Variaveis_Static.Data_tarefa_static;
            lblHoraInicio.Text = Variaveis_Static.Hora_tarefa_static;

        }
    }
}
