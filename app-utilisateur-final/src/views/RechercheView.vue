<template>
  <nav-bar></nav-bar>
  <body class="Recherche">
    <search-bar></search-bar>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import SearchBar from '@/components/search/SearchBar.vue'; // @ is an alias to /src
import NavBar from '@/components//tools/NavBar.vue'; 

@Options({
  components: {
    SearchBar,
    NavBar
  },
})
export default class RechercheView extends Vue {}
</script>