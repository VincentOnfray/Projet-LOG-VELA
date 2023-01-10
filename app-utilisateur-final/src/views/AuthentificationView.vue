<template>
  <div class="LogIn">
    <LogMe></LogMe>
  </div>
  <div class="SignIn">
    <h3>Vous n'avez pas de compte ?</h3>
    <router-link to="/signin"> ====> Inscrivez-vous !!!</router-link>
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