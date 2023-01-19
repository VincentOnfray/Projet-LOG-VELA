<template>
  <ion-app>
    <ion-split-pane content-id="main-content">
      <ion-menu content-id="main-content" type="overlay">
        <ion-content>
          <ion-list id="inbox-list">
            <ion-list-header>Jean Dupont</ion-list-header>
            <ion-note>Jeandupont@gmail.com</ion-note>
            <br>
            <a href='/Folder/Profil'>Mon profil</a>

            <!-- <ion-menu-toggle auto-hide="false" v-for="(p, i) in appPages" :key="i">
              <ion-item  @click="selectedIndex = i" router-direction="root" :router-link="p.url" lines="none"  class="hydrated" :class="{ selected: selectedIndex === i }">
                <ion-icon slot="start" :ios="p.iosIcon" :md="p.mdIcon"></ion-icon>
                <ion-label>{{ p.title }}</ion-label>
              </ion-item>
            </ion-menu-toggle>-->
          </ion-list> 

          <ion-list id="labels-list">
            <ion-list-header>Mes Restaurants</ion-list-header>

            <ion-item v-for="(restaurant, index) in restaurants" router-direction="root" :router-link="restaurant.url" lines="none" :key="index">
              <ion-item @click="selectedIndex = index" router-direction="root" :router-link="restaurant.url" lines="none"  class="hydrated" :class="{ selected: selectedIndex === index }">
              <ion-icon slot="start" :ios=restaurant.iosIcon :md="restaurant.mdIcon"></ion-icon>
              <ion-label>{{ restaurant.title }}</ion-label>
            </ion-item>
          </ion-item>
          </ion-list>
        </ion-content>
      </ion-menu>
      <ion-router-outlet id="main-content"></ion-router-outlet>
    </ion-split-pane>
  </ion-app>
</template>

<script setup lang="ts">
import {
  IonApp,
  IonContent,
  IonIcon,
  IonItem,
  IonLabel,
  IonList,
  IonListHeader,
  IonMenu,
  IonMenuToggle,
  IonNote,
  IonRouterOutlet,
  IonSplitPane,
} from '@ionic/vue';
import { ref } from 'vue';
/*import{ IonicVueForm } from "ionic-vue-form";*/
import {
  archiveOutline,
  archiveSharp,
  bookmarkOutline,
  bookmarkSharp,
  heartOutline,
  heartSharp,
  mailOutline,
  mailSharp,
  paperPlaneOutline,
  paperPlaneSharp,
  person,
  restaurant,
  trashOutline,
  trashSharp,
  warningOutline,
  warningSharp,
} from 'ionicons/icons';
import{ Component } from '@angular/core'
import { RouterModule } from '@angular/router';
const selectedIndex = ref(0);
/*
RouterModule.forRoot([
    { path: '/folder/Profil', loadComponent: () => import ('.//views/RestaurantPage.vue'
    )},
    { path: '/folder/Restaurant', loadComponent: () => import ('.//views/RestaurantPage.vue'
    ) },
  ]) */
const appPages = [
  {
    title: 'Mon profil',
    url: '/folder/Profil',
    iosIcon: person,
    mdIcon: person,
  },

];
const restaurants =  [ {
    title: 'Octave',
    url: '/folder/Restaurant',
    iosIcon: restaurant,
    mdIcon: restaurant,
  },
];
/* const labels = ['Octave'];*/


const path = window.location.pathname.split('folder/')[1];
if (path !== undefined) {
  selectedIndex.value = appPages.findIndex((page) => page.title.toLowerCase() === path.toLowerCase());
}
</script>

<style scoped>
ion-menu ion-content {
  --background: var(--ion-item-background, var(--ion-background-color, #fff));
}
a{
  color:black;
  margin-left:1em;
}
ion-menu.md ion-content {
  --padding-start: 8px;
  --padding-end: 8px;
  --padding-top: 20px;
  --padding-bottom: 20px;
  color: #0a0a0a;

}

ion-menu.md ion-list {
  padding: 20px 0;
}

ion-menu.md ion-note {
  margin-bottom: 30px;
}

ion-menu.md ion-list-header,
ion-menu.md ion-note {
  padding-left: 10px;
  color: #0a0a0a;

}

ion-menu.md ion-list#inbox-list {
  border-bottom: 1px solid var(--ion-color-step-150, #d7d8da);
}

ion-menu.md ion-list#inbox-list ion-list-header {
  font-size: 22px;
  font-weight: 600;
  color: #0a0a0a;

  min-height: 20px;
}

ion-menu.md ion-list#labels-list ion-list-header {
  font-size: 16px;

  margin-bottom: 18px;

  color: #0a0a0a;
;

  min-height: 26px;
}
ion-menu.md ion-list#appPages ion-menu-toggle {
  font-size: 16px;

  margin-bottom: 18px;
  color: #0a0a0a;
;

  min-height: 26px;
}

ion-menu.md ion-item {
  --padding-start: 10px;
  --padding-end: 10px;
  border-radius: 4px;
  
}

ion-menu.md ion-item.selected {
  --background: rgba(var(--ion-color-primary-rgb),  0, 0, 0);
}

ion-menu.md ion-item.selected ion-icon {
  color: var(--ion-color-primary);
}

ion-menu.md ion-item ion-icon {
  color: #0a0a0a;
}

ion-menu.md ion-item ion-label {
  font-weight: 500;
    color: #0a0a0a;

}

ion-menu.ios ion-content {
  --padding-bottom: 20px;
  color: #0a0a0a;

}

ion-menu.ios ion-list {
  padding: 20px 0 0 0;
  
}

ion-menu.ios ion-note {
  line-height: 24px;
  margin-bottom: 20px;
  
}

ion-menu.ios ion-item {
  --padding-start: 16px;
  --padding-end: 16px;
  --min-height: 50px;
  
}

ion-menu.ios ion-item.selected ion-icon {
  color: var(--ion-color-primary);
}

ion-menu.ios ion-item ion-icon {
  font-size: 24px;
  color: #000000;
}

ion-menu.ios ion-list#labels-list ion-list-header {
  margin-bottom: 8px;
}

ion-menu.ios ion-list-header,
ion-menu.ios ion-note {
  padding-left: 16px;
  padding-right: 16px;
  
}

ion-menu.ios ion-note {
  margin-bottom: 8px;
  color: #0a0a0a;

}

ion-note {
  display: inline-block;
  font-size: 16px;

  color: var(--ion-color-medium-shade);
}

ion-item.selected {
  --color: var(--ion-color-primary);
}
</style>
