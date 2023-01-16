import { Router } from 'express';
import { getAllUser, insertUser, findUser, updateUser, deleteUser, findUserByEmail } from '../controller/user.controller';
import { roless } from '../controller/role.controller';
const router = Router();


router.get('/GetRole', roless)
router.get('/AllUsers', getAllUser)
router.post('/AddUser', insertUser)
router.get('/findUser/:id', findUser)
router.put('/updateUser/:id', updateUser)
router.delete('/deleteUser/:id', deleteUser)
router.post('/findUserByEmail', findUserByEmail)

export default router;