<template>
  <nav-bar></nav-bar>
  <body class="SignIn">
    <h3>Veuillez remplir le formulaire</h3>
    <sign-in></sign-in>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import SignIn from '@/components/auth/SignIn.vue'; // @ is an alias to /src
import NavBar from '@/components//tools/NavBar.vue'; 

@Options({
  components: {
    SignIn,
    NavBar
  },
})
export default class SignView extends Vue {}
</script>