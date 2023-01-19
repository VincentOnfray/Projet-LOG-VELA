<template>
  <div class="menu">
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

export default class MenuCard extends Vue {
  Prix!: string;
  Name!: string;
  Desc!: string;
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.menu{
    border: 2px solid black ;
  }
</style>
