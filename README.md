# Projeto Banco de Dados

![image](https://github.com/user-attachments/assets/71fb98ad-e892-4f57-8f4b-3b947df29f84)

## Descrição 

Este repositório contém o **Projeto Banco de Dados**, desenvolvido como parte de um trabalho acadêmico da disciplina de Banco de Dados da UNICAP que aborda a criação e manipulação de um banco de dados relacional. O objetivo principal do projeto foi a aplicação prática de conceitos de modelagem de dados, normalização e a execução de operações em SQL, com o propósito de demonstrar a construção de um sistema de banco de dados eficiente e funcional.

## Grupo
- Maria Clara Soares
- Pedro Filipe Macedo
- Marco Antônio Arcoverde
- Lucas Eduardo Gurgel
- Thiago Carvalho Araujo

## Estrutura do Banco de Dados

O banco de dados contém as seguintes tabelas principais:

1. **ARQUIVO** - Armazena informações dos arquivos no sistema.
2. **COMPARTILHAR** - Gerencia o compartilhamento de arquivos entre usuários.
3. **USUARIO** - Registra os usuários do sistema, com detalhes de suas permissões.

### Diagrama de Relacionamento

## Scripts de Criação e Inserção de Dados

### 1. Criação das Tabelas

Os scripts SQL responsáveis pela criação das tabelas definem os atributos principais, suas restrições e relacionamentos:

- **ARQUIVO**: Contém ID, nome, tipo, data de criação, entre outros atributos que caracterizam um arquivo.
- **COMPARTILHAR**: Define a relação entre arquivos e usuários para controle de compartilhamento.
- **USUARIO**: Registra informações como ID, nome, e-mail e permissões dos usuários.

### 2. Inserção de Dados

Scripts de inserção foram criados para popular as tabelas com dados iniciais, permitindo que o sistema comece a operar com informações de usuários, arquivos e compartilhamentos. Isso inclui registros de usuários com diferentes roles e arquivos associados.

## Scripts de Consulta

### 1. Exibir Arquivos Compartilhados

Este script permite listar todos os arquivos que foram compartilhados com cada usuário, detalhando quem compartilhou o arquivo e o tipo de acesso permitido.

### 2. Exibir Arquivos Recebidos por Usuário

Consulta específica para verificar quais arquivos cada usuário recebeu, facilitando o gerenciamento e controle de acessos.

### 3. Seleção de Arquivos e Compartilhamentos

Scripts SQL que permitem ao administrador filtrar arquivos e compartilhamentos com base em critérios específicos, como data de criação, tipo de arquivo ou permissões.

## Controle de Permissões e Roles

### 1. Atribuição de Roles aos Usuários

O projeto inclui scripts para atribuir roles (perfis de acesso) aos usuários, como **administrador**, **editor** e **visualizador**, determinando os níveis de acesso e operação que cada usuário pode realizar.

### 2. Sessões de Administrador

Scripts específicos permitem que administradores consultem logs e registros de compartilhamento para garantir a segurança e monitoramento do sistema.

## Explicações e Justificativas

Cada script foi desenvolvido com o objetivo de otimizar a performance e garantir a segurança dos dados:

- **Índices** foram utilizados para otimizar consultas em tabelas grandes.
- **Foreign Keys** foram implementadas para assegurar a integridade referencial entre as tabelas.
- **Roles e Permissões** permitem uma gestão segura e flexível do acesso a dados sensíveis.
