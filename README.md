# Projeto Banco de Dados

![image](https://github.com/user-attachments/assets/71fb98ad-e892-4f57-8f4b-3b947df29f84)

## Descrição 

Este repositório contém o **Projeto Banco de Dados**, desenvolvido como parte de um trabalho acadêmico da disciplina de Banco de Dados da UNICAP que aborda a criação e manipulação de um banco de dados relacional. O objetivo principal do projeto foi a aplicação prática de conceitos de modelagem de dados, normalização e a execução de operações em SQL, com o propósito de demonstrar a construção de um sistema de banco de dados eficiente e funcional. Para complementar o banco de dados, foi desenvolvida uma aplicação desktop utilizando WindowsForms em C#, garantindo uma interface amigável e de fácil interação. Essa aplicação permite realizar operações como cadastro de usuários, consulta e manipulação de arquivos, atribuição de permissões e registro de atividades no banco de dados, tudo de forma integrada e segura

## Grupo
- Maria Clara Soares
- Pedro Filipe Macedo
- Marco Antônio Arcoverde
- Lucas Eduardo Gurgel
- Thiago Carvalho Araujo

# Projeto de Banco de Dados

Este projeto de Banco de Dados foi desenvolvido para gerenciar arquivos e compartilhamentos de usuários em um sistema seguro. Abaixo, detalhamos a estrutura do banco de dados, as tabelas criadas, scripts SQL utilizados e consultas implementadas para realizar operações de inserção, seleção, atribuição de permissões, entre outras funcionalidades.

## Desenvolvimento com Windows Forms e C#

Para a interface gráfica do sistema, usamos WindowsForms, juntamente com a linguagem C#, para criar uma aplicação desktop que interage diretamente com o banco de dados MySQL.

### Por que escolher C#?

1. **SQL NATIVO** - O C# nos permite usar SQL nativo e fazer consultas diretamente no banco de dados, tornando-se uma escolha ideal para projetos que demandam manipulação e gerenciamento eficiente de dados.
2. **INTEGRAÇÂO COM O .NET FRAMEWORK** - O suporte ao Windows Forms no .NET Framework proporciona ferramentas robustas e simplificadas para a criação de interfaces gráficas, permitindo o desenvolvimento rápido de aplicativos desktop amigáveis ao usuário.
3. **ESCALABILIDADE** - C# é uma linguagem versátil, permitindo que o sistema possa ser expandido para incluir funcionalidades mais complexas no futuro, como a implementação do Entity Framework.

## Estrutura do Banco de Dados

O banco de dados contém as seguintes tabelas principais:

1. **ARQUIVO** - Armazena informações dos arquivos no sistema.
2. **COMPARTILHAR** - Gerencia o compartilhamento de arquivos entre usuários.
3. **USUARIO** - Registra os usuários do sistema, com detalhes de suas permissões.
4. **INSTITUICAO** - Armazena dados da instituição, incluindo o plano e espaço disponível.
5. **OPERAR** - Registra as operações realizadas pelos usuários nos arquivos.
6. **COMENTAR** - Registra comentários feitos pelos usuários nos arquivos.
7. **ADMINISTRADOR** - Tabela que diferencia os administradores entre os usuários.
8. **SUPORTE** - Registra o suporte dado aos usuários, com detalhes de data, hora e descrição do suporte.
9. **HISTORICO DE VERSIONAMENTO** - Controla o versionamento dos arquivos com dados de operação e usuário responsável.

## Scripts de Criação e Inserção de Dados

### 1. Criação das Tabelas

Os scripts SQL responsáveis pela criação das tabelas definem os atributos principais, suas restrições e relacionamentos:

- **ARQUIVO**: Contém ID, nome, tipo, data de criação, entre outros atributos que caracterizam um arquivo.
- **COMPARTILHAR**: Define a relação entre arquivos e usuários para controle de compartilhamento.
- **USUARIO**: Registra informações como ID, nome, e-mail e permissões dos usuários.
- **INSTITUICAO**: Armazena informações como nome, causa social, endereço, plano e espaço do usuário.
- **OPERAR**: Tabela para rastrear o tipo de operação realizada e a data da operação nos arquivos.
- **COMENTAR**: Registra o conteúdo dos comentários feitos pelos usuários, junto com a data e hora do comentário.
- **ADMINISTRADOR**: Identifica os administradores entre os usuários com um ID específico.
- **SUPORTE**: Armazena dados de suporte, incluindo o ID do usuário, ID do administrador, data e hora do suporte e descrição.
- **HISTORICO DE VERSIONAMENTO**: Mantém um histórico das alterações realizadas nos arquivos, incluindo data e tipo de operação.

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
- **Roles e Permissões** permitem uma gestão segura e flexível do acesso a dados

## Procedures

### 1. Verificar atividades:
- Procedimento armazenado para atualizar a data da última versão na tabela 'ATIVIDADE_RECENTES'.


### 2. Conta Usuario:
- Verifica quantos usuários únicos receberam acesso a um arquivo 
específico através da tabela COMPARTILHAR.

### 3. Chavear:
- A procedure CHAVEAR alterna o status do campo ACESSO_PRIORITARIO para um arquivo específico na tabela ATIVIDADES_RECENTES, identificando-o pelo ID fornecido como parâmetro de entrada.

### 4. Remover Acessos:
- Essa procedure buscará todos os compartilhamentos do arquivo especificado e os excluirá, exceto o compartilhamento do proprietário

## Função

### Verificar Tempo de Alteração:
- Essa função foi criada para verificar se um arquivo foi modificado há mais de 100 dias, 
retornando um valor booleano (TRUE ou FALSE)


## Triggers

### 1. Safe Security:
-  Impede que arquivos executaveis sejam inseridos no drive

### 2. Registrar Operação:
- Essa trigger foi criada para ser executada automaticamente após a inserção de um
registro na tabela OPERAR. O objetivo principal é garantir que a tabela ATIVIDADES_RECENTES
seja atualizada ou populada com informações referentes à última operação realizada em um arquivo.

### 3. Atualizar Acesso:
- Essa trigger foi criada para toda vez que o usuario compartilhar algo ele vai
mudar a data de modificação na area do arquivo.
