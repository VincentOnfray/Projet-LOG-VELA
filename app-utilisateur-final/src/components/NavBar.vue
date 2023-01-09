<template>
  <nav class="bar">
    <ol>
        <li class="menu">
          <input class="bouton" type="button" value=" " />
        </li>
        <li class="trier">
          <a href="#">(les plus populaires)</a>
        </li>
        <li class="trier">
          <a href="#">(les plus avantageux)</a>
        </li>
        <li class="recherche">
          <form action="" class="formulaire">
            <input class="champ" type="text" value="Chercher..."/>
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
}
.menu {
  margin: 40px 0 0 0;
  background-image: url(../ressources/Menu.png);
}
.trier {
  display: inline-block;
  margin: 0;
}
.recherche {
  margin: 40px 0 0 0;
  background-image: url(../ressources/Menu.png);
}
.user {
  margin: 40px 0 0 0;
  background-image: url(../ressources/Menu.png);
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
