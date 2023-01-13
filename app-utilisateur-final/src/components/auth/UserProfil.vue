<template>
  <div class="profil">
    <img src="../../ressources/Utilisateur.jpg"/>
    <div>Nom d'utilisateur : {{Name}}</div>
    <div>Adresse email : {{Email}}</div>
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