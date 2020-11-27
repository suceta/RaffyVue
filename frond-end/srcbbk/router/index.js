import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

import CreatePermiso from '../components/Permiso/CreatePermiso.vue'
import ListaPermiso from '../components/Permiso/ListaPermiso.vue'
import DeletePermiso from '../components/Permiso/DeletePermiso.vue'
import UpdatePermiso from '../components/Permiso/UpdatePermiso.vue'

/*import DeletePermiso from '../views/Home.vue'
import ListPermiso from '../views/Home.vue'

import CreateTipoPermiso from '../views/Home.vue'

import DeleteTipoPermiso from '../views/Home.vue'
import ListTipoPermiso from '../views/Home.vue' *
*/

Vue.use(VueRouter)

const routes = [{
        path: '/',
        name: 'Home',
        component: Home
    },
    {
        path: '/CreatePermiso',
        name: 'CreatePermiso',
        component: CreatePermiso
    },
    {
        path: '/ListaPermiso',
        name: 'ListaPermiso',
        component: ListaPermiso
    },
    {
        path: '/DeletePermiso',
        name: 'DeletePermiso',
        component: DeletePermiso
    },
    {
        path: '/UpdatePermiso/:id',
        name: 'UpdatePermiso',
        component: UpdatePermiso
    },

    {
        path: '/about',
        name: 'About',
        // route level code-splitting
        // this generates a separate chunk (about.[hash].js) for this route
        // which is lazy-loaded when the route is visited.
        component: () =>
            import ( /* webpackChunkName: "about" */
                '../views/About.vue')
    }
]

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes
})

export default router