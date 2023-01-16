import { Request, Response , NextFunction} from "express";
import {key} from '../config/auth.config'
import * as jwt from 'jsonwebtoken';


const verifyToken = (req: Request, res: Response, next: NextFunction) => {
    const token: string | undefined = req.headers["authorization"] as string;
  
    try {
        const decoded = jwt.verify(token, key.secret, { algorithms: ['HS256'] });
        console.log('iniy');
        
        console.log(decoded);
        next();
    } catch (err) {
        console.log(err);
        res.status(401).send('Unauthorized: Invalid token');
    }
};

export default verifyToken;
