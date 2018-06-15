<template>
    <div class="address_info">
        <p>{{address.index}}</p>
        <p>{{address.surname}}</p>
        <p>{{address.name}}</p>
        <p>{{address.middlename}}</p>
        <p>{{address.address}}</p>
        <p>{{address.phone}}</p>
        <button>Изменить</button>
        <button v-on:click="remove">Удалить</button>
        <router-link class="rout_link_btn" to="/">Назад</router-link>
    </div>
</template>

<script>
    export default {
        name: 'address',
        props: {
            index: {
                type: String,
                default: '',
                required: true
            },
            address: {
                type: Object,
                default: {}
            }
        },
        methods: {
            remove: function(){
                this.axios.get('http://localhost:55464/api/Address/Remove?index=' + this.address.index)
                    .then(response => {
                        this.$router.push('/');
                    })
                    .catch(ex => {
                        this.errors.push(ex)
                    })
            }
        },
        created() {
            if(this.index == ''){
                this.index = this.$router.currentRoute.params.index
            }

            this.axios.get('http://localhost:55464/api/Address/Info/?addressIndex=' + this.index).then((response) => {
                this.address = response.data
            })
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
