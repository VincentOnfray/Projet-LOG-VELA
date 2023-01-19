import {Router} from 'express'
import {addRestaurant, findRestaurantById, getAllRestaurant, getRestaurantInfo} from '../controller/restaurant.controller'

const router = Router();

router.post('/addRestaurant', addRestaurant);
router.get('/getRestaurant', getAllRestaurant)
router.get('/getMyRestaurant/:id', getRestaurantInfo)
router.get('/getRestaurant/:id', findRestaurantById)

export default router;