# WS

# Cadeia de conexão para .NET Framework:

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

6. Antes de Finalizarmos, é necessário que você mude uma propriedade do seu projeto,
clique com o ***botão direito*** do mouse no projetop, para abrir as propriedades.
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo-5.png"/>

7. Após aberto essa janela, clique na opção compilar e em: ***Caminho de saída*** clique em ***Procurar...***
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo-6.png"/>

8. Feito isso, volte duas pastas de onde está localizado, provavelmente fique assim:
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo-7.png"/>
Depois clique em selecionar pasta.

9. Por fim a ideia é que fique assim:
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo-8.png"/>

---

## Avisando:

Quando você exportar o seu projeto, o seu BD estará preenchido com os dados anteriores, pois, como mudamos o diretório de saída, estamos utilizando o BD da versão de desenvolvimento
e não a versão de execução

---
# Cadeia de Conexão para o .NET:

Código para a Cadeia de Conexão:
```C#
string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DbMedico.mdf");
string _connectionString = $@"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFilename={databasePath};";
```
1. De forma Geral o código irá ficar assim:
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo1-net.png"/>

2. Após ter inserido o BD no seu projeto, clique com o botão direito sobre os arquivos gerados e vá nas propriedades de cada um:
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo2-net.png"/>
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo3-net.png"/>
Note abaixo, que no meu já está como: **Copiar sempre**, mas por padrão costuma vir: **Não Copiar**.
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo4-net.png"/>
Troque de **Não Copiar** para **Copiar Sempre**
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo5-net.png"/>
3. Por Fim faça com ambos os arquivos do BD gerados:
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo4-net.png"/>
<img src="https://github.com/VictorHMSforne/WS09-WorldSkillsDesktop/blob/master/Etapas/passo6-net.png"/>



