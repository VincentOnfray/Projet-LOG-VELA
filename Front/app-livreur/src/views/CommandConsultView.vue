<template>  
  <nav-bar></nav-bar>
  <body>
    <div>Livraison :</div>
    <command-actual></command-actual>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import NavBar from '@/components/tools/NavBar.vue'; 
import CommandActual from '@/components/articles/CommandActual.vue'; // @ is an alias to /src


@Options({
  components: {
    NavBar,
    CommandActual
  },
})
export default class CommandView extends Vue {
}
</script>
