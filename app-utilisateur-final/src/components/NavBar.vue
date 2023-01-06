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
    msg: String
  }
})
export default class HelloWorld extends Vue {
  msg!: string
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
