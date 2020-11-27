import axios from 'axios';

export default {
    name: 'ListaPermiso',
    data() {
        return {
            itemsForm: {
                nombre: '',
                apellido: '',
                tipopermiso: 0,
                fecha: '',

            },
            loader: true,
            items: [],
            selected: []
        };
    },
    mounted() {

        this.getPermisos();
    },
    methods: {
        getPermisos() {
            axios.get('http://192.168.15.169:8081/Api/Permiso', {
                    header: {
                        'Access-Control-Allow-Origin': '*'
                    }
                })
                .then(
                    function(response) {
                        let dt = response.data;


                        dt.forEach((item) => {
                            console.log(item);
                            this.items.push({

                                Id: item.id,
                                nombre: item.nombreEmpleado,
                                apellido: item.apellidosEmpleado,
                                tipo: item.tipoPermiso,
                                fecha: item.fechaPermiso
                            });
                        });
                        this.loader = false;
                        console.log(this.items);


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
            console.log(permiso, "antes");
            axios.post('http://localhost:8080/Api/Permiso', {
                    permiso: permiso
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