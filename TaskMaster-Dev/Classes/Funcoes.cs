using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;

namespace TaskMaster_Dev.Classes
{ 
    public class Funcoes
    {
        //Criar a tabela em casos de não existir o banco de dados ou resetado
        public void CriarTabelaTarefas()
        {
            using (var connection = Conexao.DbConnection())
            {

                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE \"Tarefas\" (\r\n\t\"Id_tarefa\"\tINTEGER,\r\n\t\"Titulo_tarefa\"\tTEXT NOT NULL,\r\n\t\"Data_tarefa\"\tTEXT NOT NULL,\r\n\t\"Hora_tarefa\"\tTEXT NOT NULL,\r\n\t\"Descricao_tarefa\"\tTEXT,\r\n\t\"Status_tarefa\"\tTEXT,\r\n\t\"Categoria_tarefa\"\tTEXT,\r\n\tPRIMARY KEY(\"Id_tarefa\" AUTOINCREMENT)\r\n); CREATE TABLE \"Categoria_tarefas\" (\r\n\t\"Id_categoria\"\tINTEGER,\r\n\t\"Nome_categoria\"\tTEXT NOT NULL,\r\n\t\"Nivel_categoria\"\tTEXT,\r\n\tPRIMARY KEY(\"Id_categoria\")\r\n);";

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        //Abaixo estão as funções de CRUD das Tarefas
        public string RegistrarNovaTarefa(Variaveis v)
        {
            using (var cmd = Conexao.DbConnection().CreateCommand())
            {
                // Comando SQL para inserir uma nova tarefa
                cmd.CommandText = @"
            INSERT INTO Tarefas (Titulo_tarefa, Data_tarefa, Hora_tarefa, Descricao_tarefa, Status_tarefa, Categoria_tarefa) 
            VALUES (@titulo_tarefa, @data_tarefa, @hora_tarefa, @descricao_tarefa, @status_tarefa, @categoria_tarefa)";

                // Adicionando parâmetros
                cmd.Parameters.AddWithValue("@titulo_tarefa", v.Titulo_tarefa);
                cmd.Parameters.AddWithValue("@data_tarefa", v.Data_tarefa);
                cmd.Parameters.AddWithValue("@hora_tarefa", v.Hora_tarefa);
                cmd.Parameters.AddWithValue("@descricao_tarefa", v.Descricao_tarefa);
                cmd.Parameters.AddWithValue("@status_tarefa", v.Status_tarefa);
                cmd.Parameters.AddWithValue("@categoria_tarefa", v.Categoria_tarefa);

                // Executando o comando
                int result = cmd.ExecuteNonQuery();

                // Fechando a conexão
                Conexao.FecharConexao();

                string message = "";

                // Verificando o resultado da operação
                if (result == 1)
                {
                    message = "Tarefa registrada com sucesso!";
                }
                else
                {
                    message = "Falha ao registrar a tarefa!";
                }

                return message;
            }
        }

        public string AtualizarTarefa(Variaveis v)
        {
            using (var cmd = Conexao.DbConnection().CreateCommand())
            {
                // Comando SQL para atualizar o registro de tarefa
                cmd.CommandText = @"UPDATE Tarefas SET Titulo_tarefa = @titulo_tarefa, Data_tarefa = @data_tarefa, Hora_tarefa = @hora_tarefa, Descricao_tarefa = @descricao_tarefa, Status_tarefa = @status_tarefa, Categoria_tarefa = @categoria_tarefa WHERE Id_tarefa = @id_tarefa";

                // Adicionando parâmetros
                cmd.Parameters.AddWithValue("@id_tarefa", v.Id_tarefa);
                cmd.Parameters.AddWithValue("@titulo_tarefa", v.Titulo_tarefa);
                cmd.Parameters.AddWithValue("@data_tarefa", v.Data_tarefa);
                cmd.Parameters.AddWithValue("@hora_tarefa", v.Hora_tarefa);
                cmd.Parameters.AddWithValue("@descricao_tarefa", v.Descricao_tarefa);
                cmd.Parameters.AddWithValue("@status_tarefa", v.Status_tarefa);
                cmd.Parameters.AddWithValue("@categoria_tarefa", v.Categoria_tarefa);

                // Executando o comando
                int result = cmd.ExecuteNonQuery();

                // Fechando a conexão
                Conexao.FecharConexao();

                string message = "";

                // Verificando o resultado da operação
                if (result == 1)
                {
                    message = "Tarefa atualizada com sucesso!";
                }
                else
                {
                    message = "Falha ao atualizar a tarefa!";
                }

                return message;
            }
        }

        public string AtualizarStatusTarefa(Variaveis v)
        {
            using (var cmd = Conexao.DbConnection().CreateCommand())
            {
                // Comando SQL para atualizar o registro de tarefa
                cmd.CommandText = @"UPDATE Tarefas SET Status_tarefa = @status_tarefa WHERE Id_tarefa = @id_tarefa";

                // Adicionando parâmetros
                cmd.Parameters.AddWithValue("@id_tarefa", v.Id_tarefa);
                cmd.Parameters.AddWithValue("@status_tarefa", v.Status_tarefa);

                // Executando o comando
                int result = cmd.ExecuteNonQuery();

                // Fechando a conexão
                Conexao.FecharConexao();

                string message = "";

                // Verificando o resultado da operação
                if (result == 1)
                {
                    message = "Tarefa atualizada com sucesso!";
                }
                else
                {
                    message = "Falha ao atualizar a tarefa!";
                }

                return message;
            }
        }

        public string DeletarTarefa(int id)
        {
            using (var cmd = Conexao.DbConnection().CreateCommand())
            {
                // Comando SQL para excluir uma tarefa
                cmd.CommandText = @"DELETE FROM Tarefas WHERE Id_tarefa = @id_tarefa";

                // Adicionando parâmetro
                cmd.Parameters.AddWithValue("@id_tarefa", id);

                // Executando o comando
                int result = cmd.ExecuteNonQuery();

                // Fechando a conexão
                Conexao.FecharConexao();

                string message = "";

                // Verificando o resultado da operação
                if (result == 1)
                {
                    message = "Tarefa excluída com sucesso!";
                }
                else
                {
                    message = "Falha ao excluir a tarefa!";
                }

                return message;
            }
        }

        public DataTable ListarTodasTarefasPendentes()
        {
            DataTable dt = new DataTable();
            string query = "select * from Tarefas where Status_tarefa = 'Pendente'";
            //Conexao.DbConnection().Open();
            using (SQLiteCommand cmd = new SQLiteCommand(query, Conexao.DbConnection()))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    dt.Load(rdr);

                    return dt;
                }
            }
        }

        public DataTable ListarTodasTarefasRealizadas()
        {
            DataTable dt = new DataTable();
            string query = "select * from Tarefas where Status_tarefa = 'Concluida'";
            //Conexao.DbConnection().Open();
            using (SQLiteCommand cmd = new SQLiteCommand(query, Conexao.DbConnection()))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    dt.Load(rdr);

                    return dt;
                }
            }
        }

        //Abaixo estão as funções de CRUD das Categorias das tarefas
        public string RegistrarNovaCategoria(Variaveis v)
        {
            using (var cmd = Conexao.DbConnection().CreateCommand())
            {
                // Comando SQL para inserir uma nova tarefa
                cmd.CommandText = @"insert into Categoria_tarefas (nome_categoria) values (@nome_categoria)";

                // Adicionando parâmetros
                cmd.Parameters.AddWithValue("@nome_categoria", v.Categoria_tarefa);

                // Executando o comando
                int result = cmd.ExecuteNonQuery();

                // Fechando a conexão
                Conexao.FecharConexao();

                string message = "";

                // Verificando o resultado da operação
                if (result == 1)
                {
                    message = "Categoria registrada com sucesso!";
                }
                else
                {
                    message = "Falha ao registrar a categoria!";
                }

                return message;
            }
        }

        public string AtualizarCategoria(Variaveis v)
        {
            using (var cmd = Conexao.DbConnection().CreateCommand())
            {
                // Comando SQL para atualizar o registro de tarefa
                cmd.CommandText = @"UPDATE Categoria_tarefas SET Nome_categoria = @nome_categoria WHERE Id_categoria = @id_categoria;";

                // Adicionando parâmetros
                cmd.Parameters.AddWithValue("@id_categoria", v.Id_Categoria);
                cmd.Parameters.AddWithValue("@nome_categoria", v.Categoria_tarefa);

                // Executando o comando
                int result = cmd.ExecuteNonQuery();

                // Fechando a conexão
                Conexao.FecharConexao();

                string message = "";

                // Verificando o resultado da operação
                if (result == 1)
                {
                    message = "Categoria atualizada com sucesso!";
                }
                else
                {
                    message = "Falha ao atualizar a categoria!";
                }

                return message;
            }
        }

        public string DeletarCategoria(int id)
        {
            using (var cmd = Conexao.DbConnection().CreateCommand())
            {
                // Comando SQL para excluir uma tarefa
                cmd.CommandText = @"Delete from Categoria_tarefas where Id_categoria = @id_categoria";

                // Adicionando parâmetro
                cmd.Parameters.AddWithValue("@id_categoria", id);

                // Executando o comando
                int result = cmd.ExecuteNonQuery();

                // Fechando a conexão
                Conexao.FecharConexao();

                string message = "";

                // Verificando o resultado da operação
                if (result == 1)
                {
                    message = "Categoria excluída com sucesso!";
                }
                else
                {
                    message = "Falha ao excluir a categoria!";
                }

                return message;
            }
        }

        public DataTable ListarCategorias()
        {
            DataTable dt = new DataTable();
            string query = "select * from Categoria_tarefas";
            //Conexao.DbConnection().Open();
            using (SQLiteCommand cmd = new SQLiteCommand(query, Conexao.DbConnection()))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    dt.Load(rdr);

                    return dt;
                }
            }
        }

        public List<Variaveis> ObterCategoriaNaComboBox()
        {
            List<Variaveis> ListaAtividades = new List<Variaveis>();

            using (var cmd = Conexao.DbConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT DISTINCT Nome_categoria FROM Categoria_tarefas";
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Variaveis variaveis = new Variaveis();
                        ListaAtividades.Add(new Variaveis
                        {
                            Categoria_tarefa = reader.GetString(reader.GetOrdinal("Nome_categoria"))
                        });

                    }
                }
                return ListaAtividades;
            }
        }

    }
}
