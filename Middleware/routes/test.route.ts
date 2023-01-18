import { Router } from 'express';
import { RouterController } from '../controller/controller';
import verifytoken from '../authVerify/auth.verify'

const router = Router();
const controller = new RouterController();

router.get('/getAllUser',controller.getUsers);
router.post('/signin', controller.connectUser)

export default router;