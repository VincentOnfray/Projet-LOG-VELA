import { AppDataSource } from '../config/db.config';
import { article } from "../models/article.model";
import { Request, Response } from 'express';




export async function getAllArticle(req: Request, res: Response) {
        try{
            const articles = await AppDataSource.getRepository(article).find()
            res.json(articles);
        } catch(err){
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }


    export async function insertArticle(req: Request, res: Response) {
        try{
            const Article = await AppDataSource.getRepository(article).create({
                idArticle: req.body.idLivraison,
                prix:req.body.date,
                type: req.body.idCommande
            })

            const results = await AppDataSource.getRepository(article).save(Article)
            return res.send(results)
   
        } catch(err){
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }



    export async function findArticleById(req:Request, res: Response) {
        try {
            const results = await AppDataSource.getRepository(article).findOneBy({
                idArticle: Number(req.params.id),
            })
            if (results) {  
                return res.send(results)
                                
            } else {
                res.status(404).json({message: "Article not found"});
            }
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function updateArticle(req:Request, res: Response) {
        try {
            const Article = await AppDataSource.getRepository(article).findOneBy({
                idArticle: Number(req.params.id),
            })
            if (Article) {
                AppDataSource.getRepository(article).merge(Article, req.body)
                const results = await AppDataSource.getRepository(article).save(Article)
                return res.send(results)
            } else {
                res.status(404).json({message: "Article not found"});
            }
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }

    export async function deleteArticle(req:Request, res: Response) {
        try {
            const results = await AppDataSource.getRepository(article).delete(req.params.id)
            return res.send('Article deleted !')
            
        } catch (err) {
            console.log(err);
            res.status(500).json({message: "internal server error "});
        }
    }