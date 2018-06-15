import Vue from 'vue'
import VueRouter from 'vue-router'

import addresses from '../components/Addresses.vue'
import address from '../components/Address.vue'

Vue.use(VueRouter)

let router = new VueRouter({
    routes: [
        {
            path: '/',
            component: addresses
        },
        {
            path: '/Address/:index',
            component: address
        }
    ]
})

export default router
