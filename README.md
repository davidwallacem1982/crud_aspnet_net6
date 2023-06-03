## ASP.Net Web API, .NET 6 e EF Core

#### ASP.Net Net6 Web API em C# é um framework poderoso e altamente produtivo para a criação de APIs da web. Com ele, você pode desenvolver uma API completa do zero, com todas as operações básicas de CRUD (Create, Read, Update e Delete).

Ao utilizar o ASP.Net Net6 Web API, você aproveitará os recursos avançados do C#, como tipagem estática e orientação a objetos, para criar uma API robusta e escalável. O ASP.Net Net6 é a versão mais recente do framework, trazendo melhorias significativas em desempenho, segurança e facilidade de uso.

Com o CRUD, você poderá criar novos recursos (Create), recuperar informações existentes (Read), atualizar registros (Update) e remover dados (Delete) na sua API. Essas operações são fundamentais para a maioria das aplicações, permitindo que você manipule e gerencie dados de forma eficiente.

Ao criar sua API do zero, você terá total controle sobre a estrutura e o funcionamento da mesma. Você poderá definir os modelos de dados, os endpoints, as rotas e as políticas de segurança. Além disso, o ASP.Net Net6 Web API possui suporte nativo para serialização e desserialização de dados em formatos como JSON e XML.

Com a combinação do ASP.Net Net6, C# e CRUD, você estará preparado para criar uma API robusta e flexível, capaz de atender às necessidades do seu projeto. Seja para desenvolver um aplicativo móvel, um sistema web ou uma integração com outros serviços, o ASP.Net Net6 Web API é uma escolha confiável e poderosa.

## Gerando o Banco

1. [SqlServer] Com o SqlServer instalado na sua estação no projeto entro no arquivo #appsettings.json, insira a sua ConnectionStrings para criar o banco na sua estação.
1. [Add-Migration] Em Package Manager Console insira o comando #Add-Migration NomedaMigacao -Context SistemaDBContext para criar a migration.
2. [Add-Migration] Depois de gerar a nova migração agora você vai inserir o comando Update-Database -Context SistemaDBContext para fazer o Update no SGBD da sua estação.
3. [Testando o sistema] Agora rode o programa e teste o sistema, ele dever abrir o swagger normalmente.
