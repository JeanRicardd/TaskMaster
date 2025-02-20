using System;

namespace TaskMaster_Dev.Classes
{
    public class Variaveis
    {
        public int Id_tarefa { get; set; }
        public string Titulo_tarefa { get; set; }
        public string Data_tarefa { get; set; }
        public string Hora_tarefa { get; set; }
        //Descrição está como opcional, visto que será gerado alertas de notificação para inicio da tarefa
        public string Descricao_tarefa { get; set; }
        public string Status_tarefa { get; set; }
        public string Categoria_tarefa { get; set; }

        //Referente ao formulario Categoria
        public int Id_Categoria { get; set; }
    }
     
    public static class Variaveis_Static
    {
        public static int Id_tarefa_static { get; set; }
        public static string Titulo_tarefa_static { get; set; }
        public static string Data_tarefa_static { get; set; }
        public static string Hora_tarefa_static { get; set; }
        //Descrição está como opcional, visto que será gerado alertas de notificação para inicio da tarefa
        public static string Descricao_tarefa_static { get; set; }
        public static string Status_tarefa_static { get; set; }
        public static string Categoria_tarefa_static { get; set; }
        public static int Decisao_Form { get; set; }
    }
}
