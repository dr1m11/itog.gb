# Итоговая работа GeekBrains
## Суть работы
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым файлом описанием решения
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом

## Суть задачи

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых Меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


## Описание решения

1. Для начала нужно создать изначальный массив, в нашем случае он будет такиим "hello", "why", "no", "yes", "stop"
2. Далее, создадим пустую строку, назовем ее result, в которую будем помещать нужные значения. Так как в C# нельяз добавлять элементы в массив, а нам нужно хранилище для значений, используем строковый тип данных.
3. С помощью цикла for и условного оператора if проверяем каждый элемент на то, удоволетворяет ли он нашему условию, если да, то добавляем его в переменную result и рядом еще добавялем нижнее подчеркивание, далее оно нам пригодится.
3. Создаем новый массив, в него добавляем нашу строку используя метод split(), внутри мы указываем, что должно послужить разделителем, в нашем случае это будет "_".
4. Используя цикл for выводим получившийся массив.
