<template>
  <ol class="properties">
    <li>{{Commande.Nom}}</li>
    <li>{{Commande.Origine}}</li>
    <li>{{Commande.Destination}}</li>
    <button type="submit">Accepter la commande</button>
    <button type="submit" class="cancelbtn">Refuser la commande</button>
  </ol>  
</template>

<script lang="ts">
  import { Options, Vue } from 'vue-class-component'; // @ is an alias to /src

  export default class HomeProp extends Vue {  
    Commande!:{
      Nom: string;
    Destination: string;
    Origine: string;
    }
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
  background-color: red;
}
  </style>