Iniciar o projeto para web 

`dotnet new web -o todo-api -f net6.0`
-o -> output 
-f -> flag - define a versão do .net que será utilizada


`dotnet add package Microsoft.EntityFrameworkCore.Sqlite`
Adicionar pacote do sqlite ao projeto 

Erro na execução
- O pacote é incopativel com a versão 6 do .net
```
error: NU1202: Package Microsoft.EntityFrameworkCore.Sqlite 8.0.0 is not compatible with net6.0 (.NETCoreApp,Version=v6.0). Package Microsoft.EntityFrameworkCore.Sqlite 8.0.0 supports: net8.0 (.NETCoreApp,Version=v8.0)
error: Package 'Microsoft.EntityFrameworkCore.Sqlite' is incompatible with 'all' frameworks in project '/home/gabriel-matheus/github.com/itsmine/todo-api/todo-api.csproj'.
```

É necessário especificar a versão que será utilizada, adicionar `--version x.x.x` ao final do comando

Adicionar o pacote Design 
Será utilizado para gerar as migrações do BD
`dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.24`


Criado arquivo Todo.cs na pasta Models 
Criado class Todo com três atributos (id, title, done)

Criado arquivo Data/AppDbContext.cs ele represeta o contexto dos dados, seram os dados em memória.
Utiliza esse arquivo para mapear as entidades com os modelos

DbContext -> representa o BD
DbSet -> representa a tabela

OnConfiguring - não é utilizado pelo template da versão 6
Então foi utilizado o [artigo](https://macoratti.net/21/10/aspn6_expminapi1.htm) para configura o BD


dotnet clean
dotnet build 

dotnet ef migrations add InitialCreation - cria uma migração

dotnet ef database update - atualiza o banco a partir das migrations

Para versão 6, é necessário instalar a ferarmente do dotnet-ef 
`dotnet tool install --global dotnet-ef --version 7.0.0
`

Remove a ultima migração
dotnet ef migrations remove


Criado arquivo Controllers/TodoController.cs

Definido uma class TodoContoller que extende da class ControllerBase

Criado um método para o verbo Get para listar as tarefas


dotnet watch run