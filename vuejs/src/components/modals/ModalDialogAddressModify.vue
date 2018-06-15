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
            <input type="text" name="address" id="address" v-model="addressString"/>
            <label for="phone">Номер телефона</label>
            <input type="text" name="phone" id="phone" v-model="phone"/>
            <input type="submit" value="Добавить"/>
        </form>
    </div>
</template>

<script>
    export default {
        name: 'modal-address-modify',
        props: {
            addressObject: {
                type: Object,
                default: () => {}
            }
        },
        data: function() {
            return {
                surname: '',
                name: '',
                middlename: '',
                addressString: '',
                phone: ''
            }
        },
        methods:{
            add: function(event){
                event.preventDefault();
                var parameters = { surname : this.surname, name : this.name, middlename : this.middlename, addressString : this.addressString, phone : this.phone };
                this.axios.get('http://localhost:55464/api/Address/Add?surname=' + parameters.surname + '&name=' + parameters.name
                    + '&middlename=' + parameters.middlename + '&address=' + parameters.addressString + '&phone=' + parameters.phone
                    /*, parameters*/).then(res => {
                    this.$parent.close();
                });
            }
        }
    }
</script>

<style>

</style>
