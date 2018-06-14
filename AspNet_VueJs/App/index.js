import Vue from 'vue'
import VueRouter from 'vue-router'
import AddressInfo from './App.vue'
import axios from 'axios'
import VueAxios from 'vue-axios'
import modal from './ModalAddress.vue'
import modalContent from './AddressInput.vue'

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
		addresses: [],
		isModalVisible: false
	},
	components: {
		modal,
		modalContent
	},
	methods: {
		showModal(){
			this.isModalVisible = true;
		},
		closeModal(){
			this.isModalVisible = false;
		}
	},
    router,
    created() {
        this.axios.get('/api/Address/Addresses').then((response) => {
            console.log(response.data)
            this.addresses = response.data
        })
    }
})