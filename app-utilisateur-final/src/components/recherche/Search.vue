<template>
  <label>Recherche parmi :</label>
  <br>
  <br>
  <label for="entreprise">Entreprise</label>
  <input type="checkbox" id="entreprise" class="Entreprise" v-model="Restaurateur">
  <label for="menu">Menu</label>
  <input type="checkbox" id="menu" class="Menu" v-model="Menu">
  <label for="plat">Plat</label>
  <input type="checkbox" id="plat" class="Plat" v-model="Plat">
  <br>
  <br>
  <div class="recherche">
    <input class="champ" type="text" placeholder="Chercher..."/>
    <button><img src="../../ressources/Loupe.png"></button>
  </div>
  <br>
  <br>
  <ul id="result">
    <li v-show="Restaurateur" v-for="item in restaurants">
      <Result></Result>
    </li>
    <li v-show="Menu" v-for="item in menus">
      <Result></Result>
    </li>
    <li v-show="Plat" v-for="item in plats">
      <Result></Result>
    </li>
  </ul>
  
</template>

<script lang="ts">
  import { Options, Vue } from 'vue-class-component'; // @ is an alias to /src
  import Result from '@/components/recherche/Result.vue'; // @ is an alias to /src

  @Options({
  components: {
    Result
  },
})

  export default class Search extends Vue {
    restaurants!: {
      
    };
    menus!: {
      
    };
    plats!: {
      
    };

    Restaurateur!: boolean;
    Menu!: boolean;
    Plat!: boolean; 
  }    
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
   /* Bordered form */
   .Entreprise {
    margin: 0 50px 0 0;
   }
   .Menu {
    margin: 0 50px 0 0;
   }
   .Plat {
    margin: 0 50px 0 0;
   }
   .recherche {
    Height: 40px;
   }
  .recherche input {
    width:90%
  }
  img{
    width:1em;
  }
</style>