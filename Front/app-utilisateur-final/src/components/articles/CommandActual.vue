<template>
  <div class="profil">
    <div>Articles dans le panier : {{Articles.Nom}}</div>
    <br>
  </div>

  </template>
  <script lang="ts">
  import { Options, Vue } from 'vue-class-component';

  @Options({
    props: {
    }
  })
  export default class CommandActual extends Vue {
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