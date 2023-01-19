<template>
  <div>Commande en cours :</div>
  <command-actual></command-actual>

  <div>Liste de commandes :</div>
  <div v-for="item in Commands">
    <command-liste></command-liste>
  </div>

</template>
<script lang="ts">
  import { Options, Vue } from 'vue-class-component';
  import CommandListe from './CommandListe.vue';
  import CommandActual from '@/components/articles/CommandActual.vue'; // @ is an alias to /src

  @Options({
    CommandListe,
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