<template>
    <transition name="modal_fade">
        <div class="modal_background">
            <div class="modal"
                 role="dialog"
                 aria-labelledby="modalTitle"
                 aria-describedby="modalDescription">
                <header class="modal_header"
                        id="modalTitle">
                    <slot name="header">
                        <button
                            type="button"
                            class="btn_close"
                            v-on:click="close"
                        >
                            x
                        </button>
                    </slot>
                </header>

                <section class="modal_body"
                         id="modalDescription">
                    <slot name="body"></slot>
                </section>

                <footer class="modal_footer">
                    <slot name="footer"></slot>
                </footer>
            </div>
        </div>
    </transition>
</template>

<script>
    export default{
        name: 'modal-dialog',
        methods: {
            close() {
                this.$emit('close');
            }
        }
    }
</script>

<style scoped>
    .modal_background {
        display: flex;
        justify-content: center;
        align-items: center;
        position: fixed;
        top: 0;
        bottom: 0;
        left: 0;
        right: 0;
        background-color: rgba(0, 0, 0, 0.3);
    }

    .modal {
        display: flex;
        flex-direction: column;
        background: #FFFFFF;
        box-shadow: 2px 2px 20px 1px;
        overflow-x: auto;
    }

    .modal_header {
        text-align: right;
        border-bottom: 1px solid #eeeeee;
        color: #4AAE9B;
    }

    .modal_footer {
        justify-content: flex-end;
        border-top: 1px solid #eeeeee;
    }

    .modal_body {
        position: relative;
        padding: 2.4rem 2rem;
    }

    .btn_close {
        border: none;
        font-size: 2.4rem;
        padding: 1.4rem;
        cursor: pointer;
        font-weight: bold;
        color: #4AAE9B;
        background: transparent;
    }

    .modal_fade-enter,
    .modal_fade-leave-active {
        opacity: 0;
    }

    .modal_fade-enter-active,
    .modal_fade-leave-active {
        transition: opacity .5s ease;
    }
</style>
