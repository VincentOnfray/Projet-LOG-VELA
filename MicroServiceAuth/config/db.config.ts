import { DataSource } from "typeorm";
import { role } from "../models/role.model";
import "reflect-metadata";
import { user } from "../models/user.model";

export const AppDataSource = new DataSource ({
    type: "mysql",
    host: "localhost",
    port: 3305,
    username: "root",
    password: "vela",
    database: "vela_db",
    synchronize: false,
    logging: false,
    entities: [role, user]
})

