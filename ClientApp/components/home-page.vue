<template>
<div>

<h1>Veuillez vous connecter pour réserver une salle</h1>
<h3>Entrez votre identifiant</h3>
   <div class="input-group input-group-lg">
  <span class="input-group-addon glyphicon glyphicon-user" id="sizing-addon1"></span>
  <input type="text" :value="iduser" class="form-control" placeholder="Identifiant" aria-describedby="sizing-addon1">
</div>
<h3>Entrez votre adresse mail</h3>
 <div class="input-group input-group-lg">
  <i class="fas fa-at" ></i>
  <input type="text" :value="mailuser" class="form-control" placeholder="xxx@gmail.com" aria-describedby="sizing-addon1">
</div>
<h3>Entrez votre mot de pase</h3>
 <div class="input-group input-group-lg">
  <span class="input-group-addon glyphicon glyphicon-eye-open" id="sizing-addon1"></span>
  <input type="text" :value="mdpuser" class="form-control" placeholder="Mot de passe" aria-describedby="sizing-addon1">
</div>
<h1>  </h1>

<button type="button" @click="connexion" class="btn btn-default btn-lg">
  <span class="glyphicon glyphicon-ok-sign" aria-hidden="true"></span> Connexion
</button>
 </div>


</template>

<script>
export default {
    data() {
        return {
		iduser:"",
		mailuser:"",
		mdpuser:"",
        }
    },
	methods:{
	connexion: function(){
	//ici le traitement
	}
	
	},
}
</script>

<style>
</style>
