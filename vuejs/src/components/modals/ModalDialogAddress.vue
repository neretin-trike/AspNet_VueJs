<template>
    <form class="modal_content" v-on:submit.prevent v-on:submit="submit">
        <div class="error" v-if="errors.length">
            <b>Пожалуйста исправьте указанные ошибки:</b>
            <ul>
                <li v-for="error in errors">{{error}}</li>
            </ul>
        </div>

        <label class="input_label" for="surname">Фамилия</label>
        <input class="input" type="text" name="surname" id="surname" v-model="surname"/>
        <label class="input_label" for="name">Имя</label>
        <input class="input" type="text" name="name" id="name" v-model="name"/>
        <label class="input_label" for="middlename">Отчество</label>
        <input class="input" type="text" name="middlename" id="middlename" v-model="middlename"/>
        <label class="input_label" for="address">Адрес</label>
        <input class="input" type="text" name="address" id="address" v-model="addressString"/>
        <label class="input_label" for="phone">Номер телефона</label>
        <input class="input" type="text" name="phone" id="phone" v-model="phone"/>
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
            buttonName: {
                type: String,
                default: 'Отправить'
            }
        },
        data: function () {
            return {
                index: -1,
                surname: null,
                name: null,
                middlename: null,
                addressString: null,
                phone: null,
                errors: []
            }
        },
        methods: {
            submit: function () {
                //if(!this.checkData()){
                //return;
                //}

                //var parameters = { index: this.index, surname : this.surname, name : this.name, middlename : this.middlename, addressString : this.addressString, phone : this.phone };

                this.axios.get(this.urlBase + '?index=' + this.index + '&surname=' + this.surname + '&name=' + this.name
                    + '&middlename=' + this.middlename + '&address=' + this.addressString + '&phone=' + this.phone
                    //, parameters
                )
                    .then(res => {
                        this.index = res.data;

                        if (this.addressObject != undefined) {
                            this.addressObject.index = this.index;
                            this.addressObject.surname = this.surname;
                            this.addressObject.name = this.name;
                            this.addressObject.middlename = this.middlename;
                            this.addressObject.address = this.addressString;
                            this.addressObject.phone = this.phone;
                        }

                        var addressObject = {
                            index: this.index,
                            surname: this.surname,
                            name: this.name,
                            middlename: this.middlename,
                            address: this.addressString,
                            phone: this.phone,
                            orderNumber: -1,
                            addressUrl: '/Address/' + this.index
                        }

                        this.$emit('callback', addressObject)

                        this.$parent.close();
                    })
            },
            checkData: function () {
                if (!this.surname) {
                    this.errors.push("Укажите фамилию");
                }
                if (!this.name) {
                    this.errors.push("Укажите имя");
                }
                if (!this.middlename) {
                    this.errors.push("Укажите отчество");
                }
                if (!this.address) {
                    this.errors.push("Укажите адрес");
                }
                if (!this.phone) {
                    this.errors.push("Укажите номер телефона");
                }

                if (this.errors.length) {
                    return false;
                } else {
                    return true;
                }
            }
        },
        created() {
            if (this.addressObject != undefined) {
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
    .modal_content {
        display: flex;
        flex-direction: column;
        width: 30rem;
    }

    .input_label {
        margin-top: 1rem;
    }

    .input {
        padding: 0.4rem;
    }

    .btn_submit {
        margin: 1.4rem 0;
    }

    .error {
        padding: 1rem;
        background: #FF9999;
    }
</style>
