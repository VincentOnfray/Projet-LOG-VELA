<template>
  <div id="app">
    <h1>{{Nom}}</h1>
    <img src="{{Illustration}}">
  </div>
  <div >
    {{Prix}}
  </div>
  <div >
    {{Disponibilite}}
  </div>  
</template>

<script lang="ts">
  import { Options, Vue } from 'vue-class-component'; // @ is an alias to /src
  import { RouterLink, Router, loadRouteLocation, useRoute, useLink } from 'vue-router';

  export default class Result extends Vue {   
    Nom!: string;
    Illustration!: string;
    Prix!: string;
    Disponibilite!: boolean;
  }
  

    
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
   /* Bordered form */

  </style>