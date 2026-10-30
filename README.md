# MiniEcommerce

Um projeto de **Mini E-commerce** desenvolvido em C# com .NET, organizado em uma solução modular que separa entidades, aplicação via console e testes automatizados.

O projeto tem como objetivo implementar conceitos fundamentais de um sistema de comércio eletrônico, mantendo uma estrutura organizada e de fácil manutenção.

## Estrutura do Projeto

A solução está organizada nos seguintes diretórios:

```text
MiniEcommerce/
│
├── Entities/
│   └── Entidades do sistema
│
├── MiniEcommerce.Console/
│   └── Aplicação principal
│
├── MiniEcommerce.Tests/
│   └── Testes automatizados
│
├── MiniEcommerce.slnx
│
├── LICENSE
│
└── README.md
```

### Organização

- **Entities:** contém o projeto destinado às entidades e estruturas de dados do sistema.
- **MiniEcommerce.Console:** aplicação executável por meio do terminal.
- **MiniEcommerce.Tests:** projeto destinado à implementação e execução de testes automatizados.

## Tecnologias

- **C#** — linguagem de programação.
- **.NET** — plataforma de desenvolvimento.
- **.NET CLI** — ferramenta de compilação e execução.
- **Git e GitHub** — versionamento e hospedagem do código.

## Pré-requisitos

Antes de executar o projeto, você precisará ter instalado:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)

## Como executar

**1. Clone o repositório**

```bash
git clone https://github.com/Benadinhog/MiniEcommerce.git
```

**2. Entre na pasta do projeto**

```bash
cd MiniEcommerce
```

**3. Compile a solução**

```bash
dotnet build
```

**4. Execute a aplicação**

```bash
dotnet run --project MiniEcommerce.Console
```

## Executando os testes

Para executar os testes automatizados da solução, utilize:

```bash
dotnet test
```

Esse comando executa os testes disponíveis nos projetos de teste da solução.

## Compilação

Para gerar a compilação de todos os projetos da solução:

```bash
dotnet build MiniEcommerce.slnx
```

## Licença

Este projeto está disponibilizado sob a licença **MIT**.

Consulte o arquivo [LICENSE](./LICENSE) para obter mais informações.

---

<p align="center">
  Desenvolvido com 💙 utilizando C# e .NET.
</p>
