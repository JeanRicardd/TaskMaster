using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster_Dev.Classes
{ 
    internal class TaskRepository
    {

        /// <summary>
        /// Obtém as tarefas do dia atual cuja hora está próxima do horário atual.
        /// </summary>
        /// <param name="agora">O horário atual da máquina.</param>
        /// <param name="intervalo">Intervalo de proximidade em minutos.</param>
        /// <returns>Uma tabela contendo as tarefas próximas.</returns>
        public DataTable ObterTarefasProximas(DateTime agora, TimeSpan intervalo)
        {
            using (var connection = Conexao.DbConnection())
            {
                //connection.Open(); // Certifique-se de que a conexão está aberta

                using (var cmd = connection.CreateCommand())
                {
                    // Consulta com conversão de formato de data
                    string query = @"
            SELECT Id_tarefa, Titulo_tarefa, Data_tarefa, Hora_tarefa
            FROM Tarefas
            WHERE strftime('%Y-%m-%d', 
                           substr(Data_tarefa, 7, 4) || '-' || substr(Data_tarefa, 4, 2) || '-' || substr(Data_tarefa, 1, 2)) 
                  = @DataHoje
            AND (strftime('%s', Hora_tarefa) - strftime('%s', @HoraAgora)) BETWEEN 0 AND @IntervaloEmSegundos";

                    // Configurando a consulta
                    cmd.CommandText = query;

                    // Adicionando parâmetros
                    cmd.Parameters.AddWithValue("@DataHoje", agora.ToString("yyyy-MM-dd")); // Formato ISO para SQLite
                    cmd.Parameters.AddWithValue("@HoraAgora", agora.ToString("HH:mm:ss")); // Horário atual em formato ISO
                    cmd.Parameters.AddWithValue("@IntervaloEmSegundos", intervalo.TotalSeconds); // Intervalo em segundos

                    var dataTable = new DataTable();

                    // Executando a consulta e carregando os dados
                    using (var reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }

                    return dataTable;
                }
            }
        }

        public DataTable ObterTarefasExatas(DateTime agora)
        {
            using (var connection = Conexao.DbConnection())
            {
                //connection.Open();

                using (var cmd = connection.CreateCommand())
                {
                    // Consulta considerando uma margem de 5 segundos
                    string query = @"
            SELECT Id_tarefa, Titulo_tarefa, Data_tarefa, Hora_tarefa, Descricao_tarefa, Status_tarefa, Categoria_tarefa
            FROM Tarefas
            WHERE strftime('%Y-%m-%d', 
                           substr(Data_tarefa, 7, 4) || '-' || substr(Data_tarefa, 4, 2) || '-' || substr(Data_tarefa, 1, 2)) 
                  = @DataHoje
            AND ABS(strftime('%s', Hora_tarefa) - strftime('%s', @HoraAgora)) <= 5";

                    // Configurando a consulta
                    cmd.CommandText = query;

                    // Adicionando parâmetros
                    cmd.Parameters.AddWithValue("@DataHoje", agora.ToString("yyyy-MM-dd")); // Formato ISO para SQLite
                    cmd.Parameters.AddWithValue("@HoraAgora", agora.ToString("HH:mm:ss")); // Horário exato no formato ISO

                    var dataTable = new DataTable();

                    // Executando a consulta e carregando os dados
                    using (var reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }

                    return dataTable;
                }
            }
        }

    }
}
