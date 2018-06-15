<template>
    <modal-dialog v-show="show" v-on:close="close">
        <modal-address urlBase="/api/Address/Change" v-bind:addressObject="addressObject" buttonName="Изменить" slot="body"></modal-address>
    </modal-dialog>
</template>

<script>
    import modalDialog from './ModalDialogBase.vue'
    import modalAddress from './ModalDialogAddress.vue'

    export default {
        name: "modal-address-modify",
        props: {
            show: {
                type: Boolean,
                default: false
            },
            addressObject: {
                type: Object
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
