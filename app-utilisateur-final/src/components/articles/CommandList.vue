<template>
  <div v-for="item in Commands">
    <command-liste></command-liste>
  </div>

</template>
<script lang="ts">
  import { Options, Vue } from 'vue-class-component';
  import CommandListe from './CommandListe.vue';

  @Options({
    CommandListe
  })
  export default class CommandList extends Vue {
    Commands!: {
      Name: string;
    };
  }
  </script>

  <!-- Add "scoped" attribute to limit CSS to this component only -->
  <style scoped>

  </style>