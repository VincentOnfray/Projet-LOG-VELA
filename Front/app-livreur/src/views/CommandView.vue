<template>  
  <nav-bar></nav-bar>
  <body>
    <div>Liste de livraisons :</div>
    <command-list></command-list>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import NavBar from '@/components/tools/NavBar.vue'; 
import CommandList from '@/components/articles/CommandList.vue'; // @ is an alias to /src
import CommandActual from '@/components/articles/CommandActual.vue'; // @ is an alias to /src


@Options({
  components: {
    NavBar,
    CommandList,
    CommandActual
  },
})
export default class CommandView extends Vue {
}
</script>
