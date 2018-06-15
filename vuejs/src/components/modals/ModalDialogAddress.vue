<template>
    <form class="modal_content" v-on:submit.prevent v-on:submit="submit">
        <label class="input_label" for="surname">Фамилия</label>
        <input class="input" type="text" name="surname" id="surname" v-model="surname"/>
        <label class="input_label" for="name">Имя</label>
        <input class="input"type="text" name="name" id="name" v-model="name"/>
        <label class="input_label" for="middlename">Отчество</label>
        <input class="input"type="text" name="middlename" id="middlename" v-model="middlename"/>
        <label class="input_label" for="address">Адрес</label>
        <input class="input"type="text" name="address" id="address" v-model="addressString"/>
        <label class="input_label" for="phone">Номер телефона</label>
        <input class="input"type="text" name="phone" id="phone" v-model="phone"/>
        <input type="submit" class="btn btn_submit" v-bind:value="buttonName"/>
    </form>
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
            addresses: {
                type: Array
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
            submit: function(){
                //var parameters = { index: this.index, surname : this.surname, name : this.name, middlename : this.middlename, addressString : this.addressString, phone : this.phone };

                this.axios.get(this.urlBase + '?index=' + this.index + '&surname=' + this.surname + '&name=' + this.name
                    + '&middlename=' + this.middlename + '&address=' + this.addressString + '&phone=' + this.phone
                    //, parameters
                )
                    .then(res => {
                        this.index = res.data;
                        console.log(res.data);
                        console.log(this.index);

                        if(this.addressObject != undefined) {
                            this.addressObject.index = this.index;
                            this.addressObject.surname = this.surname;
                            this.addressObject.name = this.name;
                            this.addressObject.middlename = this.middlename;
                            this.addressObject.address = this.addressString;
                            this.addressObject.phone = this.phone;
                        }

                        if(this.addresses != undefined) {
                            console.log(this.index);
                            var addressObject = {
                                index : this.index,
                                surname : this.surname,
                                name : this.name,
                                middlename : this.middlename,
                                address : this.addressString,
                                phone : this.phone,
                                orderNumber : this.addresses.length+1,
                                addressUrl : '/Address/' + this.index
                            }
                            this.addresses[this.addresses.length] = addressObject;
                        }

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
    .modal_content{
        display: flex;
        flex-direction: column;
    }

    .input_label{
        margin-top: 1rem;
    }

    .input{
        padding: 0.4rem;
    }

    .btn_submit{
        margin: 1.4rem 0;
    }
</style>
