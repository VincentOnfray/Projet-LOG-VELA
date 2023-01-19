<template>
    <ion-page>
      <ion-header :translucent="true">
        <ion-toolbar>
          <ion-buttons slot="start">
            <ion-menu-button color="secondary"></ion-menu-button>
          </ion-buttons>
          <h1>Bienvenue sur votre profil</h1>
          <ion-title>{{ $route.params.id }}</ion-title>
        </ion-toolbar>
      </ion-header>
  
      <ion-content :fullscreen="true">
        <ion-header collapse="condense">
          <ion-toolbar>
            <ion-title size="large">{{ $route.params.id }}</ion-title>
          </ion-toolbar>
        </ion-header>
        <h2>Modifier mes informations</h2>
        <div id="container">
          <strong class="capitalize">{{ $route.params.id }}</strong>
          <form action="connexion">

            <div class="container">
            <label for="uname"><b>Nom d'utilisateur</b></label>
            <input type="text" placeholder="Nom d'utilisateur" name="uname" required>

            <label for="psw"><b>Mot de passe</b></label>
            <input type="password" placeholder="Mot de passe" name="psw" required>
            <label for="uname"><b>Adresse mail</b></label>
            <input type="text" placeholder="Adresse Mail" name="email" required>

            <button type="submit">Modification</button>
            <button class="submitone">Créer un nouveau compte</button>
            <button class= "submittwo">Supprimer mon compte</button>


            </div>
            </form>

        </div>
      </ion-content>
    </ion-page>
  </template>
  
  <script setup lang="ts">
  import { IonButtons, IonContent, IonHeader, IonMenuButton, IonPage, IonTitle, IonToolbar } from '@ionic/vue';
</script>
  
  <style scoped>
  .submitone{
    background-color:orange;

  }
  .submittwo{
    background-color:red;
  }
  .container{
    width: 50em;
    margin : 0 auto;
  }
  .bar {
    display: inline-block;
    margin: 0;
  }
  li {
    display: inline-block;
    margin: 0 10px;
  }
  a {
    color: #42b983;
  }
  /* Bordered form */
form {
  width:5em;
}
h2{
    color:white;
    margin-left: 2em;

}
/* Full-width inputs */
input[type=text], input[type=password] {
  width: 30em;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}
label{
    width:100%;
    display: inline-block;

}

/* Set a style for all buttons */
button {
  background-color: #04AA6D;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 51%;
}

/* Add a hover effect for buttons */
button:hover {
  opacity: 0.8;
}

/* Extra style for the cancel button (red) */
.cancelbtn {
  width: auto;
  padding: 10px 18px;
  background-color: #f1f1f1;
}

/* Center the avatar image inside this container */
.imgcontainer {
  text-align: center;
  margin: 24px 0 12px 0;
}

/* Avatar image */
img.avatar {
  width: 40%;
  border-radius: 50%;
}

/* Add padding to containers */
.container {
  padding: 16px;
}

/* The "Forgot password" text */
span.psw {
  float: right;
  padding-top: 16px;
}

/* Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
  span.psw {
    display: block;
    float: none;
  }
  .cancelbtn {
    width: 100%;
  }
}
  :root {
  --ion-color-secondary: #006600;
  --ion-color-secondary-rgb: 0, 102, 0;
  --ion-color-secondary-contrast: #ffffff;
  --ion-color-secondary-contrast-rgb: 255, 255, 255;
  --ion-color-secondary-shade: #005a00;
  --ion-color-secondary-tint: #1a751a;
}
form{}
h1{
    color:black;
    margin-left: 2em;
}
p{
    color:#f2f2f2;
}
ion-menu.md ion-item.selected {
  --background: rgba(var(--ion-color-primary-rgb),  0, 0, 0);
}
  #container {
    text-align: center;
    position: absolute;
    left: 0;
    right: 0;
    top: 50%;
    transform: translateY(-50%);
  }
  
  #container strong {
    font-size: 20px;
    line-height: 26px;
  }
  
  #container p {
    font-size: 16px;
    line-height: 22px;
    color: #f2f2f2;
    margin: 0;
  }
  
  #container a {
    text-decoration: none;
  }
  </style>
  