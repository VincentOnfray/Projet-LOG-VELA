<template>
  <div class="profil">
    <img src="../../ressources/Utilisateur.jpg"/>
    <div>Date : {{Date}}</div>
    <div>Articles commandés : {{Articles.Nom}}</div>
    <br>
  </div>

  </template>
  <script lang="ts">
  import { Options, Vue } from 'vue-class-component';

  @Options({
    props: {
    }
  })
  export default class CommandACtual extends Vue {
    Date: string = "TEST";
    Email: string = "TEST";
    Articles!:{
      Nom: string;
    };
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