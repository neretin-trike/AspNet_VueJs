<template>
    <div id="home">
		<p>{{address.index}}</p>
        <p>{{address.surname}}</p>
        <p>{{address.name}}</p>
        <p>{{address.middlename}}</p>
        <p>{{address.address}}</p>
        <p>{{address.phone}}</p>
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
                console.log('Index is undefined')
                console.log(this.$router.currentRoute.params.index)
                this.index = this.$router.currentRoute.params.index
				console.log(this.index)
				this.axios.get('/api/Address/Info/?addressIndex=' + this.index).then((response) => {
					console.log(response.data)
					this.address = response.data
				})
            }
        }
    }
</script>

<style lang="scss">
</style>
