module.exports = app =>{

    app.route('/usuarios')
        .get(app.controller.usuarios.findAll)
        .post(app.controller.usuarios.create)

}