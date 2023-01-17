<template>
  <div class="profil">
    <div>Date : {{Date}}</div>
    <div>Livraison : {{Livraisons.Nom}}</div>
    <br>
  </div>

  </template>
  <script lang="ts">
  import { Options, Vue } from 'vue-class-component';

  @Options({
    props: {
    }
  })
  export default class CommandListe extends Vue {
    Date: string = "TEST";
    Livraisons!:{
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