# WS

Cadeia de Conexão adaptada para qualquer local, caso você não queira gerar o executável:
```C#
SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"))}nomeDoBanco.mdf"";Integrated Security=True");
```
---
Caso seja necessário gerar um executável:

 1. Primeiramente procure o App.Config da sua solução:
 <img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo-1.png"/>

 2. Depois Digite o código do Connection Strings:
 <img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo-2.png"/>

 Código:
 ```xml
<connectionStrings>
    <add name="MedicoDb"
         connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\nomeDoBanco.mdf;Integrated Security=True"
         providerName="System.Data.SqlClient"/>
</connectionStrings>
 ```

3. Agora Procure o Program.cs de sua solução:
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo-3.png"/>
4. Digite o Código App.Domain:
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo-4.png"/>

Código:
```C#
AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
```

5. Onde está a string de Conexão use o código, adicione também a biblioteca ***System.Configuration***:
```C#
SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["nomeUsado no add name da etapa 2"].ConnectionString);
```

6. Antes de Finalizarmos, é necessário que você mude uma Propriedade do seu BD(O nome do BD está diferente, pois eu estava fazendo o teste em outro projeto, mas realize o tutorial normalmente):
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo-5.png"/>

Clique com o ***botão direito*** do mouse no BD, para abrir as propriedades.

7. Em **Copiar para diretório de Saída** mude a opção `Copiar sempre` para: `Copiar se for mais novo`:

<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo-6.png"/>
 


