var express = require("express");
const bodyParser = require('body-parser');
const app = express();
const handlebars = require('express-handlebars');
const Funcionario = require('./models/Funcionario')

app.engine('handlebars', handlebars({defaultLayout: 'main'}))
app.set('view engine', 'handlebars');
//Body parser
app.use(bodyParser.urlencoded({extended: false}))
app.use(bodyParser.json())

//rotas
app.get('/', function(req, res){
res.render('formulario');
});
//rota para teste de validação no html
app.get('/createEmployees', function(req, res){
res.render('formulario');
});
//rotas de validação até aqui

//CARREGANDO FUNCIONÁRIOS, Post.findAll(), Deve ser alterado
app.get('/loadEmployees', function(req, res){
  Funcionario.findAll().then(function(post){
  	res.send(post);
  });
});


app.put('/updateEmployees/:id', function(req, res){
	Post.update(
	{nome: req.body.nome, funcao: req.body.funcao}, 
	{returning: true, where: {id: req.params.id}}
	).then(function(){
		res.send("alterado com sucesso");
	}).catch(function(erro){
		res.send("Houve um erro  " + erro);
	})
});

//Post.create deve ser alterado para conexão com banco 
app.post('/insertEmployees', function(req, res){
	Funcionario.create({
		nome: req.body.nome,
		datadeAdmissao: req.body.datadeAdmissao,
		rg: req.body.rg,
		cpf: req.body.cpf,
		endereco: req.body.endereco,
		email: req.body.email,
		cnh: req.body.cnh,
		funcao: req.body.funcao,
		setor: req.body.setor,
		cursos: req.body.cursos,
		nomeInstituicao: req.body.nomeInstituicao,
		nomeUsuario: req.body.nomeUsuario,
		senha: req.body.senha
	}).then(function(){
		res.send("post criado com sucesso");
	}).catch(function(erro){
		res.send("Houve um erro  " + erro);
	})
});

app.post('/insertSenha', function(req, res){
	Senha.create({
		cpf: req.body.cpf,
		senha: req.body.senha
	}).then(function(){
		res.send("post criado com sucesso");
	}).catch(function(erro){
		res.send("Houve um erro  " + erro);
	})
});

app.get('/deleteEmployees/:id', function(req, res){
Post.destroy({where: {'id': req.params.id}}).then(function(){
res.send('deletado com sucesso');
}).catch(function(erro){
res.send('este funcionário não existe');
});
});

let array = []

app.post("/test", (req,res)=>{

	array.push(req.body)
	console.log(array)
	res.sendStatus(200)
})
app.listen(8081, function(){
    console.log('localhost:8081');
});
//localhost:8081