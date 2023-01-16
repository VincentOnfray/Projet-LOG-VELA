import { Router} from "express";
import { signIn, signUp } from "../controller/auth.controller";

const router = Router();


router.post('/addUser', signUp);
router.post('/signin', signIn)

export default router;

