import axios from 'axios';

export default {
    name: 'CreatePermiso',
    data() {
        return {
            itemsForm: {
                nombre: '',
                apellido: '',
                tipopermiso: 0,
                fecha: ''
            },
            optTipoPermiso: [],
            selected: []
        };
    },
    mounted() {

        this.getTipoPermiso();
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
        savePermiso() {
            //console.log(this.itemsForm.nombre);
            //var router = this.$router;
            let permiso = {
                NombreEmpleado: this.itemsForm.nombre,
                ApellidosEmpleado: this.itemsForm.apellido,
                TipoPermiso: this.itemsForm.tipopermiso,
                FechaPermiso: this.itemsForm.fecha,
            };
            //let datos = JSON.parse(permiso);
            //permiso: JSON.stringify(permiso)
            JSON.stringify(permiso);
            axios.post('http://localhost:8080/Api/Permiso', {
                    PermisoDTO: JSON.parse(permiso)

                })
                .then((response) => {
                    //router.push('/articulos');
                    console.log(response);
                    this.clearForm();
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