## Итоговая проверочная работа

### Задача :
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

### Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]  
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]  
[“Russia”, “Denmark”, “Kazan”] → []

### Решение:
1. Выводим запрос количества элементов массива - size.
2. Задаем массив arr1 размером size.
3. Пользователь поочередно вводит каждый элемент массива с клавиатуры.
4. Выводим в консоль массив пользователя arr1.
5. Задаем переменную maxLength - максимальное количество символов элемента в обработанном массиве.
6. С помощью цикла считаем количество элемент массива, подходящих под условие: элемент массива <= maxLength.
7. С помощью цикла заполняем новый массив arr2. Для этого ещё проверяем каждый элемента массива нашим условием: элемент массива <= maxLength.
8. Выводим в консоль обработанный массив arr2.

### Блок-схема
Блок-схема находится в проекте в папке [Scheme](https://github.com/alex-ush/final-work/tree/main/Scheme)  
Также блок-схему можно посмотреть в [MIRO](https://miro.com/app/board/uXjVMd98Afo=/?share_link_id=669028419450)
