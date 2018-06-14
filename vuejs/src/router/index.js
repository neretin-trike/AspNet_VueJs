import Vue from 'vue'
import VueRouter from 'vue-router'

import addresses from '../components/Addresses.vue'

Vue.use(VueRouter)

let router = new VueRouter({
  routes:[
    {
      path: '/',
      component: addresses
    }
  ]
})

export default router
