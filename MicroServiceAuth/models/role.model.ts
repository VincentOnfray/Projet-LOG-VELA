
import { Entity, Column, PrimaryGeneratedColumn } from "typeorm";

@Entity()
export class role {
    @PrimaryGeneratedColumn()
    idRole!: number;

    @Column()
    name!: string ;
}



