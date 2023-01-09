<template>
    <nav class="bar">
        <h3> Welcome to my authentification</h3>
    </nav>
  </template>

  <script lang="ts">
  import { Options, Vue } from 'vue-class-component';

  @Options({
    props: {
    }
  })
  export default class LogMe extends Vue {
  }
  </script>

  <!-- Add "scoped" attribute to limit CSS to this component only -->
  <style scoped>
  .bar {
    display: inline-block;
    margin: 0;
  }
  .menu {
    margin: 40px 0 0 0;
    background-image: url(../ressources/Menu.png);
  }
  .trier {
    display: inline-block;
    margin: 0;
  }
  .recherche {
    margin: 40px 0 0 0;
    background-image: url(../ressources/Menu.png);
  }
  .user {
    margin: 40px 0 0 0;
    background-image: url(../ressources/Menu.png);
  }
  li {
    display: inline-block;
    margin: 0 10px;
  }
  a {
    color: #42b983;
  }
  </style>