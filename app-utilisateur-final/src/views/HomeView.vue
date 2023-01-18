<template>  
  <nav-bar></nav-bar>
  <body>
    <home-menu></home-menu>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import NavBar from '@/components//tools/NavBar.vue'; 
import HomeMenu from '@/components/home/HomeMenu.vue'; // @ is an alias to /src


@Options({
  components: {
    NavBar,
    HomeMenu
  },
})
export default class HomeView extends Vue {}
</script>
