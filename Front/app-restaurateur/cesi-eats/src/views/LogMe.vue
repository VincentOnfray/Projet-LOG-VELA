<template>
  <form @submit.prevent="login">
    <label>
      Email:
      <input v-model="formData.email" type="email" required>
    </label>
    <br>
    <label>
      Mot de passe:
      <input v-model="formData.password" type="password" required>
    </label>
    <br>
    <button type="submit">Se connecter</button>
  </form>
</template>

<script lang="ts">
import router from '@/router';
import axios from 'axios';
import {ref} from 'vue';

export default {
  setup() {
    const formData = ref({
      email:'',
      password:''
    })


    const login = async() : Promise<void> => {
          const email = formData.value.email;
          const password = formData.value.password;
          console.log(email);
          console.log(password);
          axios.get('https://www.google.com', {
            headers: {
              "Access-Control-Allow-Origin": "*",
          "Access-Control-Allow-Methods": "GET, POST, PATCH, PUT, DELETE, OPTIONS",
          "Access-Control-Allow-Headers": "Origin, Content-Type, X-Auth-Token"

          // remove headers
        }})
          
            .then(response => {
              if (response) {
                console.log('Authentification réussie');
                console.log(formData.value.email);
                console.log(formData.value.password);
                //router.push({ path: '/home', force: true });
                router.push('/folder/Profil');
              }
              else {
                console.log(formData.value.email);
                console.log(formData.value.password);
                console.log('Erreur')
              }
            })
            .catch(error => {
              console.log("Erreur d'authentification", error)
              
            })
            
        } 
        return{formData,login}  

} }
</script>