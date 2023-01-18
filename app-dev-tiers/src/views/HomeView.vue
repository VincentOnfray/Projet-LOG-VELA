<template>  
  <nav-bar></nav-bar>
  <body>
    <home-menu v-if="$route.params.component === ''"></home-menu>
    <component-visu v-else></component-visu>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import NavBar from '@/components//tools/NavBar.vue'; 
import HomeMenu from '@/components/home/HomeMenu.vue'; // @ is an alias to /src
import ComponentVisu from '@/components/home/ComponentVisu.vue'; // @ is an alias to /src


@Options({
  components: {
    NavBar,
    HomeMenu,
    ComponentVisu
  },
})
export default class HomeView extends Vue {}
</script>
