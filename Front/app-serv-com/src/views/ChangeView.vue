<template>
  <nav-bar></nav-bar>
  <body>
    <change-user></change-user>
  </body>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import ChangeUser from '@/components/auth/ChangeUser.vue'; // @ is an alias to /src
import NavBar from '@/components/tools/NavBar.vue'; 

@Options({
  components: {
    ChangeUser,
    NavBar
  },
})
export default class LogView extends Vue {}
</script>