> # DesafioNewCon

> # Requisitos 
> * Angular Cli  <br/>
> * Node 16.17.1  <br/>
> * .NET 6 SDK  <br/>
> * ASP.NET Core 6.0 Runtime (v6.0.9) - Windows Hosting Bundle <br/>
> * Visual Studio 2022  <br/>
> * Visual Studio Code <br/>
> * Sql Server <br/>
> # INSTRUÇÕES DE USO 
1 API <br/>

1.1 Selecione a pasta PontoTuristico-API e Abra a solução PontoTuristico  no visual vtudio, compile o mesmo, e altere a conexão em "appsettings.json" para o seu usuário e senha; <br/>
1.2 Após executado os processos acima rodar no terminal  do visual studio o seguinte comando [update-database]<br/>
1.3 Clique direita sobre o projeto PontoTuristico selecione Publicar e configure o local <br/>
1.4 Abra o ISS e  selecione a opção sites>adicionar sites, configure para a pasta da API e digite a porta <br/>

2 WEB <br/>

2.1 Abra a pasta PontosTutisticos-web no Visual Studio Code <br/>
2.2 Execute no terminar CMD o seguinte comando: npm install -g @angular/cli --global <br/>
2.3 Abra o IIS e  selecione a opção sites>adicionar sites, configure para a pasta do projeto web e digite a porta <br/>
2.4 abra os arquivos environment.ts e environment.prod.ts, altere para a porta em cada um para a criada no IIS <br/>
2.5 execute no terminal "ng s --o " 
