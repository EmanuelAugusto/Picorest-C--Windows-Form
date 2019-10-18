const express = require('express')
const bodyParser = require('body-parser')
const consign = require('consign')
const app = express()

app.set('json spaces', 4)
app.use(bodyParser.urlencoded({extended:false}))
app.use(bodyParser.json())

app.db = require('./models')

consign()
    .include('controller')
    .then('routes')
    .into(app)

    app.get('/',(req,res)=>{
        res.json({ola:"mundo"})
    })

app.listen(4000,()=>{
    console.log("Servidor Rodando!!")

})