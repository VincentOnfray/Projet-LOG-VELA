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
  <div v-show="Restaurateur" v-for="item in restaurants">
    <result-menu Nom="{{item.Nom}}" Illustration="{{Img}}" Prix="{{Prix}}" Disponibilite="{{Disponibilite}}"></result-menu>
  </div>
  <div v-show="Menu" v-for="item in menus">
    <result-menu Nom="{{item.Nom}}" Illustration="{{Img}}" Prix="{{Prix}}" Disponibilite="{{Disponibilite}}"></result-menu>
  </div>
  <div v-show="Plat" v-for="item in plats">
    <result-menu Nom="{{item.Nom}}" Illustration="{{Img}}" Prix="{{Prix}}" Disponibilite="{{Disponibilite}}"></result-menu>
  </div>
  <div v-show="!Restaurateur && !Menu && !Plat">
    Aucune données dans lesquelles cherchés.
  </div>
  
</template>

<script lang="ts">
  import { Options, Vue } from 'vue-class-component'; // @ is an alias to /src
  import ResultMenu from '@/components/search/ResultMenu.vue'; // @ is an alias to /src

  @Options({
  components: {
    ResultMenu
  },
})

  export default class Search extends Vue {
    restaurants!: {
      Nom: string;
      Img: string;
      Prix: string;
      Disponibilite: boolean;
    };
    menus!: {
      Nom: string;
      Img: string;
      Prix: string;
      Disponibilite: boolean;      
    };
    plats!: {
      Nom: string;
      Img: string;
      Prix: string;
      Disponibilite: boolean;      
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
    margin: 0 50px 0 5px;
   }
   .Menu {
    margin: 0 50px 0 5px;
   }
   .Plat {
    margin: 0 50px 0 5px;
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