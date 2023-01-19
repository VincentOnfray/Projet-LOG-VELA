<template>  
  <nav class="bar"> 
    <router-link to="/" class="home">
      <img class="logo" src="../../ressources/CESIEATS.png"/>
    </router-link>    
    <!--
    <button class="menu"><img src="../../ressources/Menu.png"></button>
    -->
    <router-link to="/command" style="color:white" class="pop">Commandes</router-link>
    <router-link to="/search" class="recherche" style="color:white" id="loupe">Recherche</router-link>
    <router-link to="/user" class="user" v-if="connect === true"><img src="../../ressources/Utilisateur.jpg"></router-link>
    <router-link to="/login" style="color:white" class="con" v-else>Connexion</router-link>
    
  </nav>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import { RouterLink } from 'vue-router';

@Options({
  
})
export default class NavBar extends Vue {
  connect!: boolean;
  inputSearch: string = "";
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.bar {
  background-color: #04AA6D;
}
.logo{
  width:4.5em;
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
}
.rechercheImage img {
  margin-left: 5px;
  height: 1.2em;
  width: 1.2em;
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
