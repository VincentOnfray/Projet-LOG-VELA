<template>
  <div class="container">
    <label for="uname"><b>Nom </b></label>
    <input type="text" placeholder="Entrer votre nom" name="uname" v-model="Name" required>

    <label for="mail"><b>Mail </b></label>
    <input type="text" placeholder="Entrer votre adresse mail" name="mail" v-model="Mail" required>

    <label for="oldpsw"><b>Ancien mot de passe</b></label>
    <input type="password" placeholder="Entrer votre mot de passe" name="oldpsw" v-model="OldPassword" required>

    <label for="psw"><b>Mot de passe</b></label>
    <input type="password" placeholder="Entrer votre mot de passe" name="psw" v-model="Password" required>

    <button v-on:click="valider">Valider</button>
  </div>

  <div class="container" style="background-color:#f1f1f1">
    <button type="button" class="cancelbtn">Cancel</button>
  </div>
  <div><button type="button" class="suprbtn">Suppression du compte</button></div>
</template>

<script lang="ts">
  import { Options, Vue } from 'vue-class-component'; // @ is an alias to /src
  import { RouterLink, Router, loadRouteLocation, useRoute, useLink } from 'vue-router';

  export default class SignIn extends Vue {
    Name!: string
    Password!: string
    OldPassword!: string
    Mail!: string;
  
    valider!: ((payload: MouseEvent) => void) | undefined
  }
  

    
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
   /* Bordered form */
form {
  border: 3px solid #f1f1f1;
}

/* Full-width inputs */
input[type=text], input[type=password] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}

/* Set a style for all buttons */
button {
  background-color: #04AA6D;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
}

/* Add a hover effect for buttons */
button:hover {
  opacity: 0.8;
}

/* Extra style for the cancel button (red) */
.cancelbtn {
  width: auto;
  padding: 10px 18px;
  background-color: #f44336;
}

.suprbtn {
  width: auto;
  padding: 10px 18px;
  background-color: red;
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
.container{
    width: 50em;
    margin : 0 auto;
  }
} 
  </style>