# Общие сведения
Проект представляет web-сайт адресной книги.
Для использования необходимо запустить реализации сервера и клиента:
1. Реализации сервера: AspNetServer.
2. Реализации клиента: vuejs.

# Запуск AspNetServer:
1. Перейти в каталог 'AspNetServer';
2. Выполнить сборку проекта: ```dotnet build -c Debug```;
3. Запустить проект: ```dotnet AspNetServer\bin\Debug\netcoreapp2.0\AspNetServer.dll```.

***Примечание:** Сервер использует порт 22080*

# Запуск vuejs:
1. Установить node js. Если node js установлен, может потребоваться его обновление: ```npm i npm```;
2. Перейти в каталог 'vuejs';
3. Установить зависимости проекта: ```npm install```;
4. Запустить проект: ```npm run dev```.

***Примечание:** Клиент использует порт 8080*
