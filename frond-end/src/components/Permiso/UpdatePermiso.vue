<template>
  <div class="about">
    <h1>Modificar Permiso </h1>

  <b-container>
    <b-container fluid>
      
<div>
  <form v-on:submit.prevent="savePermiso()">
  <b-card bg-variant="light">
    <b-form-group
      label-cols-lg="3"
      label=""
      label-size="lg"
      label-class="font-weight-bold pt-0"
      class="mb-0"
    >
      <b-form-group
        label-cols-sm="3"
        label="Nombre:"
        label-align-sm="right"
        label-for="nested-nombre"
      >
        <b-form-input v-model="itemsForm.nombre" id="nested-street">
        </b-form-input>
      </b-form-group>

      <b-form-group
        label-cols-sm="3"
        label="Apellidos:"
        label-align-sm="right"
        label-for="nested-apellido"
      >
        <b-form-input v-model="itemsForm.apellido"></b-form-input>
      </b-form-group>
            <b-form-group
        label-cols-sm="3"
        label="Fecha Permiso:"
        label-align-sm="right"
        label-for="nested-fecha"
      >
        <b-form-datepicker v-model="itemsForm.fecha" class="mb-2">

        </b-form-datepicker>
      </b-form-group>

      <b-form-group
        label-cols-sm="3"
        label="Tipo Permiso:"
        label-align-sm="right"
        label-for="tipo-permiso"
      >
      <b-form-select v-model="itemsForm.tipopermiso" :options="optTipoPermiso">
        
      </b-form-select>
      </b-form-group>

    </b-form-group>
  </b-card>
              <b-button type="submit" variant="info">Guardar </b-button>
  </form>
</div>
    </b-container>
  </b-container>
  </div>
</template>

<script src="./UpdatePermiso.vue.js">

</script>
