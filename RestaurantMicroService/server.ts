import express ,{Application} from 'express'
import {AppDataSource} from './config/db.config'
import routes from './routes/commande.route'
import routesArticle from './routes/article.route'

AppDataSource.initialize()
.then( () => {
    console.log("je suis connecter ")
})
.catch((err) => {
    console.error("Error during Data Source initialization:", err)
})


const app: Application = express();
const port : number = 8081;

app.use(express.json());
app.use('/commande', routes)
app.use('/article',routesArticle)

app.listen(port, function(){
    console.log('app is listen on port ')
})