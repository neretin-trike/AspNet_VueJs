<template>
    <modal-dialog v-show="show" v-on:close="close">
        <modal-address urlBase="/api/Address/Add" v-on:callback="callback" buttonName="Добавить" slot="body"></modal-address>
    </modal-dialog>
</template>

<script>
    import modalDialog from './ModalDialogBase.vue'
    import modalAddress from './ModalDialogAddress.vue'

    export default {
        name: "modal-address-add",
        props: {
            show: {
                type: Boolean,
                default: false
            }
        },
        components:{
            modalDialog,
            modalAddress
        },
        methods: {
            close(){
                this.$emit('close')
            },
            callback: function(newAddress){
                console.log('AddressAdd')
                console.log(newAddress)
                this.$emit('callback', newAddress)
            }
        }
    }
</script>

<style scoped>

</style>
