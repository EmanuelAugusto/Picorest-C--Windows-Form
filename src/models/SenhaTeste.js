const Sequelize = require('sequelize');

const sequelize = new Sequelize('picorest', 'root', '', {
	host: 'localhost',
	dialect: 'mysql'
});


const senha = sequelize.define('senha', {
	cpf: {
		type: Sequelize.STRING
	},

	senha: {
		type: Sequelize.TEXT
	}
});

module.exports = senha

//senha.sync({force: true})