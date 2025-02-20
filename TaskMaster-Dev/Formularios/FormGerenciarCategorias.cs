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
    public partial class FormGerenciarCategorias : Form
    {
        int id_Categoria_temp;

        public FormGerenciarCategorias()
        {
            InitializeComponent(); 
            ListarCategoriasCadastradas();

        }

        void CadastrarNovaCategoria()
        {
            Variaveis v = new Variaveis();
            Funcoes f = new Funcoes();
            v.Categoria_tarefa = txtNomeCategoria.Text;
            string msg = f.RegistrarNovaCategoria(v);
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
            return;
        }

        void ExcluirCategoria()
        {
            Funcoes f = new Funcoes();
            Variaveis v = new Variaveis();
            string mensagem = f.DeletarCategoria(id_Categoria_temp);
            MessageBox.Show(mensagem, "Atualização da tarefas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void AtualizarCategoriaCadastrada()
        {
            Variaveis v = new Variaveis();
            Funcoes f = new Funcoes();
            v.Id_Categoria = id_Categoria_temp;
            v.Categoria_tarefa = txtNomeCategoria.Text;
            string msg = f.AtualizarCategoria(v);
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
            return;
        }

        void ListarCategoriasCadastradas()
        {
            // Vincule os dados ao DataGridView
            Funcoes f = new Funcoes();
            BindingSource bs = new BindingSource();
            DataTable dt = f.ListarCategorias();

            bs.DataSource = dt;
            dtListarCategorias.DataSource = bs;

            dtListarCategorias.Columns["Id_categoria"].Visible = false;
            dtListarCategorias.Columns["Nivel_categoria"].Visible = false;

            dtListarCategorias.Columns["Nome_categoria"].HeaderText = "Nome da categoria";

        }

        private void btnInserirCategoria_Click(object sender, EventArgs e)
        {
            if (txtNomeCategoria.Text == string.Empty)
            {
                MessageBox.Show("Campo de nome da categoria está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (btnInserirCategoria.Text == "Inserir")
                {
                    CadastrarNovaCategoria();
                    ListarCategoriasCadastradas();
                }
                else if (btnInserirCategoria.Text == "Atualizar")
                {
                    AtualizarCategoriaCadastrada();
                    ListarCategoriasCadastradas();
                }

            }
        }

        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            ExcluirCategoria();
            ListarCategoriasCadastradas();
        }

        private void dtListarCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis v = new Variaveis();
            if (dtListarCategorias.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dtListarCategorias.SelectedRows[0];
                id_Categoria_temp = Int32.Parse(row.Cells[0].Value.ToString());
                v.Categoria_tarefa = row.Cells[1].Value.ToString();

                txtNomeCategoria.Text = v.Categoria_tarefa;

                btnInserirCategoria.Text = "Atualizar";
                btnExcluirCategoria.Visible = true;
            }
        }

        private void FormGerenciarCategorias_Click(object sender, EventArgs e)
        {
            btnInserirCategoria.Text = "Inserir";
            btnExcluirCategoria.Visible = false;
        }

        private void dtListarCategorias_Click(object sender, EventArgs e)
        {
            btnInserirCategoria.Text = "Inserir";
            btnExcluirCategoria.Visible = false;
        }
    }
}
