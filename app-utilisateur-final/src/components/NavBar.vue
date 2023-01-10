<template>
  
  <nav class="bar">
    <img class="logo" src="../ressources/CESIEATS.png"/>

    <ol>
      <li class="menu">
        <input class="bouton" type="button" value=" " />
        <!--<router-link to="/">Home</router-link> |
        <router-link to="/about">About</router-link>-->
      </li>
      <li class="pop">
        <router-link to="/" style="color:white">Les plus populaires</router-link>
        <!--<a href="#">(les plus populaires)</a>-->
      </li>
      <li class="av">
        <router-link to="/" style="color:white">Les plus avantageux</router-link>
        <!--<a href="#">(les plus avantageux)</a>-->
      </li>
      <li class="recherche">
        <input class="champ" type="text" placeholder="Chercher..."/>
        <!--
<input class="bouton" type="image" value=" " src="../ressources/Loupe.png">-->
        <button><img src="../ressources/Loupe.png"></button>
      </li>
      <li class="user">
        <input class="bouton" type="button" value=" " />
      </li>
    </ol>
  </nav>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';

@Options({
  props: {
  }
})
export default class NavBar extends Vue {
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.bar {
  display: inline-block;
  margin: 0;
  background-color: #04AA6D;
  overflow: hidden;
  border: 2px solid black;
  color:white;
  width:70em;
  
}
.champ{
  height:2em;
  font-size: 1em;
}
.formulaire{
  display:inline-block;
}
.logo{
  width:14em;
  float:left;
  margin-top: 0;
}
.loupe{
  height:2em;
}
.bar ol {
  list-style-type: none;
  padding-left: 0;
}
.bar li {
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size: 17px;
  color:white;
}
.menu {
  margin: 0 0 0 0;
}
.menu input {
  padding: 20 20 20 20;
  background-image: url(../ressources/Menu.png);
}
.pop {
  margin: 0;
  color:white;
}
.av {
  margin: 0;
  color:white;
}
.recherche {
  margin: 40px 0 0 0;
  height:20px;
}
.recherche .loupe {
  float:center;
  height:30px;
}
.user {
  margin: 40px 0 0 0;
}
.user input {
  border-radius:  100% 100%;
  background-image: url(../ressources/Utilisateur.jpg);
}
li {
  display: inline-block;
}
</style>
