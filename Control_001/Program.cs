// Решение поставленной задачи контрольной работы
// Из имеющегося массива строк сформировать массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 

void PrintMassiv(string[] massiv)  // Метод для вывода массива на консоль элементов массива
{
for (int i = 0; i < massiv.Length; i++)
    Console.Write ($"{massiv[i]}  ");
    Console.WriteLine();
}

int Count (string[] array) // Метод для подсчета количества элементов в массиве, удовлетворяющих заданному условию (создали для инициализации нового массива)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        count++;   
    }
    Console.WriteLine($"\nВ исходном массиве содержится {count} элементов, удовлетворяющих заданному условию\n");
    return count;
}

string[] people = {"Светлана", "Лев", "Анна", "Станислав", "Ли", "Ира", "Вероника", "Владимир", "Валентин"}; // Исходный массив строк
Console.WriteLine ("Исходный массив строк :");
PrintMassiv(people);
string[] new_people = new string[Count(people)]; // Создали новый массив с количеством элементов, удовлетворяющих заданному условию
int j=0;
for (int i = 0; i < people.Length; i++)
{
    Console.WriteLine($"Длина '{people[i]}' = {people[i].Length}");
    if (people[i].Length < 4)
    {
        new_people[j] = people[i];
        j++;
    }    
}

Console.WriteLine ("\nВ результате выборки, согласно заданным условиям (длина строки <= 3), получили массив :");
PrintMassiv(new_people);



 
