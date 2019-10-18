module.exports = app => {

    let funcionarios = app.db.funcionarios

    return{
        findAll: async (req,res) => {
            try {
                let result = await funcionarios.findAll({})
                res.json(result)

            } catch (error) {
                res.json(error)
            }
        },
        create: async (req,res) => {
            try {
                let result = await funcionarios.create(req.body)
                res.json(result)
            } catch (error) {
                res.json(error)
            }
        }
    }
}