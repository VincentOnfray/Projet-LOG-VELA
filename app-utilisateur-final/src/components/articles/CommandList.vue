<template>
  <div v-for="item in Commands">
    <command-actual></command-actual>
  </div>

</template>
<script lang="ts">
  import { Options, Vue } from 'vue-class-component';
  import CommandActual from './CommandActual.vue';

  @Options({
    CommandActual
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