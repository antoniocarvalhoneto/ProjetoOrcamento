# Projeto Orçamento

## 📋 Sobre o Projeto

O Projeto Orçamento é uma aplicação desktop desenvolvida em C# utilizando Windows Forms com o objetivo de gerenciar clientes, serviços e orçamentos de forma simples e intuitiva.

O sistema permite cadastrar clientes e serviços, criar orçamentos personalizados e acompanhar seu status, facilitando a organização e o controle de propostas comerciais.

---

## 🎯 Objetivos

* Automatizar o processo de criação de orçamentos;
* Centralizar informações de clientes e serviços;
* Facilitar o cálculo de valores dos orçamentos;
* Aplicar conceitos de Programação Orientada a Objetos (POO).

---

## ⚙️ Tecnologias Utilizadas

* C#
* .NET
* Windows Forms
* Programação Orientada a Objetos (POO)

---

## 📁 Estrutura do Projeto

```text
ProjetoOrcamento
│
├── Models
│   ├── Cliente.cs
│   ├── Servico.cs
│   ├── ItemOrcamento.cs
│   ├── Orcamento.cs
│   └── StatusOrcamento.cs
│
├── Forms
│   ├── FrmClientes.cs
│   ├── FrmServicos.cs
│   ├── FrmOrcamento.cs
│   └── FrmListaOrcamentos.cs
│
├── Form1.cs
├── Program.cs
└── ProjetoOrcamento.csproj
```

---

## 🚀 Funcionalidades

### Cadastro de Clientes

* Adicionar clientes;
* Editar informações;
* Remover clientes;
* Consultar clientes cadastrados.

### Cadastro de Serviços

* Registrar serviços oferecidos;
* Definir valores dos serviços;
* Atualizar informações.

### Gerenciamento de Orçamentos

* Selecionar cliente;
* Adicionar serviços ao orçamento;
* Calcular valor total automaticamente;
* Definir status do orçamento.

### Consulta de Orçamentos

* Visualizar todos os orçamentos criados;
* Consultar informações detalhadas;
* Acompanhar o status de cada orçamento.

---

## 🏗️ Conceitos de POO Aplicados

### Encapsulamento

Os dados são organizados em classes com propriedades específicas.

### Abstração

Cada classe representa uma entidade real do sistema:

* Cliente
* Serviço
* Item de Orçamento
* Orçamento

### Associação

Um orçamento está associado a:

* Um cliente;
* Um ou mais serviços.

---

## ▶️ Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/antoniocarvalhoneto/ProjetoOrcamento.git
```

2. Abra a solução no Visual Studio.

3. Compile o projeto.

4. Execute a aplicação pressionando F5.

---

## 📚 Aprendizados

Este projeto foi desenvolvido com foco na prática dos conceitos de:

* Programação Orientada a Objetos;
* Manipulação de formulários Windows Forms;
* Organização em camadas (Models e Forms);
* Estruturação de aplicações desktop em C#.

---

## 👨‍💻 Autor

Antonio da Silva Freire de Carvalho Neto
