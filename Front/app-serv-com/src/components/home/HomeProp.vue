<template>
  <ol class="properties">
    <li>{{Nom}}</li>
    <li><img v-bind:src="Illustration"></li>
    <li>{{Description}}</li>
  </ol>  
</template>

<script lang="ts">
  import { Options, Vue } from 'vue-class-component'; // @ is an alias to /src

  export default class HomeProp extends Vue {  
    Nom: string = "testtttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttt";
    Illustration: string = "../../ressources/CESIEATS.png";
    Description: string = "tttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttttest";
  }    
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
   /* Bordered form */
.properties {
  border-radius: 2px;
  border-color: black;
  border-width: 2px;
}
li{
  display: block;
}
  </style>