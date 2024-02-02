# Documentação da API BackEndAeroQA

## Visão Geral
Desafio HORIZON. Bem-vindo à documentação da API BackEndAeroQA, uma solução abrangente para o gerenciamento de operações aéreas. Esta API oferece uma variedade de funcionalidades para administradores, passageiros e muito mais. Abaixo está uma visão geral dos principais recursos e componentes.

### Funcionalidades
- **Autenticação:**
  - Mecanismo de autenticação seguro para administradores.

- **Operações em Aeroportos:**
  - Listar aeroportos disponíveis.

- **Gestão de Voos:**
  - Criar, listar, atualizar e cancelar voos.
  - Obter detalhes dos passageiros em um voo específico.

- **Emissão de Bilhetes:**
  - Comprar passagens.
  - Recuperar passagens compradas com base no CPF do comprador.
  - Cancelar a compra de passagens.
  - Gerar um voucher para a passagem comprada.

- **Manuseio de Bagagem:**
  - Emitir etiquetas de bagagem, incluindo autenticação JWT.
  
- **Docker:**
  - O projeto inclui um Dockerfile para facilitar a execução da aplicação via Docker.

## Estrutura da Aplicação
A aplicação é estruturada em torno de controladores, cada um responsável por funcionalidades específicas.

A URL base da API é: `https://backendaeroqawebapiapi.azure-api.net`

## Tecnologias Utilizadas
- **Autenticação:** JWT
- **Validação de Dados:** FluentValidation
- **Mapeamento de Dados:** AutoMapper
- **Hospedagem na Nuvem:** Azure
- **Docker:** Inclui suporte para execução via Docker.
- **Melhorias Planejadas:**
  - Avaliação e ajuste dos nomes das rotas para maior clareza e consistência.
  - Revisão e possível otimização de algumas lógicas de código.
  - Pretendo ainda implementar testes unitários com xUnit.

## Deploy
Fiquei em dúvida entre fazer o deploy no Heroku e no Azure. No Heroku, consideraria o deploy via Docker, já que eu adicionei um Dockerfile. No entanto, optei pela praticidade do Azure diretamente do Visual Studio para a publicação da API.

## Notas Importantes
- O banco de dados e a API estão hospedados na nuvem com acesso público.
- Certifique-se de lidar com a autenticação com JWT para operações seguras.

Sinta-se à vontade para explorar e integrar a API BackEndAeroQA em suas aplicações!
