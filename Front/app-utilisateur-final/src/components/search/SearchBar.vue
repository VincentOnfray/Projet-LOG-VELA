<template>
  <div class="resto">
    <div class="map">
      <div v-for="restaurant in restaurants" :key="restaurant.idRestaurant" class="marker">
        <div class="card">
          <div class="card-header">
            {{ restaurant.nom }}
          </div>
          <div class="card-body">
            <p>{{ restaurant.nom }}</p>
            <p>{{ restaurant.idRestaurant }}</p>
          </div>
          <div class="card-footer">
            <button v-on:click="viewRestaurant()">En savoir plus</button>          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import axios from'axios';
import router from '@/router';
import {
  defineComponent,
  ref,
  onMounted
} from 'vue';

export default defineComponent({
  setup(){
    const restaurants = ref<Restaurant[]>([]);
      interface Restaurant {
        idRestaurant: number;
          nom: string;
          etat: string;
        }

        // add more restaurants here
    

    onMounted(async () => {
      // fetch data from an API or generate some sample data
     

      getRestaurant();
     
    });
    const viewRestaurant = () => {
      router.push(({path: '/user', force: true}))

        // implement logic to show details of the restaurant
    }

    const getRestaurant = async () =>{
      try {
            const response = await axios.get('http://localhost:8082/get/getRestaurants',   {
              headers:{
                'authorization': localStorage.getItem('token') }
            });
  
            console.log(response.data[0].nom);
            const restaurants =response.data as Restaurant[]

            console.log(restaurants[0]);
            

            console.log(localStorage.getItem('token'));
            //response.data
            return  response.data;

              } catch (error) {
                console.log(localStorage.getItem('token'));
                
              console.log('pas axios');
             
              }

      
    }
    return {
      restaurants,
      viewRestaurant
      
      
    }
  },
});
</script>

<style scoped>

.marker {
  display:inline-block;
}
.map {
  width:100%;
  height: 400px; /* adjust the height as needed */
  background-color: #f5f5f5; /* set a background color for the map */
}

.card {
  width: 80%; /* make the card take up the full width of the map */
  margin-bottom: 10px; /* add margin between the cards */
  background-color: white; /* set a background color for the card */
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2); /* add a shadow to the card */
  border-radius: 10px; /* add rounded corners to the card */
  padding: 20px; /* add padding to the card */
  margin:2.5em;
}




.card-header {
  font-size: 24px; /* adjust the font size as needed */
  font-weight: bold; /* make the header text bold */
}

.card-body {
  font-size: 18px; /* adjust the font size as needed */
  line-height: 1.5; /* adjust the line height as needed */
}


</style>
