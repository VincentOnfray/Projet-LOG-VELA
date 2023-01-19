import {restaurant} from '../models/restaurant.model'
import { AppDataSource } from '../config/db.config';
import {Request, Response} from 'express'
import axios from 'axios';
import { Any } from 'typeorm';
import { AxiosRequestConfig } from "axios";



export async function addRestaurant(req: Request, res: Response) {

    try {
        const Restaurant = await AppDataSource.getRepository(restaurant).create({
            nom:req.body.nom,
            idUser:req.body.idUser
        })
        const results = await AppDataSource.getRepository(restaurant).save(Restaurant)
        return res.send(results)
    } catch (err) {
        console.log(err);
        res.status(500).json({message: "internal server error "});
    }
    
}

export async function getAllRestaurant(req: Request, res: Response) {
    try{
        const Restaurants = await AppDataSource.getRepository(restaurant).find()
        res.json(Restaurants);
        
    } catch(err){
        console.log(err);
        res.status(500).json({message: "internal server error "});
    }
}


export async function getRestaurantInfo(req: Request, res: Response) {
    try{
        const results = await AppDataSource.getRepository(restaurant).findOneBy({
            idRestaurant: Number(req.params.id),
        })
        const id = results?.idUser ?? 0;
        const {data} = await axios.get(`http://localhost:8080/get/findUser/${id}`);   
        const resp = {
            "name": data.name,
            "idCommande": results?.idRestaurant
        };
        return res.send(resp)
    } catch(err){
        console.log(err);
        res.status(500).json({message: "internal server error "});
    }
}


export async function findRestaurantById(req:Request, res: Response) {
    try {
        const results = await AppDataSource.getRepository(restaurant).findOneBy({
            idRestaurant: Number(req.params.id),
        })
      res.send(results);
    } catch (err) {
        console.log(err);
        res.status(500).json({message: "internal server error "});
    }
}