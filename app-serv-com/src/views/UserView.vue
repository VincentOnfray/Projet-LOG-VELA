<template>
  <nav-bar></nav-bar>
  <Body class="User">
    <user-profil></user-profil>
  </Body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import UserProfil from '@/components/auth/UserProfil.vue'; // @ is an alias to /src
import NavBar from '@/components//tools/NavBar.vue'; 

@Options({
  components: {
    UserProfil,
    NavBar
  },
})
export default class SignView extends Vue {}
</script>