import { Request, Response } from 'express';
import * as bcrypt from 'bcrypt';
import * as jwt from 'jsonwebtoken';
import  {key} from '../config/auth.config'
import * as crypto from 'crypto';

import axios from 'axios';


export async function signUp(req: Request, res: Response) {
    try{
        // Récupération des données de l'utilisateur à partir de req.body
    const userData = req.body;
    // Appel de l'API userinsert en passant les données de l'utilisateur dans le corps de la requête
    const {data} = await axios.post('http://localhost:8080/get/AddUser',userData);
    console.log('Utilisateur enregistré avec succès');
    console.log(`L'ID de l'utilisateur créé est: ${data.idUser}`);
    res.send(data);
    } catch(err){
        console.log(err);
        res.status(500).json({message: "internal server error "});
    }
}


export async function signIn(req: Request, res: Response) {
    try{
       
    const {data} = await axios.post('http://localhost:8080/get/findUserByEmail',req.body);

    const passwordIsValide = crypto.createHash('md5')
    .update(req.body.password)
    .digest('hex') === data.password;

    if (!passwordIsValide){
        return res.status(401).send({
          accessToken: null,
          message: "Invalid Password!"
        });
      }

    const token =  jwt.sign({ id: data.idUser, role: data.idRole }, key.secret, {
      expiresIn: 86400, // 24 hours
      algorithm: 'HS256'
    });
    data.accessToken = token;
    res.send(data);
    } catch(err){
        console.log(err);
        res.status(500).json({message: "internal server error "});
    }
}

