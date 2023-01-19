<template>  
  <nav-bar></nav-bar>
  <body>
    <command-list></command-list>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import NavBar from '@/components/tools/NavBar.vue'; 
import CommandList from '@/components/articles/CommandList.vue'; // @ is an alias to /src


@Options({
  components: {
    NavBar,
    CommandList
  },
})
export default class CommandView extends Vue {
}
</script>
