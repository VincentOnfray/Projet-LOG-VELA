<template>  
  <nav class="bar"> 
    <ol>
      <li class="home">
        <router-link to="/">
          <img class="logo" src="../../ressources/CESIEATS.png"/>
        </router-link>    
      </li>
      <!--<div class="menu">
        <button><img src="../../ressources/Menu.png"></button>
      </div>-->
      <li class="pop">
        <router-link to="/" style="color:white">Les plus populaires</router-link>
      </li>
      <li class="av">
        <router-link to="/" style="color:white">Les plus avantageux</router-link>
      </li>
      <li class="recherche">
        <input class="champ" type="text" placeholder="Chercher..."/>
        <button class="loupe"><img src="../../ressources/Loupe.png"></button>
      </li>
      <li class="user" v-if="connect === true">
        <button><img src="../../ressources/Utilisateur.jpg"></button>
      </li>
      <li class="con" v-else>
        <button @click="routeConnect">Connexion</button>
      </li>
    </ol>    
    
  </nav>
</template>

<script lang="ts">
import router from '@/router';
import { Options, Vue } from 'vue-class-component';
import { RouterLink } from 'vue-router';

@Options({
  
})
export default class NavBar extends Vue {
  connect!: boolean;
  routeConnect: ((payload: MouseEvent) => void) | undefined;
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.bar {
  display: grid;
  background-color: #04AA6D;  
  grid-template-columns: repeat(5, 1fr);
}
li {
  display: inline-block;
  background-color: #04AA6D;  
  margin: 0 50% 0 0;
}
.home {
  grid-row: 1;
}
.logo{
  width:10em;
  float:left;
  margin-top: 0;
}
.pop {
  grid-row: 2;
}
.av{
  grid-row: 3;
}
.recherche {
  /*margin: 0 40px 0 40px;*/
  grid-row: 4;
}
.recherche .loupe img{
  height: 1.4em;
  width: 1.4em;
}
.champ{
  font-size: 1em;
}
.user {
  grid-row: 5;
  margin: 0 40px 0 0;
}
.con {
  grid-row: 5;
  margin: 0 40px 0 0;
}
</style>
