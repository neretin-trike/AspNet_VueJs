<template>
    <div class="modal-content">
        <form v-on:submit.prevent v-on:submit="submit">
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
            <input type="submit" v-bind:value="buttonName"/>
        </form>
    </div>
</template>

<script>
    export default {
        name: 'modal-address',
        props: {
            urlBase: {
                type: String,
                default: '',
                required: true
            },
            addressObject: {
                type: Object
            },
            buttonName: {
                type: String,
                default: 'Отправить'
            }
        },
        data: function() {
            return {
                index: -1,
                surname: '',
                name: '',
                middlename: '',
                addressString: '',
                phone: ''
            }
        },
        methods:{
            submit: function(event){
                var parameters = { index: this.index, surname : this.surname, name : this.name, middlename : this.middlename, addressString : this.addressString, phone : this.phone };
                this.axios.get(this.urlBase + '?index=' + parameters.index + '&surname=' + parameters.surname + '&name=' + parameters.name
                    + '&middlename=' + parameters.middlename + '&address=' + parameters.addressString + '&phone=' + parameters.phone
                    /*, parameters*/).then(res => {
                    this.$parent.close();
                })
            },
        },
        created(){
            if(this.addressObject != undefined){
                this.index = this.addressObject.index;
                this.surname = this.addressObject.surname;
                this.name = this.addressObject.name;
                this.middlename = this.addressObject.middlename;
                this.addressString = this.addressObject.address;
                this.phone = this.addressObject.phone;
            }
        }
    }
</script>

<style>

</style>
