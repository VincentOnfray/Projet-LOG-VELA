import { DataSource } from 'typeorm';

import "reflect-metadata";
import {commande} from '../models/commande.model'
import {propose} from '../models/propose.model'
import {restaurant} from '../models/restaurant.model'
import {article} from '../models/article.model'

export const AppDataSource = new DataSource ({
    type: "mysql",
    host: "localhost",
    port: 3306,
    username: "root",
    password: "",
    database: "testdev",
    synchronize: false,
    logging: false,
    entities: [commande, propose, restaurant, article]
})

