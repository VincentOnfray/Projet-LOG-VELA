import { role } from "../models/role.model";
import  "../config/db.config";
import { Request, Response } from 'express';
import { AppDataSource } from "../config/db.config";


    export async function roless(req: Request, res: Response) {
        try{
            const roles = await AppDataSource.getRepository(role).findOneBy({
                name: req.body.name
              })
  
          console.log("Loaded users: ", roles)
        
        res.json(roles);
        } catch(err){
            console.log(err);
            res.status(500).json({message: "internal server error hellor"});
        }
    }
    

    export async function insertRole(req: Request, res: Response){
        try {
            const roles = await AppDataSource.getRepository(role).create(req.body)
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error hellor"});
        }
    }

    