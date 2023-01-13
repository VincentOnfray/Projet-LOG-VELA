<template>  
  <nav class="bar"> 
    <router-link to="/" class="home">
      <img class="logo" src="../../ressources/CESIEATS.png"/>
    </router-link>    
    <!--
    <button class="menu"><img src="../../ressources/Menu.png"></button>
    -->
    <router-link to="/" style="color:white" class="pop">Les plus populaires</router-link>
    <router-link to="/" style="color:white" class="av">Les plus avantageux</router-link>
    <input class="recherche" id="champ" type="text" placeholder="Chercher..."/>
    <button class="rechercheImage" id="loupe"><img src="../../ressources/Loupe.png"></button>
    <router-link to="/user" class="user" v-if="connect === true"><img src="../../ressources/Utilisateur.jpg"></router-link>
    <router-link to="/login" style="color:white" class="con" v-else>Connexion</router-link>
    
  </nav>
</template>

<script lang="ts">
import router from '@/router';
import { Options, Vue } from 'vue-class-component';
import { RouterLink } from 'vue-router';

@Options({
  
})
export default class NavBar extends Vue {
  connect: boolean = true;
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.bar {
  background-color: #04AA6D;
}
.logo{
  width:5em;
  float:inline-start;  
  margin-left: -30px;
  margin-top: -30px;
}
.pop{
  margin-right: 20px;
}
.av{
  margin-right: 20px;
}
.recherche {
  margin: 0 0 0 20px;
  font-size: 1em;
}
.rechercheImage {
  margin-right: 20px;
}
.rechercheImage img {
  height: 1.3em;
  width: 1.3em;
}
.user {
  float:inline-end;  
  margin-inline-end: 0%;
}
.user img{
  width: 2em;
}
.con {
  float:inline-end;  
  margin-inline-end: 0%;
}
</style>
