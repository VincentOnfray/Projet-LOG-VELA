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

    public async getRestaurants(req: Request, res: Response) {
        try {
            const {data} = await axios.get("http://localhost:8084/Restaurant/getRestaurant");
            if (data) {
                res.send(data);
            } else {
                res.status(404).json({message: "user not found"});
            }

        } catch (error) {
            res.status(500).json({message: "internal server error "});
        }
 
    }

  
}
