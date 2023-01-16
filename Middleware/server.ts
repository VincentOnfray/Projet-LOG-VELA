import express ,{Application} from 'express'

import router from './routes/test.route';

const app: Application = express();

const port : number = 8082;

app.use(express.json());
app.use('/get', router)  

app.listen(port, function(){
    console.log('app is listen on port ')
})