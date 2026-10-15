# LH Pet – Sistema de Controle Interno (ASP.NET Core MVC)

Projeto web .NET 8 com arquitetura **MVC** para a clínica veterinária LH-Pet.

- **Models** (`Models/`): `Cliente` (Id, Nome, CPF, E-mail, Paciente) e `Fornecedor` (Id, Nome, CNPJ, E-mail).
- **Controller** (`Controllers/HomeController.cs`): cria e popula objetos `Cliente` e `Fornecedor`, agrupa em listas e envia para a view via `ViewBag`.
- **View** (`Views/Home/Index.cshtml`): template da equipe front-end exibindo as listas de clientes e fornecedores.

Ainda não há banco de dados; os dados são criados em memória no controller.

## Como executar

```bash
dotnet run
```

Acesse o endereço exibido no terminal (ex.: `http://localhost:5xxx`).
