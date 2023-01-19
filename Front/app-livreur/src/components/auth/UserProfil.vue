<template>
  <div class="profil">
    <img src="../../ressources/Utilisateur.jpg"/>
    <div>Nom d'utilisateur : {{Name}}</div>
    <div>Adresse email : {{Email}}</div>
    <router-link to="/change" style="color:black" class="pop">Modifier</router-link>   
    <br>
    <br>
    <div>Lien de parrainage : {{Link}}</div>
    <br>
  </div>

  </template>
  <script lang="ts">
  import { Options, Vue } from 'vue-class-component';

  @Options({
    props: {
    }
  })
  export default class LogMe extends Vue {
    Name: string = "TEST";
    Email: string = "TEST";
    Link: string = "http://www.test/cesi.fr";
  }
  </script>

  <!-- Add "scoped" attribute to limit CSS to this component only -->
  <style scoped>
  .profil{
    border: 2px dotted black ;
  }
  img {
    width: 10em;
  }
  </style>