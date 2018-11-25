<template>
<div>
<h1>Liste des demandes de réservation</h1>
<h1></h1>
<table class="table table-striped table-responsive-md btn-table">

  <thead>
    <tr>
      <th>num de réservation</th>
      <th>num de salle</th>
	  <th>Date</th>
      <th>heure début</th>
      <th>heure fin</th>
	  <th></th>
	  <th></th>
    </tr>
  </thead>

  <tbody>
    <tr>
      <th scope="row">1</th>
     
      <td>5</td>
      <td>05/12/2018</td>
	  <td>08:00</td>
	  <td>10:00</td>
	   <td>
        <button @click="valider" type="button" class="btn btn-outline-primary btn-sm m-0">valider</button>
      </td>
	  <td>
        <button  @click="refuser" type="button" class="btn btn-outline-primary btn-sm m-0">refuser</button>
      </td>
    </tr>
    <tr>
      <th scope="row">2</th>
       <td>14</td>
      <td>05/8/2018</td>
	  <td>08:00</td>
	  <td>12:00</td>
	   <td>
        <button  @click="valider" type="button" class="btn btn-outline-primary btn-sm m-0">valider</button>
      </td>
	  <td>
        <button @click="refuser" type="button" class="btn btn-outline-primary btn-sm m-0">refuser</button>
      </td>
    </tr>
    <tr>
      <th scope="row">3</th>
       <td>5</td>
      <td>15/9/2018</td>
	  <td>14:00</td>
	  <td>16:30</td>
	   <td>
        <button  @click="valider" type="button" class="btn btn-outline-primary btn-sm m-0">valider</button>
      </td>
	  <td>
        <button  @click="refuser" type="button" class="btn btn-outline-primary btn-sm m-0">refuser</button>
      </td>
    </tr>
  </tbody>

</table>

</div>
</template>

<script>
export default {
    data() {
        return {
        }
    },
	methods:{
	valider: function(){
	//ici le traitement
	},
	refuser: function(){
	//ici le traitement
	},
},
}



</script>



<style>
</style>