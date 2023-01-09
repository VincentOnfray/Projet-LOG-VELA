<template>
  <nav class="bar">
    <ol>
      <li class="menu">
        <input class="bouton" type="button" value=" " />
        <!--<router-link to="/">Home</router-link> |
        <router-link to="/about">About</router-link>-->
      </li>
      <li class="pop">
        <router-link to="/">Les plus populaires</router-link>
        <!--<a href="#">(les plus populaires)</a>-->
      </li>
      <li class="av">
        <router-link to="/">Les plus avantageux</router-link>
        <!--<a href="#">(les plus avantageux)</a>-->
      </li>
      <li class="recherche">
        <form action="" class="formulaire">
          <input class="champ" type="text" placeholder="Chercher..."/>
          <input class="bouton" type="button" value=" " />
        </form>
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
  background-color: brown;
  overflow: hidden;
  border: 2px solid black;
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
}
.av {
  margin: 0;
}
.recherche {
  margin: 40px 0 0 0;
}
.recherche .bouton {
  background-image: url(../ressources/Loupe.png);
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
