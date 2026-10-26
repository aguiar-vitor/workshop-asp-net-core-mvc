# 🛒 Sales Web MVC - Sistema de Gestão de Vendas

Projeto desenvolvido com base no curso **"[C# COMPLETO Programação Orientada a Objetos + Projetos](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/)"** do Prof. Nelio Alves (Udemy).

⚠️ **O Diferencial deste Repositório:** O projeto original do curso foi projetado para `.NET Core 2.1` com `Bootstrap 3`. Este repositório é fruto do meu trabalho de **refatoração e modernização arquitetural**, elevando a aplicação para o **.NET 10**, adotando C# moderno (Top-level statements) e redesenhando toda a interface gráfica para o **Bootstrap 5 (Tema Flatly)**.

## 🚀 Sobre o Projeto

O Sales Web MVC é um sistema web responsivo para o gerenciamento de vendas. Ele permite gerenciar departamentos, vendedores e registrar vendas, oferecendo um sistema robusto de buscas financeiras. O sistema foi construído respeitando rigorosamente o padrão arquitetural **MVC (Model-View-Controller)**.

## 🛠️ Evolução Tecnológica

- **Migração de Framework:** Atualizado de .NET Core 2.1 para o **.NET 10**.
- **Design de Código:** Implementação de Top-level statements no `Program.cs`, unificando configurações e eliminando o obsoleto `Startup.cs`.
- **Refatoração de UI/UX:** Substituição completa do Bootstrap 3/4 pelo **Bootstrap 5**, removendo dependências antigas (Glyphicons, classes depreciadas) e utilizando a estrutura moderna de grid e utilitários.
- **Banco de Dados:** Atualização do *Pomelo Entity Framework Core* para a versão 9.0, garantindo compatibilidade total com versões recentes do MySQL.
- **Segurança de Código:** Configuração de arquivos ignorados (`.gitignore`) atualizada para o padrão e padronização de commits via `.gitattributes`.

## ⚙️ Arquitetura e Funcionalidades Implementadas

O sistema aplica os conceitos de injeção de dependência e responsabilidade única através de camadas de serviços:

- **Gestão de Departamentos e Vendedores:** Operações de CRUD completas com relacionamento (1:N).
- **Tratamento de Exceções em Nível de Serviço:** Criação de classes especializadas como `NotFoundException` e `DbConcurrencyException` para tratar erros sem comprometer a interface.
- **Integridade Referencial:** Tratamento customizado (`IntegrityException`) para impedir a exclusão de vendedores que já possuem vendas atreladas.
- **Buscas e Relatórios de Vendas:**
  - *Busca Simples:* Filtro de registros de vendas por intervalo de datas.
  - *Busca Agrupada:* Filtro por datas com os resultados agrupados dinamicamente por Departamento utilizando `LINQ`.
- **Operações Assíncronas:** Todo o acesso a dados foi convertido para chamadas não-bloqueantes utilizando o padrão `Task`, `async` e `await`.

## 🧠 Tecnologias Utilizadas (Backend e Frontend)

- **C# e .NET 10**
- **ASP.NET Core MVC**
- **Entity Framework Core (ORM):** Abordagem Code-First com Migrations (`DbSet`, `DbContext`)
- **MySQL / Pomelo Provider**
- **LINQ e Expressões Lambda**
- **Razor Pages (CSHTML)**
- **Bootstrap 5 e HTML5/CSS3**

## 💻 Como executar o projeto localmente

1. Instale o [.NET SDK (versão 10 ou superior)](https://dotnet.microsoft.com/download) no seu sistema.
2. Certifique-se de ter o **MySQL Server** rodando na sua máquina.
3. Clone este repositório:

       git clone https://github.com/SEU-USUARIO/SEU-REPOSITORIO.git

4. Configure a Connection String no `appsettings.json`, substituindo `SUA_SENHA_AQUI` pela senha do seu banco de dados local:

       "ConnectionStrings": {
         "SalesWebMVCContext": "server=localhost;userid=root;password=SUA_SENHA_AQUI;database=saleswebmvcappdb"
       }

5. No terminal, aplique as migrações para gerar o banco:

       dotnet ef database update

6. Inicie o sistema. A classe `SeedingService` populará o banco com dados de teste automaticamente na primeira execução:

       dotnet run

7. Acesse a aplicação pelas portas indicadas no terminal (ex: `http://localhost:5038`).