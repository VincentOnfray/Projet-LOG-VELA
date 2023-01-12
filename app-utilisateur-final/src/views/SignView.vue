<template>
  <div class="SignIn">
    <h3>Veuillez remplir le formulaire</h3>
    <sign-in></sign-in>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import SignIn from '@/components/auth/SignIn.vue'; // @ is an alias to /src

@Options({
  components: {
    SignIn,
  },
})
export default class SignView extends Vue {}
</script>