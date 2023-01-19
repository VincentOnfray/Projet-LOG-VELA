/*//import { AppDataSource } from "../config/db.config";
import { livraison } from "../models/livraison.model";
import { AppDataSource } from "../../db.config";
import { Request, Response } from 'express';
import * as crypto from 'crypto';



export async function getAllLivraison(req: Request, res: Response) {
        try{
            const livraisons = await AppDataSource.getRepository(livraison).find()
            res.json(livraisons);
        } catch(err){
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }


    export async function insertLivraison(req: Request, res: Response) {
        try{
            const Livraison = await AppDataSource.getRepository(livraison).create({
                idLivraison: req.body.idLivraison,
                date:req.body.date,
                idCommande: req.body.idCommande,
                idUser: req.body.idUser,
            })

            const results = await AppDataSource.getRepository(livraison).save(Livraison)
            return res.send(results)
   
        } catch(err){
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function findLivraison(req:Request, res: Response) {
        try {
            const results = await AppDataSource.getRepository(livraison).findOneBy({
                idLivraison: Number(req.params.id),
            })
            return res.send(results)
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function findLivraisonById(req:Request, res: Response) {
        try {
            const results = await AppDataSource.getRepository(livraison).findOneBy({
                idLivraison: req.body.idLivraison,
            })
            if (results) {   
                return res.send(results)
            } else {
                res.status(404).json({message: "Livraison not found"});
            }
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function updateLivraison(req:Request, res: Response) {
        try {
            const Livraison = await AppDataSource.getRepository(livraison).findOneBy({
                idLivraison: Number(req.params.id),
            })
            if (Livraison) {
                AppDataSource.getRepository(livraison).merge(Livraison, req.body)
                const results = await AppDataSource.getRepository(livraison).save(Livraison)
                return res.send(results)
            } else {
                res.status(404).json({message: "Livraison not found"});
            }
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function deleteLivraison(req:Request, res: Response) {
        try {
            const results = await AppDataSource.getRepository(livraison).delete(req.params.id)
            return res.send('Livraison deleted !')
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }*/