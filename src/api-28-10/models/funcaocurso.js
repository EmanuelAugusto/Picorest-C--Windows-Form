'use strict';
module.exports = (sequelize, DataTypes) => {
  const funcaoCurso = sequelize.define('funcaoCurso', {
    funcaoId: DataTypes.INTEGER,
    cursoId: DataTypes.INTEGER
  }, {});
  funcaoCurso.associate = function(models) {
    // associations can be defined here
  };
  return funcaoCurso;
};