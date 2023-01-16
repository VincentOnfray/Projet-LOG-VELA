import express ,{Application} from 'express'

import routes from './Auth/routes/auth.route';

const app: Application = express();

const port : number = 8081;

app.use(express.json());
app.use('/get', routes)  

app.listen(port, function(){
    console.log('app is listen on port ')
})