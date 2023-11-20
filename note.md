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