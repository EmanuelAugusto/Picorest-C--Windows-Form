'use strict';
module.exports = (sequelize, DataTypes) => {
  const funcionarioCurso = sequelize.define('funcionarioCurso', {
    comprovante: DataTypes.STRING,
    cargaHoraria: DataTypes.STRING,
    dataInicio: DataTypes.DATE,
    dataConclusao: DataTypes.DATE,
    funcionarioId: DataTypes.INTEGER,
    cursoId: DataTypes.INTEGER
  }, {});
  funcionarioCurso.associate = function(models) {
    // associations can be defined here
  };
  return funcionarioCurso;
};