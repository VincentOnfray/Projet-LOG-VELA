<template>
  <div class="menu">
    <div>Menu</div>
    <br>
    <div>Entrée</div>
    <div>**</div>
    <div>Plat</div>
    <div>**</div>
    <div>Dessert</div>
    <br>
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

export default class MenuCard extends Vue {
  Prix!: string;
  art1!: string;
  art2!: string;
  art3!: string;
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.menu{
    border: 2px solid black ;
  }
</style>
