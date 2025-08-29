📝 TODO List API

API RESTful de gerenciamento de tarefas, desenvolvida em C# .NET, utilizando Entity Framework Core e PostgreSQL.

Este projeto foi criado como parte da Trilha .NET - API e Entity Framework da Digital Innovation One (DIO), com o objetivo de aplicar conceitos de desenvolvimento de APIs, persistência de dados e boas práticas de programação em .NET.

A API permite criar, listar, atualizar e excluir tarefas, com controle de status (Pendente ou Finalizado)



💻 Tecnologias

C# / .NET 

Entity Framework Core 

PostgreSQL

Swagger (documentação da API)

Git / GitHub

🚀 Funcionalidades

Criar uma nova tarefa

Listar todas as tarefas

Listar por titulo, id e data

Atualizar uma tarefa existente

Deletar uma tarefa

<img width="1490" height="645" alt="image" src="https://github.com/user-attachments/assets/fca3c445-3c74-4dea-bb02-fe73bac80293" />


⚙️ Como Executar
# Clone o repositório
git clone https://github.com/Glayber16/TodoDIO.git

# Acesse a pasta do projeto
cd TodoDIO

# Restaure as dependências
dotnet restore

# Configure a connection string no appsettings.json com seu PostgreSQL

# Execute as migrations
dotnet ef database update

# Inicie a API
dotnet run


📂 Estrutura do Projeto
TodoListDIO/
 ├── Context/      # Configuração do DbContext
 ├── Controllers/  # Endpoints da API
 ├── Migrations/   # Migrations do Entity Framework
 ├── Models/       # Classes de domínio (Tarefa)
 ├── TodoDIO.sln   # Solução do .NET
 └── Program.cs    # Configuração da API e serviços
 

 
🧑‍💻 Autor

Desenvolvido por Glayberson
 como parte da Trilha .NET - API e Entity Framework da DIO 🚀

