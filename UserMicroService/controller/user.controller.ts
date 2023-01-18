//import { AppDataSource } from "../config/db.config";
import { user } from "../models/user.model";
import { AppDataSource } from "../config/db.config";
import { Request, Response } from 'express';
import * as crypto from 'crypto';



export async function getAllUser(req: Request, res: Response) {
        try{
            const users = await AppDataSource.getRepository(user).find()
            res.json(users);
        } catch(err){
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function insertUser(req: Request, res: Response) {
        try{
            const User = await AppDataSource.getRepository(user).create({
                name: req.body.name,
                firstname: req.body.firstname,
                email: req.body.email,
                password: crypto.createHash('md5').update(req.body.password).digest('hex'),
                idRole: req.body.idRole
            })

            const results = await AppDataSource.getRepository(user).save(User)
            return res.send(results)
   
        } catch(err){
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function findUser(req:Request, res: Response) {
        try {
            const results = await AppDataSource.getRepository(user).findOneBy({
                idUser: Number(req.params.id),
            })
            return res.send(results)
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function findUserByEmail(req:Request, res: Response) {
        try {
            const results = await AppDataSource.getRepository(user).findOneBy({
                email: req.body.email,
            })
            if (results) {   
                return res.send(results)
            } else {
                res.status(404).json({message: "user not found"});
            }
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function updateUser(req:Request, res: Response) {
        try {
            const User = await AppDataSource.getRepository(user).findOneBy({
                idUser: Number(req.params.id),
            })
            if (User) {
                AppDataSource.getRepository(user).merge(User, req.body)
                const results = await AppDataSource.getRepository(user).save(User)
                return res.send(results)
            } else {
                res.status(404).json({message: "user not found"});
            }
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function deleteUser(req:Request, res: Response) {
        try {
            const results = await AppDataSource.getRepository(user).delete(req.params.id)
            return res.send('User deleted !')
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }