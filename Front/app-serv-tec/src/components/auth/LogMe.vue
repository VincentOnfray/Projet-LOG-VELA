<template>
    <nav class="bar">
        <h1> Me connecter</h1>
    </nav>
  <form @submit.prevent="submitForm">
    <label>
      Email:
      <input v-model="email" type="email" required>
    </label>
    <br>
    <label>
      Mot de passe:
      <input v-model="password" type="password" required>
    </label>
    <br>
    <button type="submit">Se connecter</button>
  </form>
</template>

<script lang="ts">
import axios from 'axios';

export default {
  data() {
    return {
      email: '',
      password: '',
    };
  },
  methods: {
    async submitForm() {
      try {
        const response = await axios.post('/api/login', {
          email: this.email,
          password: this.password,
        });
        // traiter la réponse
      } catch (error) {
        // gérer l'erreur
      }
    },
  },
};
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
  /* Bordered form */
form {
  border: 3px solid #f1f1f1;
}

/* Full-width inputs */
input[type=text], input[type=password] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}

/* Set a style for all buttons */
button {
  background-color: #04AA6D;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
}

/* Add a hover effect for buttons */
button:hover {
  opacity: 0.8;
}

/* Extra style for the cancel button (red) */
.cancelbtn {
  width: auto;
  padding: 10px 18px;
  background-color: #f1f1f1;
}

/* Center the avatar image inside this container */
.imgcontainer {
  text-align: center;
  margin: 24px 0 12px 0;
}

/* Avatar image */
img.avatar {
  width: 40%;
  border-radius: 50%;
}

/* Add padding to containers */
.container {
  padding: 16px;
}

/* The "Forgot password" text */
span.psw {
  float: right;
  padding-top: 16px;
}

/* Change styles for span and cancel button on extra small screens */
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