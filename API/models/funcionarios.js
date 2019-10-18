'use strict';
module.exports = (sequelize, DataTypes) => {
  const funcionarios = sequelize.define('funcionarios', {
    name: DataTypes.STRING,
    email: DataTypes.STRING
  }, {});
  funcionarios.associate = function(models) {
    funcionarios.belongsTo(models.usuarios,{
      foreignKey: "usuarioId"

    })
  };
  return funcionarios;
};