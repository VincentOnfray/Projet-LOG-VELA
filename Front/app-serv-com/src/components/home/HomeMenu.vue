<template>
  <div class="menu">
    <p>Nouveautés :</p>
    <div class="newOne">
      <home-prop></home-prop>
    </div>
    <div class="newTwo">
      <home-prop></home-prop>
    </div>
    <div class="newThree">
      <home-prop></home-prop>
    </div>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import HomeProp from '@/components/home/HomeProp.vue';

@Options({
  components: {
    HomeProp
  },
})

export default class HomeMenu extends Vue {
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.menu {
  display: grid;
  grid-template-rows: 20px, 1fr;
  grid-template-columns: repeat(3, 1fr);
  grid-gap: 10px;
}
.newOne {
  grid-column: 1;
}
.newTwo {
  grid-column: 2;
}
.newThree {
  grid-column: 3;
}
p {
  grid-row: 1;
  float: left;
  font-size: 35px;
}
</style>
