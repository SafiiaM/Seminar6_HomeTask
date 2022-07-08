// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write($"Введите число М (количество чисел): ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

void InputArray(int M)
{
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Compare(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}

InputArray(M);

Console.WriteLine($"Введено чисел больше 0: -> {Compare(array)} ");