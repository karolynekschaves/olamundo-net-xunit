# Meu Primeiro Teste (.NET 10 + xUnit)

[![NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![xUnit](https://img.shields.io/badge/Testing-xUnit-blue)](https://xunit.net/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

Este projeto foi desenvolvido como parte do exercício prático da disciplina de **Garantia da Qualidade de Software / Gestão e Qualidade de Software**.

O objetivo principal é demonstrar a criação e estruturação de uma solução em **.NET 10** via interface de linha de comando (`.NET CLI`), aplicando os conceitos de **Testes Unitários** com o framework **xUnit** e garantindo boas práticas de arquitetura para testabilidade.

---

## 🚀 Tecnologias Utilizadas

- **[.NET 10.0](https://dotnet.microsoft.com/)**: Plataforma de desenvolvimento.
- **[xUnit](https://xunit.net/)**: Framework de testes unitários para .NET.
- **C#**: Linguagem de programação principal.
- **Git / GitHub**: Versionamento de código.

---

## 📂 Estrutura do Projeto

A solução foi organizada separando o código de produção (aplicação) dos testes unitários para garantir o desacoplamento e facilitando a manutenção:

```text
hello-world-xunit/
├── MeuPrimeiroTeste.sln                 # Arquivo de solução que une os projetos
├── MeuPrimeiroTeste.App/                # Projeto de Produção (Console Application)
│   ├── MeuPrimeiroTeste.App.csproj
│   ├── Program.cs
│   └── OlaMundo.cs                      # Classe com a regra de negócio/mensagem
└── MeuPrimeiroTeste.Tests/              # Projeto de Testes Unitários
    ├── MeuPrimeiroTeste.Tests.csproj
    └── OlaMundoTeste.cs                 # Classe de testes da suíte xUnit
```

---

## ⚙️ Configuração e Construção da Solução via .NET CLI

Para recriar a estrutura da solução do zero via CLI, foram seguidos os seguintes comandos:

```bash
# 1. Criação da Solução
dotnet new sln -n MeuPrimeiroTeste

# 2. Criação do projeto de aplicação (Código de Produção) em .NET 10
dotnet new console -n MeuPrimeiroTeste.App -f net10.0

# 3. Criação do projeto de Testes Unitários com xUnit em .NET 10
dotnet new xunit -n MeuPrimeiroTeste.Tests -f net10.0

# 4. Vinculação dos projetos à Solução
dotnet sln add MeuPrimeiroTeste.App/MeuPrimeiroTeste.App.csproj
dotnet sln add MeuPrimeiroTeste.Tests/MeuPrimeiroTeste.Tests.csproj

# 5. Adição da referência do projeto principal no projeto de Testes
dotnet add MeuPrimeiroTeste.Tests/MeuPrimeiroTeste.Tests.csproj reference MeuPrimeiroTeste.App/MeuPrimeiroTeste.App.csproj
```

---

## 💻 Implementação

### Código de Produção (`OlaMundo.cs`)
A classe `OlaMundo` foi projetada retornando o dado (string) para viabilizar a realização de testes unitários isolados, em vez de imprimir o resultado diretamente via `Console.WriteLine()`.

```csharp
namespace MeuPrimeiroTeste.App;

public class OlaMundo
{
    public string ObterMensagem()
    {
        return "Hello, World!";
    }
}
```

### Teste Unitário (`OlaMundoTeste.cs`)
O teste valida se o método `ObterMensagem()` retorna exatamente o resultado esperado ("Hello, World!").

```csharp
using Xunit;
using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests;

public class OlaMundoTeste
{
    [Fact]
    public void ObterMensagem_DeveRetornarHelloWord()
    {
        // Arrange
        var olaMundo = new OlaMundo();

        // Act
        var resultado = olaMundo.ObterMensagem();

        // Assert
        Assert.Equal("Hello, World!", resultado);
    }
}
```

---

## 🛠️ Como Executar o Projeto

### Pré-requisitos
- [.NET 10 SDK](https://dotnet.microsoft.com/download) instalado na máquina.

### Executando a Aplicação
Para executar a aplicação principal:

```bash
dotnet run --project MeuPrimeiroTeste.App/MeuPrimeiroTeste.App.csproj
```

### Executando os Testes Unitários
Para rodar a suíte de testes xUnit e verificar a validação das regras de negócio:

```bash
dotnet test
```
