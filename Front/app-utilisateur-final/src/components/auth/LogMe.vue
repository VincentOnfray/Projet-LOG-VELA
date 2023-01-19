<template>
  <div class="login-container">
    <form @submit.prevent="login">
      <div class="form-group">
        <label for="email">Email:</label>
        <input v-model="formData.email" id="email" type="email" required class="form-control">
      </div>
      <div class="form-group">
        <label for="password">Mot de passe:</label>
        <input v-model="formData.password" id="password" type="password" required class="form-control">
      </div>
      <button type="submit" class="btn btn-primary">Se connecter</button>
      <div v-if="errorMessage" class="alert alert-danger" role="alert">
        {{ errorMessage }}
      </div>
    </form>
  </div>
</template>

<script lang="ts">
import axios from 'axios';
import {ref} from 'vue';
import router from '@/router';

export default {
  setup() {
    const formData = ref({
      email:"",
      password:""
    });

    const errorMessage = ref('');

    const login = async() : Promise<void> => {
          const email = formData.value.email;
          const password = formData.value.password;
          console.log(email);
          console.log(password);
          console.log(formData);


          try {
            const response = await axios.post('http://localhost:8082/get/signin',    ({
              email: formData.value.email,
              password: formData.value.password
              }));
            console.log(response.data);
            router.push({path: '/user', force: true});
            localStorage.setItem('token', response.data.accessToken);
            localStorage.setItem('name', response.data.name);
            localStorage.setItem('email', response.data.email);
            console.log(response.data.name);
            
            return  response.data;

              } catch (error) {
              console.log('rr');
              errorMessage.value = 'Email or password is incorrect';
              }


        } 

        return{formData,login,errorMessage}

} }
</script>
<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.container{
  width: 50em;
  margin : 0 auto;
}
.bar {
  display: inline-block;
  margin: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
/* Bordered form /
form {
border: 3px solid #f1f1f1;
}

/ Full-width inputs /
input[type=text], input[type=password] {
width: 100%;
padding: 12px 20px;
margin: 8px 0;
display: inline-block;
border: 1px solid #ccc;
box-sizing: border-box;
}

/ Set a style for all buttons /
button {
background-color: #04AA6D;
color: white;
padding: 14px 20px;
margin: 8px 0;
border: none;
cursor: pointer;
width: 100%;
}

/ Add a hover effect for buttons /
button:hover {
opacity: 0.8;
}

/ Extra style for the cancel button (red) /
.cancelbtn {
width: auto;
padding: 10px 18px;
background-color: #f1f1f1;
}

/ Center the avatar image inside this container /
.imgcontainer {
text-align: center;
margin: 24px 0 12px 0;
}

/ Avatar image /
img.avatar {
width: 40%;
border-radius: 50%;
}

/ Add padding to containers /
.container {
padding: 16px;
}

/ The "Forgot password" text /
span.psw {
float: right;
padding-top: 16px;
}

/ Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
span.psw {
  display: block;
  float: none;
}
.cancelbtn {
  width: 100%;
}
}
</style>