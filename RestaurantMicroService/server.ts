import express ,{Application} from 'express'
import {AppDataSource} from './config/db.config'
import routes from './routes/commande.route'
const cors = require ('cors');
import routesArticle from './routes/article.route'
import routeRestaurant from './routes/restaurant.route'
AppDataSource.initialize()
.then( () => {
    console.log("je suis connecter ")
})
.catch((err) => {
    console.error("Error during Data Source initialization:", err)
})


const app: Application = express();
const port : number = 8084;
app.use(cors({ origin: '*', methods: "GET,HEAD,PUT,PATCH,POST,DELETE", allowedHeaders: ['*']}));

app.use(express.json());
app.use('/commande', routes)
app.use('/article',routesArticle)
app.use('/restaurant',routeRestaurant)
app.listen(port, function(){
    console.log('app is listen on port ')
})