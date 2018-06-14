<template>
    <div class="address_info">
		<p>{{address.index}}</p>
        <p>{{address.surname}}</p>
        <p>{{address.name}}</p>
        <p>{{address.middlename}}</p>
        <p>{{address.address}}</p>
        <p>{{address.phone}}</p>
		<button>Изменить</button>
		<button>Удалить</button>
		<button>Закрыть</button>
    </div>
</template>

<script>
    export default {
        props: {
            index: {
                type: String,
                default: '',
                required: true,
			},
			address: {
				type: Object,
				default: {}
			}
		},
        created() {
            if(this.index == ''){
				this.index = this.$router.currentRoute.params.index
			}

			this.axios.get('/api/Address/Info/?addressIndex=' + this.index).then((response) => {
				this.address = response.data
			})
        }
    }
</script>

<style lang="scss">
</style>
