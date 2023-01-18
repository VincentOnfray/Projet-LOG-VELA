
DROP DATABASE IF EXISTS vela_db;
CREATE DATABASE IF NOT EXISTS vela_db;
USE vela_db ;


CREATE TABLE role(
        idRole Int  Auto_increment  NOT NULL ,
        name   Varchar (50) NOT NULL
	,CONSTRAINT role_PK PRIMARY KEY (idRole)
);

INSERT INTO role (name)
VALUES ('Admin'); 
INSERT INTO role (name)
VALUES ('Utilisateur_final');
INSERT INTO role (name)
VALUES ('Livreur');
INSERT INTO role (name)
VALUES ('Restaurateur');   




CREATE TABLE article(
        idArticle Int  Auto_increment  NOT NULL ,
        article   Varchar (50) NOT NULL ,
        prix      Float NOT NULL ,
        type      Bool NOT NULL
	,CONSTRAINT article_PK PRIMARY KEY (idArticle)
);


CREATE TABLE user(
        idUser           Int  Auto_increment  NOT NULL ,
        name             Varchar (50) NOT NULL ,
        firstname        Varchar (50) NOT NULL ,
        email            Varchar (50) NOT NULL ,
        password         Varchar (50) NOT NULL ,
        idRole           Int NOT NULL ,
        idUser_parrainer Int NOT NULL
	,CONSTRAINT user_PK PRIMARY KEY (idUser)
);



CREATE TABLE commande(
        idCommande   Int  Auto_increment  NOT NULL ,
        prix         Float NOT NULL ,
        date         Date NOT NULL ,
        idUser       Int NOT NULL ,
        idRestaurant Int NOT NULL
	,CONSTRAINT commande_PK PRIMARY KEY (idCommande)
);


CREATE TABLE restaurant(
        idRestaurant Int  Auto_increment  NOT NULL ,
        nom          Varchar (50) NOT NULL ,
        etat         Varchar (50) NOT NULL ,
        idUser       Int NOT NULL
	,CONSTRAINT restaurant_PK PRIMARY KEY (idRestaurant)
);


CREATE TABLE livraison(
        idLivraison Int  Auto_increment  NOT NULL ,
        date        Date NOT NULL ,
        idCommande  Int NOT NULL ,
        idUser      Int NOT NULL
	,CONSTRAINT livraison_PK PRIMARY KEY (idLivraison)
);


CREATE TABLE contient(
        idCommande Int NOT NULL ,
        idArticle  Int NOT NULL
	,CONSTRAINT contient_PK PRIMARY KEY (idCommande,idArticle)
);




ALTER TABLE user
	ADD CONSTRAINT user_role0_FK
	FOREIGN KEY (idRole)
	REFERENCES role(idRole);



ALTER TABLE commande
	ADD CONSTRAINT commande_user0_FK
	FOREIGN KEY (idUser)
	REFERENCES user(idUser);

ALTER TABLE commande
	ADD CONSTRAINT commande_restaurant1_FK
	FOREIGN KEY (idRestaurant)
	REFERENCES restaurant(idRestaurant);

ALTER TABLE restaurant
	ADD CONSTRAINT restaurant_user0_FK
	FOREIGN KEY (idUser)
	REFERENCES user(idUser);

ALTER TABLE restaurant 
	ADD CONSTRAINT restaurant_user0_AK 
	UNIQUE (idUser);

ALTER TABLE livraison
	ADD CONSTRAINT livraison_commande0_FK
	FOREIGN KEY (idCommande)
	REFERENCES commande(idCommande);

ALTER TABLE livraison
	ADD CONSTRAINT livraison_user1_FK
	FOREIGN KEY (idUser)
	REFERENCES user(idUser);

ALTER TABLE livraison 
	ADD CONSTRAINT livraison_commande0_AK 
	UNIQUE (idCommande);

ALTER TABLE contient
	ADD CONSTRAINT contient_commande0_FK
	FOREIGN KEY (idCommande)
	REFERENCES commande(idCommande);

ALTER TABLE contient
	ADD CONSTRAINT contient_article1_FK
	FOREIGN KEY (idArticle)
	REFERENCES article(idArticle);
