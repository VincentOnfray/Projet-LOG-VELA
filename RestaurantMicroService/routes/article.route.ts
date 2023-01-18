import {Router} from 'express'
import { deleteArticle, findArticleById, getAllArticle, insertArticle, updateArticle } from '../controller/article.controller';


const router = Router();

router.get('/AllArticle', getAllArticle)
router.post('/AddArticle', insertArticle)
router.put('/updateArticle/:id', updateArticle)
router.delete('/deleteArticle/:id', deleteArticle)
router.post('/findArticleById', findArticleById)

export default router;