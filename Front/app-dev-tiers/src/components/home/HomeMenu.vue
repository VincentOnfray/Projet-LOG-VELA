<template>
  <div class="menu">
    <ul>
      <li v-for="item in files">
        <RouterLink to="/{{item}}">{{item}}</RouterLink>
      </li>
    </ul>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';

@Options({
  components: {
  }
})

export default class HomeMenu extends Vue {
files!: {
  name: string;
};
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.menu {
  display:inline-block;

}
</style>
