import express ,{Application} from 'express'

import { AppDataSource } from './config/db.config';


AppDataSource.initialize()
.then( () => {
    console.log("je suis connecter ")
})
.catch((err) => {
    console.error("Error during Data Source initialization:", err)
})

import routes from './routes/role.route';

const app: Application = express();

const port : number = 8080;


app.use(express.json());
app.use('/get', routes)  

app.listen(port, function(){
    console.log('app is listen on port ')
})