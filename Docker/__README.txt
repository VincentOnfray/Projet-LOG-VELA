Pour run MYSQL:

- Installer Docker Desktop

- executer __VELA_Full_Pipeline.ps1

pour verif que tout s'est bien passé:
à la fin du script pipeline, une ligne bash s'affiche:
taper les lignes suivantes:
->mysql -u root -pvela  //pas d'espace entre -p et vela
->use vela_db;
->show tables;

Les 7 tables de l'UML apparaissent.
la console MYSQL accepte les requetes sql, donc on peut tester tout ce qu'il faut


**** INFO MYSQL *****
Port utilisé: 3306  
(Attention c'est le port MYSQL par defaut,
 si un autre serveur mysql tourne sur le PC,
il risque d'y avoir un conflit)

mdp root : vela
utilisateur lambda pseudo: vela
utilisateur lambda mdp: vela

la bdd s'appelle "vela_db" dans le système mysql

 


