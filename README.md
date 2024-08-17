API de Catálogo de Produtos

A API de Catálogo de Produtos é uma aplicação construída em .NET Core que gerencia informações de produtos e categorias. Ela oferece um conjunto de endpoints RESTful que permitem a criação, leitura, atualização e exclusão (CRUD) de produtos e categorias em um banco de dados.

Funcionalidades
CRUD de Produtos: Endpoints para criação, leitura, atualização e exclusão de produtos no catálogo.
CRUD de Categorias: Endpoints para gerenciar categorias de produtos, permitindo que produtos sejam organizados em diferentes grupos.
Integração com Banco de Dados: Usa o Entity Framework Core para mapeamento, permitindo interações robustas e seguras com o banco de dados.
Validação de Dados: Implementa validações básicas para garantir a integridade dos dados antes de serem persistidos no banco.
Tratamento de Exceções: Manipulação de erros comuns para garantir respostas HTTP adequadas e informativas em caso de falhas.

Endpoints Principais:

Produtos
GET /produtos - Retorna a lista de todos os produtos.
GET /produtos/{id} - Retorna os detalhes de um produto específico.
POST /produtos - Adiciona um novo produto ao catálogo.
PUT /produtos/{id} - Atualiza as informações de um produto existente.
DELETE /produtos/{id} - Remove um produto do catálogo.

Categorias
GET /categorias - Retorna a lista de todas as categorias.
GET /categorias/{id} - Retorna os detalhes de uma categoria específica.
POST /categorias - Adiciona uma nova categoria ao catálogo.
PUT /categorias/{id} - Atualiza as informações de uma categoria existente.
DELETE /categorias/{id} - Remove uma categoria do catálogo.

Tecnologias Utilizadas

.NET Core: Framework principal para construção da API.
Entity Framework Core: Para manipulação do banco de dados.
MySql: Banco de dados utilizado para persistência dos dados (pode ser facilmente substituído por outros SGBDs).
Swagger: Documentação interativa da API para facilitar testes e integração.
Como Executar o Projeto
