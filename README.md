# WS

Cadeia de Conexão adaptada para qualquer local, caso você não queira gerar o executável:
```C#
SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"))}(nomeDoBanco).mdf"";Integrated Security=True");
```
Caso seja necessário gerar um executável:

 1. Primeiramente procure o App.Config da sua solução:

