<template>
  <div class="profil">
    <img src="../../ressources/Utilisateur.jpg"/>
    <div>Nom d'utilisateur : {{Name}}</div>
    <div>Adresse email : {{Email}}</div>
    <router-link to="/change" style="color:black" class="pop">Modifier</router-link>    
    <br>
    <br>
    <div>Lien de parrainage : /MonParrainage/</div>
    <br>
  </div>

  </template>
 <script lang="ts">
 import {
   defineComponent,
   ref,
 } from 'vue';
 import ExploreContainer  from '@/components/ExploreContainer.vue';
 export default defineComponent({
   setup(){
     const Name = localStorage.getItem('name');
     const Email = localStorage.getItem('email'); 
 
     return {
       Name,
       Email
     }
   },
 })
 </script>

  <!-- Add "scoped" attribute to limit CSS to this component only -->
  <style scoped>
  .profil{
    border: 2px dotted black ;
  }
  img {
    width: 10em;
  }
  </style>