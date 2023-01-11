<template>
  <NavBar></NavBar>
  <h>HOME</h>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import NavBar from '../tools/NavBar.vue'; 

@Options({
  components: {
    NavBar,
  },
})
export default class Home extends Vue {
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
