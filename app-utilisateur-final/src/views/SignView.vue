<template>
  <div class="LogIn">
    <h3>Bienvenue sur l'écran de connexion de test</h3>
    <LogMe></LogMe>
  </div>
  <div class="SignIn">
    <h3>Bienvenue sur l'écran de connexion de test</h3>
    <LogMe></LogMe>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import LogMe from '@/components/LogMe.vue'; // @ is an alias to /src

@Options({
  components: {
    LogMe,
  },
})
export default class AuthentificationView extends Vue {}
</script>