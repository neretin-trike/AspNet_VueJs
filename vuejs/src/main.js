import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router'
//import router from './router/index.js'
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

new Vue({
	el: '#app',
	router,
	components: { App },
	template: '<App/>'
})
