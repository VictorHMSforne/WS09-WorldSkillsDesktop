# WS

Cadeia de Conexão para adaptada para qualquer local:
```C#
SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"))}DbMedico.mdf"";Integrated Security=True");
```
