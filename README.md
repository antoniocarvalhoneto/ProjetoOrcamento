# Projeto Orçamento

Aplicação desktop em C# e Windows Forms para cadastro de clientes, serviços e gerenciamento de orçamentos comerciais. O projeto foi modernizado para ter uma interface mais próxima de um ERP comercial, com organização em camadas, validações, pesquisa instantânea, autenticação obrigatória, RBAC e persistência local em SQLite.

## Visão Geral

O sistema permite controlar o fluxo básico de orçamentos:

- cadastrar e manter clientes;
- cadastrar e manter serviços com preço unitário;
- montar orçamentos por cliente, adicionando serviços e quantidades;
- calcular totais automaticamente;
- aprovar ou rejeitar orçamentos;
- gerar número de pedido ao aprovar;
- consultar orçamentos por texto e status.
- controlar acesso por usuário e papel.

## Tecnologias

- C#
- .NET 10 (`net10.0-windows`)
- Windows Forms
- Microsoft.Data.Sqlite
- SQLitePCLRaw
- SQLite

## Requisitos

- Windows
- Visual Studio 2022 atualizado, com workload de desenvolvimento desktop .NET
- .NET 10 SDK instalado

## Como Executar no Visual Studio

1. Clone o repositório:

```bash
git clone https://github.com/antoniocarvalhoneto/ProjetoOrcamento.git
```

2. Abra a pasta do projeto:

```bash
cd ProjetoOrcamento
```

3. Abra a solução `ProjetoOrcamento.sln` no Visual Studio.

4. Restaure os pacotes NuGet, se o Visual Studio não fizer automaticamente.

5. Compile e execute com `F5`.

Também existe o arquivo `ProjetoOrcamento.slnx`, mas o `ProjetoOrcamento.sln` foi mantido para facilitar a abertura em versões tradicionais do Visual Studio.

## Como Executar pelo Terminal

Na raiz do repositório:

```powershell
dotnet restore .\ProjetoOrcamento.sln
dotnet build .\ProjetoOrcamento.sln
dotnet run --project .\ProjetoOrcamento\ProjetoOrcamento.csproj
```

## Estrutura do Projeto

```text
ProjetoOrcamento
|-- README.md
|-- ProjetoOrcamento.sln
|-- ProjetoOrcamento.slnx
`-- ProjetoOrcamento
    |-- Program.cs
    |-- Form1.cs
    |-- Forms
    |   |-- FrmLogin.cs
    |   |-- FrmUsuarios.cs
    |   |-- FrmClientes.cs
    |   |-- FrmServicoss.cs
    |   |-- FrmOrcamento.cs
    |   |-- FrmListaOrcamentos.cs
    |   `-- ModernControls.cs
    |-- Models
    |   |-- Cliente.cs
    |   |-- Servico.cs
    |   |-- ItemOrcamento.cs
    |   |-- Orcamento.cs
    |   |-- StatusOrcamento.cs
    |   |-- Usuario.cs
    |   `-- Papel.cs
    |-- Services
    |   |-- ClienteService.cs
    |   |-- ServicoService.cs
    |   |-- OrcamentoService.cs
    |   |-- UsuarioService.cs
    |   |-- AutorizacaoService.cs
    |   `-- PasswordHasher.cs
    `-- Repositories
        |-- IClienteRepository.cs
        |-- IServicoRepository.cs
        |-- IOrcamentoRepository.cs
        |-- IUsuarioRepository.cs
        |-- SqliteDatabase.cs
        |-- SqliteClienteRepository.cs
        |-- SqliteServicoRepository.cs
        |-- SqliteOrcamentoRepository.cs
        `-- SqliteUsuarioRepository.cs
```

## Arquitetura

O projeto segue uma separação simples em camadas:

```text
Forms
  -> Services
      -> Repositories
          -> SQLite
```

- `Forms`: telas WinForms, eventos de interface, feedback visual e interação com o usuário.
- `Services`: regras de validação e coordenação das operações.
- `Repositories`: acesso aos dados e comandos SQLite.
- `Models`: entidades principais do domínio.

## Autenticação e RBAC

O sistema exige login antes de abrir as telas principais. No primeiro acesso, caso não exista nenhum usuário cadastrado, o sistema cria automaticamente um administrador padrão:

```text
Login: admin
Senha: 1234
```

Papéis disponíveis:

| Papel | Permissões |
| --- | --- |
| Admin | Acessa todos os módulos, altera dados e gerencia usuários. |
| Operador | Altera clientes, serviços e orçamentos, mas não gerencia usuários. |
| Visualizador | Consulta dados, mas não salva, edita, exclui, aprova ou rejeita. |

As permissões são aplicadas na interface e também na camada de `Services`, antes das operações de gravação no SQLite.

## Funcionalidades Implementadas

### Clientes

- Cadastro, edição, exclusão e consulta.
- Campos para nome, telefone, CPF, CEP, endereço e observações.
- Máscaras para telefone, CPF e CEP.
- Pesquisa instantânea.
- Validação com mensagens amigáveis.

### Serviços

- Cadastro, edição, exclusão e consulta.
- Controle de preço unitário.
- Pesquisa por nome ou valor.
- Validação de nome e preço maior que zero.

### Orçamentos

- Criação de orçamento por cliente.
- Inclusão e remoção de itens.
- Quantidade por item.
- Cálculo automático de subtotal e total.
- Persistência dos itens junto ao orçamento.

### Lista de Orçamentos

- Consulta geral dos orçamentos.
- Filtro por texto e por status.
- Aprovação de orçamentos pendentes.
- Rejeição com motivo.
- Geração automática do número de pedido na aprovação.

### Usuários

- Login obrigatório antes do painel principal.
- Cadastro e edição de usuários por administradores.
- Definição de papel por usuário.
- Bloqueio de exclusão do próprio usuário logado.
- Proteção para manter pelo menos um administrador ativo.
- Senhas armazenadas com hash PBKDF2.

## Interface

A interface foi reformulada com:

- cabeçalho superior moderno;
- fonte Segoe UI;
- paleta com azul principal, verde de sucesso, vermelho de exclusão e laranja de aviso;
- botões com hover e cores por ação;
- painéis arredondados;
- DataGridView com cabeçalho destacado, linhas alternadas e seleção em linha inteira;
- colunas de ação para editar, excluir ou remover;
- tooltips nos controles principais;
- labels de status e resumo;
- atalhos de teclado.

## Atalhos

Atalhos disponíveis nas telas principais:

- `Ctrl + S`: salvar ou criar registro.
- `Ctrl + N`: limpar ou iniciar novo registro.
- `Del`: excluir/remover item quando o grid está em foco.
- `Esc`: cancelar edição ou fechar/cancelar operação.
- `Ctrl + R` ou `F5`: atualizar a lista de orçamentos.

## Persistência de Dados

Os dados são armazenados em SQLite no perfil do usuário:

```text
%AppData%\ProjetoOrcamento\orcamentos.db
```

Na primeira execução, o banco é criado automaticamente. Caso existam dados legados carregados pela classe `Dados`, eles são migrados para o SQLite quando o banco ainda está vazio.

Além das tabelas de clientes, serviços e orçamentos, o banco também cria as tabelas `Papeis` e `Usuarios` para autenticação e autorização.

## Solução de Problemas

### O build falha dizendo que o `.exe` está sendo usado

Esse erro acontece quando a aplicação ainda está aberta. Feche a janela do programa e compile novamente.

Se precisar encerrar pelo terminal:

```powershell
Get-Process -Name ProjetoOrcamento -ErrorAction SilentlyContinue | Stop-Process -Force
dotnet build .\ProjetoOrcamento.sln
```

### O Visual Studio não abre o projeto corretamente

Abra o arquivo `ProjetoOrcamento.sln`, não apenas a pasta. Depois execute restore/build pelo próprio Visual Studio.

### Pacotes NuGet não restauram

Execute:

```powershell
dotnet restore .\ProjetoOrcamento.sln
```

## Validação

Comandos usados para validar o projeto:

```bash
dotnet build .\ProjetoOrcamento.sln
dotnet list .\ProjetoOrcamento\ProjetoOrcamento.csproj package --vulnerable --include-transitive
```

O build atual compila sem avisos e sem erros.

## Autor

Antonio da Silva Freire de Carvalho Neto
