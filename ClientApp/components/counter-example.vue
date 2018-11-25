<template>
  <div>
  
  <h1></h1>
  <h2>Entrer la date de réservation</h2>
 <div class="input-group input-group-lg">
  <div class="input-group-prepend">
    <span class="input-group-text" id="inputGroup-sizing-lg">jj/mm/aa</span>
  </div>
  <input :value="datereservation" type="text" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg">
</div>
<h2>Entrer l'heure du début de la réunion</h2>
<div class="input-group input-group-lg">
  <div class="input-group-prepend">
    <span class="input-group-text" id="inputGroup-sizing-lg">h:min</span>
  </div>
  <input type="text" :value="heuredebutreservation" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg">
</div>
<h2>Entrer l'heure de la fin de la réunion</h2>
<div class="input-group input-group-lg">
  <div class="input-group-prepend">
    <span class="input-group-text" id="inputGroup-sizing-lg">h:min</span>
  </div>
  <input type="text" :value="heurefinreservation" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg">
</div>
  
  
  <h1>liste des salles disponibles</h1>
  <h1 class="glyphicon glyphicon-search"></h1>
    <table class="table table-dark">
  <thead>
    <tr>
      <th scope="col">num de la salle</th>
      <th scope="col">Etage</th>
      <th scope="col">Nombre de place</th>
      <th scope="col">Nombre d'ordinateurs</th>
	   <th scope="col">Data show</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">1</th>
      <td>3</td>
      <td>10</td>
      <td>2</td>
	  <td>false</td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td>7</td>
      <td>20</td>
      <td>5</td>
	  <td>true</td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td>5</td>
      <td>15</td>
      <td>1</td>
	  <td>false</td>
    </tr>
	<tr>
      <th scope="row">4</th>
      <td>5</td>
      <td>19</td>
      <td>1</td>
	  <td>true</td>
    </tr>
	<tr>
      <th scope="row">5</th>
      <td>2</td>
      <td>25</td>
      <td>1</td>
	  <td>true</td>
    </tr>
	<tr>
      <th scope="row">6</th>
      <td>1</td>
      <td>30</td>
      <td>3</td>
	  <td>true</td>
    </tr>
  </tbody>
</table>


  </div>
</template>




<script>
export default {
    data() {
        return {
		datereservation:"",
		heuredebutreservation:"",
		heurefinreservation:"",
        }
    },
}




</script>



<style>
</style>