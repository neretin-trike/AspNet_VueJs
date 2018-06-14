import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const About = {template: '<h1>About</h1>'}

let router = new Router({
	routes:[
		{
			path: '/about',
			component: About
		}
	]
})

export default router