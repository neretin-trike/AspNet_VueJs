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
                    <router-link v-bind:to="address.addressUrl">{{address.index}}</router-link>
                </td>
                <td>{{address.surname}}</td>
                <td>{{address.name}}</td>
                <td>{{address.middlename}}</td>
            </tr>
        </table>

        <div class="menu_table">
            <button type="button" class="btn" v-on:click="showModal">Добавить</button>
            <a href="/">Home</a>
        </div>

        <modal-address-add v-bind:show="isModalVisible" v-on:close="closeModal"></modal-address-add>
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
                this.addresses = response.data;
                for(var i=0; i<this.addresses.length; i++){
                    this.addresses[i].addressUrl = '/Address/' + this.addresses[i].index;
                }
                console.log(this.addresses);
            })
        }
    }
</script>

<style scoped>
    .table_content {
        min-width: 60rem;
        border-collapse: collapse;
        color: #686461;
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

    .menu_table {
        margin: 1rem 0;
    }
</style>
