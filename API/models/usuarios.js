'use strict';
module.exports = (sequelize, DataTypes) => {
  const usuarios = sequelize.define('usuarios', {
    name: DataTypes.STRING,
  }, {});
  usuarios.associate = function(models) {
    
  };
  return usuarios;
};