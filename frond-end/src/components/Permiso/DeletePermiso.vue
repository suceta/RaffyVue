<template>
  <b-container>
    <b-container fluid>
        <div v-if="!isDelete">
        <h3> Confirma que desea Eliminar este registro ? </h3>
            <b-form-group >
                
                <b-button @click="deletePermiso()"  type="submit" variant="danger">Eliminar </b-button>
                &nbsp;

                <b-button   variant="outline-secondary" type="" :to="{name:'ListaPermiso'}" >Cancelar
                <b-icon icon="arrow-counterclockwise" aria-hidden="true"> </b-icon> 
                                                    
            </b-button>
            </b-form-group>
            &nbsp;
            

        </div>
        <div v-if="isDelete">
            
        </div>
    </b-container>
  </b-container>
</template>


<script src="./DeletePermiso.vue.js">

</script>