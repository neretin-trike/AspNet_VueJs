<template>
    <div class="address_info">
        <p>{{addressObject.index}}</p>
        <p>{{addressObject.surname}}</p>
        <p>{{addressObject.name}}</p>
        <p>{{addressObject.middlename}}</p>
        <p>{{addressObject.address}}</p>
        <p>{{addressObject.phone}}</p>
        <button v-on:click="showModal">Изменить</button>
        <button v-on:click="remove">Удалить</button>
        <router-link class="rout_link_btn" to="/">Назад</router-link>

        <modal-address-modify v-bind:addressObject="addressObject" v-bind:show="isModalVisible" v-on:close="closeModal"></modal-address-modify>
    </div>
</template>

<script>
    import modalAddressModify from './modals/ModalDialogAddressModify.vue'

    export default {
        name: 'address-item',
        props: {
            index: {
                type: Number
            },
            addressObject: {
                type: Object
            },
        },
        data: function() {
            return {
                indexValue: -1,
                isModalVisible: false
            }
        },
        components:{
            modalAddressModify
        },
        methods: {
            showModal(){
                this.isModalVisible = true;
            },
            closeModal(){
                this.isModalVisible = false;
            },
            remove: function(){
                this.axios.get('http://localhost:55464/api/Address/Remove?index=' + this.addressObject.index)
                    .then(response => {
                        this.$router.push('/');
                    })
                    .catch(ex => {
                        this.errors.push(ex)
                    })
            }
        },
        created() {
            if(this.index == undefined) {
                this.indexValue = this.$router.currentRoute.params.index;
            } else {
                this.indexValue = this.index;
            }

            this.axios.get('http://localhost:55464/api/Address/Info/?addressIndex=' + this.indexValue).then((response) => {
                this.addressObject = response.data;
            });
        }
    }
</script>

<style scoped>
    .address_info {
        background: #eeeee5;
        border: 1px dashed #abab9a;
        padding: 1rem;
        margin: 2rem 1rem;
        font: 1.4rem Tahoma;
        color: #2c2c2c;
    }

    .rout_link_btn{
        text-decoration: none;
        color: black;
        border: solid 1px;
        padding: 0.4rem 0.6rem;
        background: lightgrey;
    }
</style>
