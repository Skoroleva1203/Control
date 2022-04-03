В программе реализуется поставленная задача:
Написать программу, которая из имеющегомя массива строк формирует массив из строк, длина которых меньше либо равна 3 симовла. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решениеии не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Для решения поставленной задачи мы создали массив "people" (тип данных string), элементы которого задали непосредственно в программе (имена).
Для создания искомого массива "new_people", в котором длина элементов должна быть меньше или равна 3, мы первоначально находим в массиве "people" количество элементов, удовлевторяющих условию, что реализовано в методе "Count".
Далее, создаем массив "new_people" в котором количество элементов равно числу "count". 
Вновь берем массив "people" и, перебирая все элементы данного массива, сравнивая их длину с условием (<= 3), производим выборку нужных нам элементов, одновременно перенося их в новый массив "new_people". 
Полученный результат отображается на консоли терминала при попомщи метода "PrintMassiv". 