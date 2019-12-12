# try{

## Picorest - Gerenciamento de pessoas

-v2.0.1, 9 sprint

### Sistema de Formação Continuada 

Este sistema tem como objetivo principal auxiliar a gestores de empresas a tomarem decisões em relação a qual função ou setor vão encaixar seus funionários,
visando o melhor aproveitamento das capacitações de seus funcionários.
O sistema ainda esta na sua versão inicial, prezando o conceito de "MVP", o qual pode ser usado como complemento de um software de  ERP.

### Sobre o Desenvolvimento e os Desenvolvedores

- Emanuel Augusto - Programação Desktop, C#. 
- Israel Jeronimo - Programação da APi, Node.js.
- John Wanderson  - Programação da APi, Node.js.
- Matheus Henrique - Concepção do Projeto e Design das telas.
- Ramon Uriel - Concepção do Projeto e Design das telas.

A aplicação Desktop foi desenvolvida em C# (WindowsForm), utilizando uma Api Node RestFul, banco de dados relacional (MariaDb).

### Como Rodar o projeto?

clone este repositório:

- git clone https://github.com/EmanuelAugusto/Picorest-C--Windows-Form.git 

Em seguida clone o repositorio da Api:

- git clone https://github.com/EmanuelAugusto/api-picorest.git

Se quise acessar o codigo fonte do projeto abra-o no Visual Studio, ou senão acesse a pasta \Picorest-C--Windows-Form\Picorest-C--Windows-Form-master\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\ SFC - Sistema de Formação Continuada

- Vá até a pasta da Api 
   	abra o terminal de comando e digite;
   	" npm install "
   	quando as dependencias forem instaladas para fazer a migração das tabelas, digite;
   	" npx sequelize-cli db:migrate" 
   	no README.md do respositório no final se encontra as querys com nome de usuarios e senhas para acessar o projeto

- Se você abriu no Visual Studio Aperte Ctrl + F5 e projeto rodará.

# catch(Exception e){

Por conta de tempo abil publicamos uma versão da api no heroku mas, era uma versão instavel, e quanto publicação das interfaces futuras atualizações virão.

Dúvidas?
	envie um email para: emanoel.santos@a.ficr.edu.br

# }

### Projeto Desenvolvido no 2º Período do Curso de Análise e Desenvolvimento de Sistemas e Sistemas para Internet, na Faculdade Católica Imaculada Conceição do Recife.