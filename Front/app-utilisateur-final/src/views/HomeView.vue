<template>  
  <nav-bar></nav-bar>
  <body>
    <home-pop v-if="$route.params.etat === '1'"></home-pop>
    <home-advantage v-else-if="$route.params.etat === '2'"></home-advantage>
    <home-menu v-else></home-menu>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import NavBar from '@/components//tools/NavBar.vue'; 
import HomeMenu from '@/components/home/HomeMenu.vue'; // @ is an alias to /src
/*import HomePop from '@/components/home/HomePop.vue'; // @ is an alias to /src
import HomeAdvantage from '@/components/home/HomeAdvantage.vue';*/ // @ is an alias to /src


@Options({
  components: {
    NavBar,
    HomeMenu
  },
})
export default class HomeView extends Vue {}
</script>
