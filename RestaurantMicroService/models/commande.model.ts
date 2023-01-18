import { Entity, Column, PrimaryGeneratedColumn } from 'typeorm';

@Entity()
export class commande {
    
    @PrimaryGeneratedColumn()
    idCommande!: number;

    @Column()
    prix!: number;

    @Column()
    date!: Date;

    @Column()
    idUser!: number;

    @Column()
    idRestaurant!: number;

    @Column("simple-array", { default: () => "array[]" })
    articles!: string[];

}



