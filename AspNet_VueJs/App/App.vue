<template>
    <div id="home">
        <header>
          <h1>Адресная книга города Новокузнецк</h1>
        </header>

        <table class="table_content">
            <tr>
                <th>п/п</th>
                <th>Фамилия</th>
                <th>Имя</th>
                <th>Отчество</th>
                <th>Адрес</th>
                <th>Телефон</th>
            </tr>
            <tr>
                <td><router-link to="/Address/Info/1">1</router-link></td>
                <td>Иванов</td>
                <td>Иван</td>
                <td>Иванович</td>
                <td>Кирова, 51</td>
                <td>8-999-123-7654</td>
            </tr>
        </table>
    </div>
</template>

<script>
  export default { }
</script>

<style lang="scss">
</style>
