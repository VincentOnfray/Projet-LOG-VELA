import { Entity, Column, PrimaryGeneratedColumn } from "typeorm";

@Entity()
export class restaurant {
    
    @PrimaryGeneratedColumn()
    idRestaurant!: number;

    @Column()
    nom!: string;

    @Column()
    etat!: string;

    @Column()
    idUser!: number;

}
