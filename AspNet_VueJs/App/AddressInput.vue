<template>
	<div class="modal-content">
		<form v-on:submit.prevent v-on:submit="add">
			<label for="surname">Фамилия</label>
			<input type="text" name="surname" id="surname" v-model="surname"/>
			<label for="name">Имя</label>
			<input type="text" name="name" id="name" v-model="name"/>
			<label for="middlename">Отчество</label>
			<input type="text" name="middlename" id="middlename" v-model="middlename"/>
			<label for="address">Адрес</label>
			<input type="text" name="address" id="address" v-model="address"/>
			<label for="phone">Номер телефона</label>
			<input type="text" name="phone" id="phone" v-model="phone"/>
			<input type="submit" value="Добавить"/>
		</form>
	</div>
</template>

<script>
	export default {
		name: 'modal-content',
		data: function() {
			return {
				surname: '',
				name: '',
				middlename: '',
				address: '',
				phone: ''
			}
		},
		methods:{
			add: function(event){
				event.preventDefault();
				var parameters = { surname : this.surname, name : this.name, middlename : this.middlename, address : this.address, phone : this.phone };
				this.axios.post('/api/Address/Add', parameters).then(res => {
					console.log(res)
				});
			}
		}
	}
</script>

<style></style>