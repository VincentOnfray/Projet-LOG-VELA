import axios from 'axios';
import { Request, Response } from 'express';

export class RouterController {
   
    public async getUsers(req: Request, res: Response) {
   
        const users = await axios.get(`http://localhost:8080/get/AllUsers`);
        res.send(users.data);
    }

    public async connectUser(req: Request, res: Response) {
        const {data} = await axios.post(`http://localhost:8081/get/signin`, req.body);
        res.send(data);
    }

  
}
