import Vue from 'vue'
import App from './App.vue'
import router from './router/index.js'
import axios from 'axios'
import VueAxios from 'vue-axios'

var axiosInstance = axios.create({
    baseURL: 'http://localhost:22080',
    timeout: 3000
});

Vue.use(VueAxios, axiosInstance)

new Vue({
	el: '#app',
	router,
	components: { App },
	template: '<App/>'
})
