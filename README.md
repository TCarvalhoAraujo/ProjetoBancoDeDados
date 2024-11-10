# Projeto Banco de Dados

![image](https://github.com/user-attachments/assets/71fb98ad-e892-4f57-8f4b-3b947df29f84)

# Grupo
- Maria Clara Soares
- Pedro Filipe Macedo
- Marco Antônio Arcoverde
- Lucas Eduardo Gurgel
- Thiago Carvalho Araujo

Este repositório contém o **Projeto Banco de Dados**, desenvolvido como parte de um trabalho acadêmico da disciplina de Banco de Dados da UNICAP que aborda a criação e manipulação de um banco de dados relacional. O objetivo principal do projeto foi a aplicação prática de conceitos de modelagem de dados, normalização e a execução de operações em SQL, com o propósito de demonstrar a construção de um sistema de banco de dados eficiente e funcional.

## Objetivo do Trabalho

O trabalho consiste na criação de um banco de dados para um sistema fictício, com a implementação das seguintes etapas:

1. **Modelagem do Banco de Dados**: A modelagem foi realizada utilizando o Diagrama Entidade-Relacionamento (ER), que descreve as entidades, seus atributos e os relacionamentos entre elas. O foco foi garantir que o modelo fosse claro, lógico e eficiente para o armazenamento e manipulação de dados.

2. **Criação de Tabelas e Relacionamentos**: Utilizando o modelo ER, as tabelas foram criadas no banco de dados com a definição de chaves primárias e estrangeiras, garantindo a integridade referencial entre os dados. A escolha das chaves foi feita de forma a otimizar as consultas e a consistência dos dados.

3. **Normalização**: Durante a modelagem, seguimos as primeiras formas normais (1NF, 2NF, 3NF) para eliminar redundâncias e dependências, resultando em um banco de dados mais eficiente e livre de anomalias de atualização.

4. **Consultas SQL**: Foram desenvolvidas consultas SQL para manipulação de dados e geração de relatórios. As consultas incluem operações de **SELECT**, **INSERT**, **UPDATE** e **DELETE**, assim como consultas mais complexas, utilizando **JOINs**, **agregações** e **subconsultas**.

5. **Desempenho e Otimização**: A performance do banco foi um ponto de atenção, e buscamos otimizar as consultas mais comuns, criando índices onde necessário, para garantir que o sistema seja eficiente, mesmo com um grande volume de dados.

## Estrutura do Banco de Dados

O banco de dados foi projetado para simular um sistema típico de gestão de dados, com tabelas inter-relacionadas. As principais tabelas incluem:

- **Clientes**: Contém informações dos clientes, como nome, endereço, telefone, etc.
- **Produtos**: Armazena os dados dos produtos disponíveis para venda.
- **Pedidos**: Registra os pedidos feitos pelos clientes, incluindo a data do pedido e os detalhes do pagamento.
- **Itens de Pedido**: Detalha os itens específicos de cada pedido, relacionando os produtos e suas quantidades.
- **Funcionários**: Contém informações sobre os funcionários que processam os pedidos e interagem com o sistema.

Além disso, a implementação de **visões** e **procedimentos armazenados** foi realizada para facilitar a consulta de dados complexos e melhorar a modularidade do sistema.

## Principais Funcionalidades Implementadas

- **Modelagem do Banco de Dados**: A modelagem ER foi implementada considerando as necessidades do sistema, com especial atenção para a normalização e o relacionamento entre as tabelas.
  
- **Operações CRUD**: O sistema implementa operações completas de **Create**, **Read**, **Update** e **Delete** para gerenciamento de dados, tanto para inserção de novos registros quanto para a manutenção e atualização dos existentes.

- **Consultas Complexas**: Implementação de consultas SQL avançadas, como filtros de múltiplas condições, junções entre tabelas, e agregações (como contagens, somas e médias), além da criação de relatórios que exigem a junção de informações de diferentes entidades.

- **Procedimentos Armazenados e Triggers**: Para garantir a integridade e automação de algumas tarefas, foram utilizados procedimentos armazenados (stored procedures) e triggers para validações automáticas de dados e execução de operações adicionais após inserções ou atualizações.

## Tecnologias Utilizadas

- **SGBD**: MySQL ou PostgreSQL.
- **Linguagem SQL**: Para definição de estruturas de dados (DDL), manipulação de dados (DML) e criação de consultas (DQL).
- **Ferramentas de Modelagem**: draw.io para criar o Diagrama ER e estruturar o banco de dados visualmente.
- **C#**: Linguagem escolhida para se relacionar com o banco de dados em SQL.

## Conclusão

Este trabalho proporcionou uma visão prática do processo completo de criação de um banco de dados, desde a modelagem até a execução de operações em SQL. A experiência foi fundamental para entender os desafios reais envolvidos na construção de sistemas de banco de dados eficientes e funcionais. Além disso, o projeto serviu para consolidar o conhecimento em SQL e na aplicação de boas práticas de modelagem e normalização.
