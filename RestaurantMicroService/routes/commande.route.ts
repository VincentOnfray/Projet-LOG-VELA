import {Router} from 'express'
import {addCommande, findCommandeById, getAllCommande, getCommandeInfo} from '../controller/commande.controller'

const router = Router();

router.post('/addCommande', addCommande);
router.get('/getCommande', getAllCommande)
router.get('/getMyCommande/:id', getCommandeInfo)
router.get('/getCommandeArticles/:id', findCommandeById)

export default router;