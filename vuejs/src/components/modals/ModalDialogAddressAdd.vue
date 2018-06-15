<template>
    <modal-dialog v-show="show" v-on:close="close">
        <modal-address urlBase="http://localhost:55464/api/Address/Add" v-bind:addresses="addresses" buttonName="Добавить" slot="body"></modal-address>
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
            },
            addresses: {
                type: Array
            }
        },
        components:{
            modalDialog,
            modalAddress
        },
        methods: {
            close(){
                this.$emit('close')
            }
        }
    }
</script>

<style scoped>

</style>
