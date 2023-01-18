<template>
  <nav-bar></nav-bar>
  <body>
    <div class="LogIn">
      <log-me></log-me>
    </div>
    <div class="SignIn">
      <h3>Vous n'avez pas de compte ?</h3>
      <router-link to="/signin"> ====> Inscrivez-vous !!!</router-link>
    </div>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import LogMe from '@/components/auth/LogMe.vue'; // @ is an alias to /src
import NavBar from '@/components//tools/NavBar.vue'; 

@Options({
  components: {
    LogMe,
    NavBar
  },
})
export default class LogView extends Vue {}
</script>