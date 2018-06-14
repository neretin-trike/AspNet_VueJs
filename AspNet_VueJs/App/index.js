import Vue from 'vue'
import VueRouter from 'vue-router'
import AddressInfo from './App.vue'
import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.config.productionTip = false
Vue.use(VueRouter)
Vue.use(VueAxios, axios)

const routes = [
    {
        path: '/api/Address/Info/:index',
        component: AddressInfo
    }
]

const router = new VueRouter({
    routes
})

new Vue({
    el: '#app',
    data: {
        addresses: []
    },
    router,
    created() {
        this.axios.get('/api/Address/Addresses').then((response) => {
            console.log(response.data)
            this.addresses = response.data
        })
    }
})