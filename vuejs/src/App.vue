<template>
    <main class="container">
        <router-view></router-view>
    </main>
</template>

<script>
    export default {
        name: 'App'
    }
</script>

<style>
    html {
        font-size: 62.5%;
        font-family: Tahoma;
    }

    body {
        padding: 0;
        margin: 0;
        background-color: white;
    }

    .container {
        max-width: 120rem;
        margin: 0 auto;
        font-size: 1.4rem;
    }
</style>
