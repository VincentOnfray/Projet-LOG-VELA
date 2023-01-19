use vela_db;

INSERT INTO user (name,firstname,email,password,idRole,idUser_parrainer)
VALUES ('Vincent','ONFRAYT','privata@wont.tell','zesredtfyguhitgrfed(-è^$*ù','1','5');
INSERT INTO user (name,firstname,email,password,idRole,idUser_parrainer)
VALUES ('Raph','Kollo','rako@wont.tell','zesredtfyguhitgrfed(-è^$*ù','2','1');
INSERT INTO user (name,firstname,email,password,idRole,idUser_parrainer)
VALUES ('Hellen','Couzon','helco@wont.tell','rytugihojpo','1','20');
INSERT INTO user (name,firstname,email,password,idRole,idUser_parrainer)
VALUES ('Marie','Cantonnais','maca@wont.tell','ffetet','3','10');
INSERT INTO user (name,firstname,email,password,idRole,idUser_parrainer)
VALUES ('Jacques','Ebab','jab@wont.tell','tdrfyfgtuh','4','25');
INSERT INTO user (name,firstname,email,password,idRole,idUser_parrainer)
VALUES ('Violette','Bob','viobo@wont.tell','1234567890','3','75');




INSERT INTO restaurant (nom,etat,idUser)
VALUES ('Zozan Kebab','Ouvert','5');
INSERT INTO restaurant (nom,etat,idUser)
VALUES ('Delices d Istanbul','Ouvert','3');



INSERT INTO article (article,prix,type,idRestaurant)
VALUES ('Spécial Zozy','220',false,'1');
INSERT INTO article (article,prix,type,idRestaurant)
VALUES ('kebab lambda','20',false,'1');
INSERT INTO article (article,prix,type,idRestaurant)
VALUES ('Frittas tmtc','50',false,'1');

INSERT INTO article (article,prix,type,idRestaurant)
VALUES ('Tomates en bois','220',false,'2');
INSERT INTO article (article,prix,type,idRestaurant)
VALUES ('Burger en Or','20',false,'2');
INSERT INTO article (article,prix,type,idRestaurant)
VALUES ('Giga gigot','50',false,'2');