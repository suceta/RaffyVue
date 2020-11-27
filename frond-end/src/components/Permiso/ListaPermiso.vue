<template>

  <div class="about">
    <h1>Lista De Permisos </h1>


  <b-container style="padding-top:80px">
        <b-container fluid>
            <div class="panel-body">
                

                <div >
                    <div class="panel-heading">
                       
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">   
                           <table class="table table-hover fixed table-striped borderless ">
                                <thead>
                                    <tr>  
                                        <th>Nombre </th>
                                        <th >Apellido </th>
                                        <th >Fecha </th>
                                        <th >Accion </th>

                                    </tr>
                               </thead>
                               <tbody v-if="items.length > 0" style="colo:red">
                                   <tr v-for="(item) in items" :key="item.Id"> 
                                       <td> {{ item.nombre }} </td>
                                       <td> {{ item.apellido }} </td>
                                       <td> {{ item.fecha }} </td>
                                       <td> 
                                                <b-button size="sm" variant="info" type="" :to="{name:'UpdatePermiso', params:{id:item.Id}}" >
                                                     <b-icon-pencil-square> &nbsp; </b-icon-pencil-square>
                                                </b-button>
                                                &nbsp;

                                                <b-button  size="sm" variant="danger" type="" :to="{name:'DeletePermiso', params:{id:item.Id}}" >
                                                    <b-icon icon="trash-fill" aria-hidden="true"> </b-icon>
                                                    
                                                </b-button>
                                        </td>

                                       
                                       
                                       
                                       
                                   </tr>

                                </tbody>

                               <tbody v-if="items.length <= 0">
                                    <tr style ="color:red"> 
                                        <!--<td v-if="loader" style ="color:red" colspan="5"> 
                                            Buscando Registros ....
                                        </td>
                                        <td v-elseif colspan="5">
                                            No existen registros...
                                        </td>-->
                                    </tr>
                                </tbody> 
                           </table>
                       </div>
       </div><!-- /col-md-8  -->
                </div>
                </div>
        </b-container>
    </b-container>
  </div>

</template>

<script src="./ListaPermiso.vue.js">

</script>