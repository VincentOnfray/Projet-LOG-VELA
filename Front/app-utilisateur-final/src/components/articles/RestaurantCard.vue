<template>
  <div class="resto">
    <div class="map">
      <div v-for="restaurant in restaurants" :key="restaurant.id" class="marker">
        {{ restaurant.name }}
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import {
  defineComponent,
  ref,
  onMounted
} from 'vue';

export default defineComponent({
  setup(){
    interface Restaurant {
  id: number;
  name: string;
}
const restaurants = ref<Restaurant[]>([]);
    onMounted(() => {
      // fetch data from an API or generate some sample data
      const data = [
        { id: 1, name: 'Restaurant 1' },
        { id: 2, name: 'Restaurant 2' },
        { id: 3, name: 'Restaurant 3' },
        // add more restaurants here
      ];
      restaurants.value = data;
    });

    return {
      restaurants
    }
  },
});
</script>

<style scoped>
  .map {
    width: 100%;
    height: 100%;
  }

  .marker {
    /* style for the markers on the map */
  }
</style>
