import Vue from 'vue'
import App from './App.vue'
import router from './router'
import { BootstrapVue, BIcon } from 'bootstrap-vue'


Vue.use(BootstrapVue)
Vue.component('b-icon', BIcon)


Vue.config.productionTip = false

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

new Vue({
    router,
    render: h => h(App)
}).$mount('#app')