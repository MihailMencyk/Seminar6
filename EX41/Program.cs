// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2  // 1, -7, 567, 89, 223-> 3
void PrintArray (int[] array)
{
int count = 0;
System.Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    System.Console.Write($"{array[i]} ");
    if (array[i] > 0) count = count+1;
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество чисел больше нуля: {count}");
}

System.Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
PrintArray (array);