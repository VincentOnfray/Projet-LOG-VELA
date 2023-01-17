<template>
  <div class="menu">
    <div class="newOne">
      <div>Livraison en cours :</div>
      <div>Restaurant : {{AdresseRestau}}</div>
      <div>Livraison : {{AdresseDestination}}</div>
    </div>
    <div class="newTwo" v-for="item in valides">
      <home-prop commande="{{item}}"></home-prop>
    </div>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import HomeProp from '@/components/home/HomeProp.vue';

@Options({
  components: {
    HomeProp
  },
})

export default class HomeMenu extends Vue {
valides!: {
  Nom: string;
  Origine: string;
  Destination:string;
}
  AdresseRestau!: string;
  AdresseDestination!: string;
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.menu {
  display: grid;
  grid-template-rows: 20px, 1fr;
  grid-template-columns: repeat(2, 1fr);
  grid-gap: 20px;
}
.newOne {
  grid-column: 1;
}
.newTwo {
  grid-column: 2;
}
</style>
