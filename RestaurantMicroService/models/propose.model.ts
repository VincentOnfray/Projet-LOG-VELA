import { Entity, Column, PrimaryColumn } from "typeorm";

@Entity()
export class propose {
    
    @PrimaryColumn()
    idRestaurant!: number;

    @PrimaryColumn()
    idArticle!: number;

}

