<template>
  <div class="plat">
    <div>{{Name}}</div>
    <img src="../../ressources/Utilisateur.jpg"/>
    <div v-for="item in articles">{{item}}</div>
    <div>{{Prix}}</div>
    <br>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';

@Options({
  components: {
  },
})

export default class CommandCard extends Vue {
  Name!: string;
  articles!: {
    Name: string;
  };
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
