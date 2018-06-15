<template>
    <div>
        <table class="table_content">
            <caption>Адресная книга города Новокузнецк</caption>
            <tr>
                <th>п/п</th>
                <th>Фамилия</th>
                <th>Имя</th>
                <th>Отчество</th>
            </tr>
            <tr v-for="address in addresses">
                <td>
                    <router-link v-bind:to="address.addressUrl">{{address.orderNumber}}</router-link>
                </td>
                <td>{{address.surname}}</td>
                <td>{{address.name}}</td>
                <td>{{address.middlename}}</td>
            </tr>
            <tr>
                <button type="button" class="btn btn_add" v-on:click="showModal">Добавить</button>
            </tr>
        </table>
        <modal-address-add v-bind:show="isModalVisible" v-bind:addresses="addresses" v-on:close="closeModal"></modal-address-add>
    </div>
</template>

<script>
    import modalAddressAdd from './modals/ModalDialogAddressAdd.vue'

    export default {
        name: "Addresses",
        data: function () {
            return {
                addresses: [],
                isModalVisible: false
            }
        },
        components:{
            modalAddressAdd
        },
        methods: {
            showModal(){
                this.isModalVisible = true;
            },
            closeModal(){
                this.isModalVisible = false;
            }
        },
        created() {
            this.axios.get('http://localhost:55464/api/Address/Addresses').then((response) => {
                let addressesFromServer = response.data;
                for(var i=0; i<addressesFromServer.length; i++){
                    let addressUrl = '/Address/' + addressesFromServer[i].index;
                    let orderNumber = i + 1;
                    let addressView = new AddressView(addressesFromServer[i], addressUrl, orderNumber);
                    this.addresses.push(addressView);
                }
            })
        }
    }

    function Address(index, surname, name, middlename, address, phone){
        this.index = index;
        this.surname = surname;
        this.name = name;
        this.middlename = middlename;
        this.address = address;
        this.phone = phone;
    }

    function AddressView(address, addressUrl, orderNumber){
        Address.call(this, address.index, address.surname, address.name, address.middlename, address.address, address.phone);
        this.addressUrl = addressUrl;
        this.orderNumber = orderNumber;
    }
    AddressView.prototype = Object.create(Address.prototype)
</script>

<style scoped>
    .table_content {
        min-width: 60rem;
        border-collapse: collapse;
        color: #686461;
        margin: 2rem auto;
    }

    .table_content caption {
        padding: 0.4rem 1rem;
        color: white;
        background: #8FD4C1;
        font-size: 2rem;
        text-align: left;
        font-weight: bold;
    }

    .table_content th {
        border-bottom: 3px solid #B9B29F;
        text-align: left;
        padding: 0.4rem 1rem;
    }

    .table_content td {
        padding: 0.4rem 1rem;
    }

    .table_content tr:nth-child(odd) {
        background: white;
    }

    .table_content tr:nth-child(even) {
        background: #ebf3f9;
    }

    .table_content tr:last-child{
        background: white;
    }

    .btn_add {
        margin: 1rem 0;
    }
</style>
