<template>
  <div class="LogMe">
    <LogMe></LogMe>
    <h3>Bienvenue sur l'écran de connexion de test</h3>
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