import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const About = {template: '<h1>About</h1>'}

let router = new VueRouter({
  routes:[
    {
      path: '/',
      component: {template: '<h1>Home</h1>'}
    },
    {
      path: '/about',
      component: About
    }
  ]
})

export default router
