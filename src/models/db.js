const Sequelize = require('sequelize');

const sequelize = new Sequelize('picorest', 'root', '', {
	host: 'localhost',
	dialect: 'mysql'
});

module.exports = {
	Sequelize: sequelize,
	sequelize: sequelize
}