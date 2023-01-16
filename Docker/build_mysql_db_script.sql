DROP DATABASE IF EXISTS vela_db;
CREATE DATABASE IF NOT EXISTS vela_db;
USE vela_db ;


CREATE TABLE IF NOT EXISTS RoleUtilisateur (
  idRoleUtilisateur INT NOT NULL  PRIMARY KEY,
  Nom VARCHAR(45) NULL);

CREATE TABLE IF NOT EXISTS EtatUtilisateur (
  idEtatUtilisateur INT NOT NULL PRIMARY KEY,
  Nom VARCHAR(45) NULL);

  CREATE TABLE IF NOT EXISTS Utilisateur (
  idUtilisateur INT NOT NULL PRIMARY KEY,
  Mail VARCHAR(45) NULL,
  MotDePasse VARCHAR(45) NULL,
  Nom VARCHAR(45) NULL,
  idRole INT NULL,
  idEtat INT NULL,
  idParrain INT NULL,
  INDEX IDRole_idx (idRole),
  INDEX IDEtat_idx (idEtat),
  INDEX IDParrain_idx (idParrain),
  CONSTRAINT IDRole
    FOREIGN KEY (idRole)
    REFERENCES RoleUtilisateur (idRoleUtilisateur)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT IDEtat
    FOREIGN KEY (idEtat)
    REFERENCES EtatUtilisateur (idEtatUtilisateur)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT IDParrain
    FOREIGN KEY (idParrain)
    REFERENCES Utilisateur (idUtilisateur)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

CREATE TABLE IF NOT EXISTS RoleEmploi (
  idRoleEmploi INT NOT NULL PRIMARY KEY ,
  Nom VARCHAR(45) NULL);

CREATE TABLE IF NOT EXISTS EtatRestaurant (
  idEtatRestaurant INT NOT NULL PRIMARY KEY ,
  Nom VARCHAR(45) NULL);

  CREATE TABLE IF NOT EXISTS Restaurant (
  idRestaurant INT NOT NULL PRIMARY KEY,
  Nom VARCHAR(45) NULL,
  idEtat INT NULL,
  INDEX idEtatRestaurant_idx (idEtat ) VISIBLE,
  CONSTRAINT idEtatRestaurant
    FOREIGN KEY (idEtat)
    REFERENCES EtatRestaurant (idEtatRestaurant)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

  CREATE TABLE IF NOT EXISTS Emploi (
  idRestaurant INT NULL,
  idUtilisateur INT NULL,
  idRoleEmploi INT NULL,
  INDEX idResto_idx (idRestaurant ) VISIBLE,
  INDEX idUtilisateur_idx (idUtilisateur ) VISIBLE,
  INDEX idRoleEmploi_idx (idRoleEmploi ) VISIBLE,
  CONSTRAINT idResto
    FOREIGN KEY (idRestaurant)
    REFERENCES Restaurant (idRestaurant)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT idUtilisateur
    FOREIGN KEY (idUtilisateur)
    REFERENCES Utilisateur (idUtilisateur)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT idRoleEmploi
    FOREIGN KEY (idRoleEmploi)
    REFERENCES RoleEmploi (idRoleEmploi)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)




