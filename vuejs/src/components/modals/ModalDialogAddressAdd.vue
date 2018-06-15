<template>
    <modal-dialog v-show="show" v-on:close="close">
        <modal-address slot="body"></modal-address>
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
            }
        }
    }
</script>

<style scoped>

</style>
