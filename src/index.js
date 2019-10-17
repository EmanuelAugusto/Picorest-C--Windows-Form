var express = require("express");
const bodyParser = require('body-parser');
const app = express();
const handlebars = require('express-handlebars');
const Post = require('./models/Post')

app.engine('handlebars', handlebars({defaultLayout: 'main'}))
app.set('view engine', 'handlebars');
//Body parser
app.use(bodyParser.urlencoded({extended: false}))
app.use(bodyParser.json())

//rotas
//rota para teste de validação no html
app.get('/createEmployees', function(req, res){
res.render('formulario');
});
//rotas de validação até aqui

//CARREGANDO FUNCIONÁRIOS, Post.findAll(), Deve ser alterado
app.get('/loadEmployees', function(req, res){
  Post.findAll().then(function(post){
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
	Post.create({
		nome: req.body.nome,
		funcao: req.body.funcao
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

app.listen(8081, function(){
    console.log('localhost:8081');
});
//localhost:8081