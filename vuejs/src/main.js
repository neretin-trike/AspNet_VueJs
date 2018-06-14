import Vue from 'vue'
import App from './App.vue'
import router from './router/index.js'
import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, axios)

new Vue({
	el: '#app',
	router,
	components: { App },
	template: '<App/>'
})
