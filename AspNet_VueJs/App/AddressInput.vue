<template>
	<div class="modal-content">
		<form action="/Address/Add" method="POST">
			<label for="inputSurname">Фамилия</label>
			<input type="text" name="inputSurname" id="inputSurname"/>
			<label for="inputName">Имя</label>
			<input type="text" name="inputName" id="inputName"/>
			<label for="inputMiddlename">Отчество</label>
			<input type="text" name="inputMiddlename" id="inputMiddlename"/>
			<label for="inputAddress">Адрес</label>
			<input type="text" name="inputAddress" id="inputAddress"/>
			<label for="inputPhone">Номер телефона</label>
			<input type="text" name="inputPhone" id="inputPhone"/>
			<input type="submit" value="Добавить"/>
		</form>
	</div>
</template>

<script>
	export default {
		name: 'modal-content'
	}
</script>

<style></style>