<template>
  <nav>
    <NavBar></NavBar>
  </nav>
  <router-view></router-view>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import NavBar from '@/components/NavBar.vue'; // @ is an alias to /src

<<<<<<< HEAD

Options({
=======
@Options({
  name: 'App',
>>>>>>> abb52a6f94f5de2dbadf72391fbe1071c1ad3f8d
  components: {
    NavBar,
  },
})

export default class App extends Vue {}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

nav {
  padding: 30px;
}

nav a {
  font-weight: bold;
  color: #2c3e50;
}

nav a.router-link-exact-active {
  color: #42b983;
}
</style>
