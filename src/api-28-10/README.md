npm init -y(cria o projeto)

npm install -s express body-parser sequelize mariadb mysql2(instala as dependências)
npm i -D nodemon sequelize-cli

code .(abri o visual code)

crie o arquivo server.js

npx sequelize-cli init(cria as pastas: config, models, migrations e seeders)
*Se renomiar o arquivo "/config/config.json", não esquecer de renomea-lo em "/models/index.js"

npx sequelize-cli db: create (cria o banco, setado no arquivo de configuração)

CRIANDO AS MIGRATIONS:(não deixe espaços entre os atributos)
npx sequelize-cli model:generate --name usuario --attributes nome:STRING,email:STRING,passWorld:STRING
npx sequelize-cli model:generate --name setor --attributes descricao:STRING
npx sequelize-cli model:generate --name funcao --attributes descricao:STRING

npx sequelize-cli model:generate --name curso --attributes descricao:STRING,cargaHoraria:STRING,dataInicio:DATE,dataConclusao:DATE
npx sequelize-cli model:generate --name funcaoCurso --attributes funcaoId:INTEGER,cursoId:INTEGER

npx sequelize-cli model:generate --name funcionario --attributes matricula:STRING,cpf:STRING,ctps:STRING,admissao:DATE,demissao:DATE,
sexo:STRING,numero:STRING,logradouro:STRING,bairro:STRING,cidade:STRING,uf:STRING,usuarioId:INTEGER,setorId:INTEGER,funcaoId:INTEGER

npx sequelize-cli model:generate --name funcionarioCurso --attributes comprovante:STRING,cargaHoraria:STRING,dataInicio:DATE,
dataConclusao:DATE,funcionarioId:INTEGER,cursoId:INTEGER


npx sequelize-cli db:migrate(starta as migrations= cria as tabelas no banco)
npx sequelize-cli db:migrate:undo(desfaz a migration mas recente)
npx sequelize-cli db:migrate:undo:all(desfaz todas as migratons)
npx sequelize-cli db:migrate:undo:all --to XXXXXXXXXXXXXX-create-posts.js(desfaz uma migration específica)




https://sequelize.org/master/manual/migrations.html#creating-first-model--and-migration-
https://medium.com/@rogeriothe_48115/relacionamentos-com-sequelize-guia-final-2b3baf21b2a1
https://blog.rocketseat.com.br/nodejs-express-sequelize/

