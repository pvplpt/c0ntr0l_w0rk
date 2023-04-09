# Итоговая контрольная работа по основному блоку
## Урок 1. Контрольная работа

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

### **Задача:** *Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*
```
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```

### **Решение:**

1. Так как в C# нет динамических массивов, а коллекции использовать нельзя, то первым делом нужно ввести количество элементов исходного массива **N**. 
2. После этого логично осуществить ввод исходного массива **userArray**. 
3. Алгоритм решения поставленной задачи очень прост: просмотреть все элементы исходного массива, длину каждого сравнить с числом 3 и подходящие элементы записать в результирующий массив **resultArray**. С результирующим массивом связано несколько проблем: в общем случае количество элементов в нем будет меньше, чем в исходном массиве; массив не динамический, поэтому при создании нужно точно указать сколько будет элементов в результирующем массиве. Первая проблема решается элементарно: для подсчета количества строк в исходном массиве, удовлетворяющий условию задачи, введем переменную счетчик **count**. Вторая проблема решается в два этапа: сначала создать массив **resultArray** максимального размера, а затем уменьшить его размер до **count**. Очевидно, что максимальный размер результируешего массива будет **N**, это произойдет, если все строки исходного массива будут длинной не более 3 символов. А для уменьшения размера массива вспомним метод **Array.Resize(ref arr, count)** из лекции "Урок 8. Дополнитеная лекция. C#: от простого к практике" от 20.03.2023г.
4. Осталось вывести результирующий массив **resultArray**. 


### **Составим блок-схему алгоритма:**

![Блок-схема](./%D0%91%D0%BB%D0%BE%D0%BA-%D1%81%D1%85%D0%B5%D0%BC%D0%B0%20%D0%BA%20%D0%B0%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D0%BC%D1%83%20%D0%B8%D1%82%D0%BE%D0%B3%D0%BE%D0%B2%D0%BE%D0%B9%20%D0%BA%D0%BE%D0%BD%D1%82%D1%80%D0%BE%D0%BB%D1%8C%D0%BD%D0%BE%D0%B9%20%D0%BF%D0%BE%20%D0%BE%D1%81%D0%BD%D0%BE%D0%B2%D0%BD%D0%BE%D0%BC%D1%83%20%D0%B1%D0%BB%D0%BE%D0%BA%D1%83.drawio.png "Блок-схема")

### **Напишем программу, решающую поставленную задачу:**

[Исходный код программы на C#](https://github.com/pvplpt/c0ntr0l_w0rk/blob/main/Program.cs)