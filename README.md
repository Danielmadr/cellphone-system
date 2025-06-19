# SmartphoneSolutionCSharp - Desafio de Projeto .NET POO

![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

Este repositório contém uma solução aprimorada para o desafio de projeto "Abstraindo um Smartphone com POO" proposto no bootcamp .NET da Digital Innovation One (DIO).

O projeto original pode ser encontrado em [digitalinnovationone/trilha-net-poo-desafio](https://github.com/digitalinnovationone/trilha-net-poo-desafio).

Esta versão implementa algumas melhorias em relação ao código base, além de introduzir novas funcionalidades para gerenciar os aplicativos instalados nos dispositivos.

## Visão Geral do Projeto

O `SmartphoneSolutionCSharp` simula um sistema de gerenciamento de smartphones via console. Ele permite representar diferentes modelos de celulares (Nokia e iPhone), realizar chamadas, instalar aplicativos e realizar operações de gerenciamento dos apps.

## Principais Mudanças e Funcionalidades Implementadas

Esta solução se diferencia do projeto original através das seguintes modificações:

### 1. Sistema de Gerenciamento de Aplicativos Instalados

Cada smartphone agora mantém uma **lista interna de aplicativos instalados**, permitindo:

- Instalar novos aplicativos.
- Listar todos os aplicativos instalados.
- Impedir a instalação duplicada de um mesmo app.
- Desinstalar aplicativos.

## Como Executar

1. **Clone o repositório:**

```bash
git clone https://github.com/SeuUsuario/SmartphoneSolutionCSharp.git
cd SmartphoneSolutionCSharp
```

2. **Compile o projeto:**

```bash
dotnet build
```

3. **Execute a aplicação:**

```bash
dotnet run
```

O programa irá rodar um exemplo simples de criação de um Nokia e um iPhone, com instalação e remoção de aplicativos, além de chamadas.

---

*Este projeto foi desenvolvido como parte do Bootcamp .NET da DIO.*