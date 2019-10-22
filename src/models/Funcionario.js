const Sequelize = require('sequelize');

const sequelize = new Sequelize('picorest', 'root', '', {
	host: 'localhost',
	dialect: 'mysql'
});


const Funcionarios = sequelize.define('funcionarios', {
	nome: {
		type: Sequelize.STRING
	},

	datadeAdmissao: {
		type: Sequelize.TEXT
	},
	rg :{
		type: Sequelize.STRING
	},
	cpf: {
		type: Sequelize.STRING
	},

	endereco: {
		type: Sequelize.TEXT
	},
	email :{
		type: Sequelize.STRING
	},
	cnh: {
		type: Sequelize.STRING
	},

	funcao: {
		type: Sequelize.TEXT
	},
	setor :{
		type: Sequelize.STRING
	},
	cursos: {
		type: Sequelize.STRING
	},

	nomeInstituicao: {
		type: Sequelize.TEXT
	},
	nomeUsuario :{
		type: Sequelize.STRING
	},
	senha: {
		type: Sequelize.STRING
	}

});

module.exports = Funcionarios

//Funcionarios.sync({force: true})