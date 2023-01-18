<template>
  <div class="plat">
    <div>{{Name}}</div>
    <img src="../../ressources/Utilisateur.jpg"/>
    <div>{{Desc}}</div>
    <div>{{Prix}}</div>
    <br>
    <button>Ajouter</button>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';

@Options({
  components: {
  },
})

export default class DishCard extends Vue {
  Name!: string;
  Desc!: string;
  Prix!: string;
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .plat{
    border: 2px solid black ;
  }
  img {
    width: 10em;
  }
</style>
