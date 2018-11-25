<template>
  <div>
  
  
  
  
<h2>Entrez le num de la salle</h2>
<div class="input-group input-group-lg">
  <span class="input-group-addon glyphicon glyphicon-pencil" id="sizing-addon1"></span>
  <input type="text" :value="numsalle" class="form-control" placeholder="num de la salle" aria-describedby="sizing-addon1">
</div>
<h1></h1>
<button @click="reserver" type="button" class="btn btn-default btn-lg">
  <span class="glyphicon glyphicon-ok" aria-hidden="true"></span> Réserver
</button>
<h1></h1>
<button @click="annuler" type="button" class="btn btn-default btn-lg">
  <span class="glyphicon glyphicon-ok" aria-hidden="true"></span> Annuler
</button>

  </div>
</template>




<script>
export default {
    data() {
        return {
		numsalle:"",
        }
    },
	methods:{
	reserver: function(){
	//ici le traitement
	},
	annuler: function(){
	//ici le traitement
	}
},
}



</script>



<style>
</style>