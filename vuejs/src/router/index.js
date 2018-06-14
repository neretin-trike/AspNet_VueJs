import Vue from 'vue'
import VueRouter from 'vue-router'

import addresses from '../components/Addresses.vue'

Vue.use(VueRouter)

const About = {template: '<h1>About</h1>'}

let router = new VueRouter({
  routes:[
    {
      path: '/',
      component: addresses
    },
    {
      path: '/about',
      component: About
    }
  ]
})

export default router
