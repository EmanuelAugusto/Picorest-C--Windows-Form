module.exports = app => {

    let usuarios = app.db.usuarios

    return{
        findAll: async (req,res) => {
            try {
                let result = await usuarios.findAll({
                
                })

                res.json(result)
                
            } catch (error) {
                res.json(error)
            }
        },
        create: async (req,res) => {
            try {
                let result = await usuarios.create(req.body)
                res.json(result)
            } catch (error) {
                res.json(error)
            }
        }
    }
}