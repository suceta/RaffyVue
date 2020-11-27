import axios from 'axios';

export default {
    name: 'CreatePermiso',
    data() {
        return {
            itemsForm: {
                id: 0,
                nombre: '',
                apellido: '',
                tipopermiso: 0,
                fecha: ''
            },
            itemsFormOriginal: null,
            optTipoPermiso: [],
            idPermiso: 0
        };
    },
    mounted() {
        console.log(this.$route.params.id, "route");
        this.idPermiso = this.$route.params.id;
        this.getTipoPermiso();
        this.getPermiso();

    },
    methods: {
        getTipoPermiso() {
            axios.get('http://localhost:8080/Api/TipoPermiso', {
                    header: {
                        'Access-Control-Allow-Origin': '*'
                    }
                })
                .then(
                    function(response) {
                        let dt = response.data;
                        dt.forEach((item, index) => {
                            this.optTipoPermiso.push({
                                value: item.id,
                                text: item.descripcion
                            });

                            console.log(index);
                        });


                    }.bind(this)
                )

            .catch(function(error) {
                console.log(error);
            });
        },
        getPermiso() {
            axios.get('http://localhost:8080/Api/Permiso/' + this.idPermiso, {

                    id: this.idPermiso

                })
                .then(
                    function(response) {
                        let dt = response.data;

                        this.itemsForm.id = dt.id;
                        this.itemsForm.nombre = dt.nombreEmpleado;
                        this.itemsForm.apellido = dt.apellidosEmpleado;
                        this.itemsForm.tipopermiso = dt.tipoPermiso;
                        this.itemsForm.fecha = dt.fechaPermiso;

                        this.itemsFormOriginal = this.itemsForm;
                        console.log(this.itemsFormOriginal);

                    }.bind(this)
                )

            .catch(function(error) {
                console.log(error, "err");
            });
        },
        savePermiso() {
            //console.log(this.itemsForm.nombre);
            //var router = this.$router;
            let permiso = {
                Id: this.itemsForm.id,
                NombreEmpleado: this.itemsForm.nombre,
                ApellidosEmpleado: this.itemsForm.apellido,
                TipoPermiso: this.itemsForm.tipopermiso,
                FechaPermiso: this.itemsForm.fecha,
            };

            axios.put('http://localhost:8080/Api/Permiso/' + this.idPermiso,

                    {
                        permisodto: JSON.stringify(permiso)
                    }

                )
                .then((response) => {
                    //router.push('/articulos');
                    console.log(response.data);

                    this.clearForm();
                    this.getTipoPermiso();
                    this.getPermiso();
                })
                .catch(function(error) {
                    console.log(error);
                });

        },
        clearForm() {
            this.itemsForm.apellido = '';
            this.itemsForm.tipopermiso = '';
            this.itemsForm.fecha = '';
            this.itemsForm.nombre = '';

        }


    }
}