
TaskMaster é um protótipo de um aplicativo de gerenciamento de tarefas desenvolvido para uma apresentação de faculdade.  
O objetivo do projeto é demonstrar a criação de um sistema simples de gerenciamento de tarefas, onde os usuários podem adicionar, editar, excluir e categorizar tarefas.

## Funcionalidades
- Adicionar novas tarefas com título, data, hora, descrição, status e categoria.
- Editar tarefas existentes.
- Excluir tarefas.
- Listar tarefas pendentes e concluídas.
- Gerenciar categorias de tarefas.

## Tecnologias Utilizadas
- Linguagem: C#
- Framework: .NET Framework 4.8.1
- Banco de Dados: SQLite

## Uso

1. Execute o projeto no Visual Studio.

2. A interface principal permitirá que você adicione novas tarefas, edite ou exclua tarefas existentes e gerencie categorias de tarefas.


## Estrutura do Projeto

- **Program.cs**: Ponto de entrada principal do aplicativo.
- **FormAddTarefa.Designer.cs**: Interface para adicionar e gerenciar tarefas.
- **FormGerenciarCategorias.Designer.cs**: Interface para gerenciar categorias de tarefas.
- **Funcoes.cs**: Contém funções CRUD para tarefas e categorias.
- **Conexao.cs**: Gerencia a conexão com o banco de dados SQLite.
- **Variaveis.cs**: Contém as classes `Variaveis` e `Variaveis_Static` que armazenam as variáveis utilizadas no projeto.
- **FormAddTarefa.cs**: Implementação da lógica para adicionar e gerenciar tarefas.
- **FormGerenciarCategorias.cs**: Implementação da lógica para gerenciar categorias de tarefas.
- **Ideias.cs**: Contém ideias para melhorias futuras.
