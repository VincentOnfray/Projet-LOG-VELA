import {commande} from '../models/commande.model'
import { AppDataSource } from '../config/db.config';
import {Request, Response} from 'express'
import axios from 'axios';
import { Any } from 'typeorm';
import { AxiosRequestConfig } from "axios";



export async function addCommande(req: Request, res: Response) {

    try {
        const Commande = await AppDataSource.getRepository(commande).create({
            prix: req.body.prix,
            idUser: req.body.idUser,
            date: req.body.date,
            idRestaurant: req.body.idRestaurant,
            articles: req.body.articles
        })
        const results = await AppDataSource.getRepository(commande).save(Commande)
        return res.send(results)
    } catch (err) {
        console.log(err);
        res.status(500).json({message: "internal server error "});
    }
    
}

export async function getAllCommande(req: Request, res: Response) {
    try{
        const commandes = await AppDataSource.getRepository(commande).find()
        res.json(commandes);
        
        
    } catch(err){
        console.log(err);
        res.status(500).json({message: "internal server error "});
    }
}


export async function getCommandeInfo(req: Request, res: Response) {
    try{
        const results = await AppDataSource.getRepository(commande).findOneBy({
            idCommande: Number(req.params.id),
        })
        const id = results?.idUser ?? 0;
        const {data} = await axios.get(`http://localhost:8080/get/findUser/${id}`);   
        const resp = {
            "name": data.name,
            "idCommande": results?.idRestaurant,
            "prix": results?.prix
        };
        return res.send(resp)
    } catch(err){
        console.log(err);
        res.status(500).json({message: "internal server error "});
    }
}


export async function findCommandeById(req:Request, res: Response) {
    try {
        const results = await AppDataSource.getRepository(commande).findOneBy({
            idCommande: Number(req.params.id),
        })
        if (results) {
            for (let i = 0; i < results.articles.length; i++) {
                console.log(results.articles[i] + "\n")
            }  
            return res.send(results)
                  
        } else {
            res.status(404).json({message: "Article not found"});
        }
        
    } catch (err) {
        console.log(err);
        res.status(500).json({message: "internal server error "});
    }
}




