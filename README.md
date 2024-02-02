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

## Estrutura da Aplicação
A aplicação é estruturada em torno de controladores, cada um responsável por funcionalidades específicas.

### AeroportoController
- **Endpoint:** `/api/v1/aeroporto/aeroportos`
  - **Método:** `GET`
  - **Descrição:** Listar aeroportos disponíveis.

### PassageiroController
- **Endpoints:**
  - `/api/v1/passageiro/comprarpassagem`
    - **Método:** `POST`
    - **Descrição:** Comprar uma passagem.
  - `/api/v1/passageiro/cadastrar`
    - **Método:** `POST`
    - **Descrição:** Cadastrar um passageiro.
  - `/api/v1/passageiro/passagem/{CPF}`
    - **Método:** `GET`
    - **Descrição:** Recuperar passagens compradas pelo CPF.
  - `/api/v1/passageiro/passagem/{Cpf}`
    - **Método:** `DELETE`
    - **Descrição:** Cancelar a compra de passagens.
  - `/api/v1/passageiro/bagagem`
    - **Método:** `POST`
    - **Descrição:** Emitir etiqueta de bagagem.

### UsuarioController
- **Endpoint:** `/api/usuario/login`
  - **Método:** `POST`
  - **Descrição:** Login do usuário.

### VooController
- **Endpoints:**
  - `/api/v1/voo/voos`
    - **Método:** `GET`
    - **Descrição:** Listar voos disponíveis.
  - `/api/v1/voo/voo/{DataPartidaa}/{DataChegada}`
    - **Método:** `GET`
    - **Descrição:** Listar voos dentro de um intervalo de datas específico.
  - `/api/v1/voo/cancelar`
    - **Método:** `DELETE`
    - **Descrição:** Cancelar um voo.
  - `/api/v1/voo/voo/{id}`
    - **Método:** `GET`
    - **Descrição:** Recuperar detalhes do voo por ID.
  - `/api/v1/voo/voo/{id}/passageiros`
    - **Método:** `GET`
    - **Descrição:** Listar passageiros em um voo específico.
  - `/api/v1/voo/cadastro`
    - **Método:** `POST`
    - **Descrição:** Cadastrar um novo voo.
  - `/api/v1/voo/edite`
    - **Método:** `PUT`
    - **Descrição:** Atualizar detalhes do voo.

## Tecnologias Utilizadas
- **Autenticação:** JWT
- **Validação de Dados:** FluentValidation
- **Mapeamento de Dados:** AutoMapper
- **Hospedagem na Nuvem:** Azure

## Como Começar
Para começar com a API BackEndAeroQA, siga as etapas delineadas no [Guia de Início Rápido](link-para-o-seu-guia).

## Notas Importantes
- O banco de dados e a API estão hospedados na nuvem com acesso público.
- Certifique-se de lidar com a autenticação com JWT para operações seguras.

Sinta-se à vontade para explorar e integrar a API BackEndAeroQA em suas aplicações!
