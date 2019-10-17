const Sequelize = require('sequelize');

const sequelize = new Sequelize('restaurante', '', '', {
	host: 'https://demo.phpmyadmin.net/master-config/',
	dialect: 'mysql'
});

module.exports = {
	Sequelize: sequelize,
	sequelize: sequelize
}