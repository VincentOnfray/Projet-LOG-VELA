<template>
    <ion-page>
      <ion-header :translucent="true">
        <ion-toolbar>
          <ion-buttons slot="start">
            <ion-menu-button color="secondary"></ion-menu-button>
          </ion-buttons>
          <h1>Bienvenue sur votre profil </h1> 
          <ion-title>{{ $route.params.id }}</ion-title>
        </ion-toolbar>
      </ion-header>
  
      <ion-content :fullscreen="true">
        <ion-header collapse="condense">
          <ion-toolbar>
            <ion-title size="large">{{ $route.params.id }}</ion-title>
          </ion-toolbar>
        </ion-header>
        <h2>Consultation de mes articles    <a href="/Folder/Restaurant/Article/Ajout">Ajouter un article</a></h2>
        <!DOCTYPE html>
            <html>
            <meta name="viewport" content="width=device-width, initial-scale=1">
            <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
            <link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-blue-grey.css">
            <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
            <body class="w3-theme-l4">

            <div style="min-width:400px">




            <div class="w3-container w3-content">
            <div class="w3-panel w3-white w3-card w3-display-container">
                <span class="w3-display-topright w3-padding w3-hover-red">X</span>
            <p class="w3-text-blue"><b>Poisson pané</b></p>
            </div>
            
            <div class="w3-panel w3-white w3-card w3-display-container">
            <span class="w3-display-topright w3-padding w3-hover-red">X</span>
            <p class="w3-text-blue"><b>Hamburger</b></p>
            </div>
            
            <div class="w3-panel w3-white w3-card w3-display-container">
            <span class="w3-display-topright w3-padding w3-hover-red">X</span>
            <p class="w3-text-blue"><b>Plat du jour</b></p>
            </div>
            </div>

</div>

</body>
</html>
            <a href="/Folder/Restaurant/" >Modification</a>
      </ion-content>
    </ion-page>
</template>
<style scoped>
h2{
    margin-left:1em;

}
</style>
