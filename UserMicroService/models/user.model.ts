import { Entity, Column, PrimaryGeneratedColumn } from "typeorm";

@Entity()
export class user {
    @PrimaryGeneratedColumn()
    idUser!: number;

    @Column()
    name!: string ;

    @Column()
    firstname!: string ;

    @Column()
    email!: string ;

    @Column()
    password!: string ;

    
    @Column()
    idRole!: number ;

    @Column()
    idUser_parrainer!: number ;
}



