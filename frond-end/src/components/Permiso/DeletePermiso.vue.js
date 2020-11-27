import axios from 'axios';

export default {
    name: 'DeletePermiso',
    data() {
        return {
            itemsForm: {
                nombre: '',
                apellido: '',
                tipopermiso: 0,
                fecha: ''
            },
            idPermiso: 0,
            isDelete: false

        };
    },
    mounted() {
        this.idPermiso = this.$route.params.id;
    },
    methods: {

        deletePermiso() {

            axios.delete('http://localhost:8080/Api/Permiso/' + this.idPermiso, {
                    id: this.idPermiso
                })
                .then((response) => {
                    //router.push('/articulos');
                    if (response.data) this.isDelete = true;
                    console.log(response);

                })
                .catch(function(error) {
                    console.log(error);
                });

        },

    }
}