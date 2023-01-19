import { Entity, Column, PrimaryGeneratedColumn } from "typeorm";

@Entity()
export class article {
    
    @PrimaryGeneratedColumn()
    idArticle!: number;

    @Column()
    article!: string;

    @Column()
    prix!: number;

    @Column()
    type!: string;

}