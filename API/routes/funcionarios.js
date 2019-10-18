module.exports = app =>{

    app.route('/funcionarios')
        .get(app.controller.funcionarios.findAll)
        .post(app.controller.funcionarios.create)

}