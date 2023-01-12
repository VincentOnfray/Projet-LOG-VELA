<template>
  <div class="Recherche">
    <search-bar></search-bar>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import SearchBar from '@/components/search/SearchBar.vue'; // @ is an alias to /src

@Options({
  components: {
    SearchBar
  },
})
export default class RechercheView extends Vue {}
</script>