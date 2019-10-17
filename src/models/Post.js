const Sequelize = require('sequelize');

const sequelize = new Sequelize('picorest', 'root', '', {
	host: 'localhost',
	dialect: 'mysql'
});


const Postagem = sequelize.define('funcionarios', {
	nome: {
		type: Sequelize.STRING
	},

	funcao: {
		type: Sequelize.TEXT
	}
});

module.exports = Postagem

//Postagem.sync({force: true})