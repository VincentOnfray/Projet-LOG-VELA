<template>  
  <nav-bar></nav-bar>
  <body>
    <home-menu v-if="Home === 0"></home-menu>
    <home-pop v-else-if="Home === 1"></home-pop>
    <home-advantage v-else-if="Home === 2"></home-advantage>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import NavBar from '@/components//tools/NavBar.vue'; 
import HomeMenu from '@/components/home/HomeMenu.vue'; // @ is an alias to /src
import HomePop from '@/components/home/HomePop.vue'; // @ is an alias to /src
import HomeAdvantage from '@/components/home/HomeAdvantage.vue'; // @ is an alias to /src

@Options({
  components: {
    NavBar,
    HomeMenu,
    HomePop,
    HomeAdvantage
  },
})
export default class HomeView extends Vue {
  Home: number = 0;
}
</script>
