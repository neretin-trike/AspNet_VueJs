<template>
    <modal-dialog v-show="show" v-on:close="close">
        <modal-address-modify slot="body"></modal-address-modify>
    </modal-dialog>
</template>

<script>
    import modalDialog from './ModalDialogBase.vue'
    import modalAddressModify from './ModalDialogAddressModify.vue'

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
            modalAddressModify
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
