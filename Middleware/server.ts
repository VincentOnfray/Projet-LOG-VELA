import express ,{Application} from 'express'
import router from './routes/test.route';
const cors = require ('cors');
const app: Application = express();

const port : number = 8082;
app.use(cors({ origin: '*', methods: "GET,HEAD,PUT,PATCH,POST,DELETE", allowedHeaders: ['*']}));
app.use(express.json());
app.use('/get', router)  
app.listen(port, function(){
    console.log('app is listen on port ')
})

