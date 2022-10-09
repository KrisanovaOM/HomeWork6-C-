// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string InputNumber()
{
  Console.WriteLine($"Введите числа через запятую: ");
  return Console.ReadLine();
}
int[] ArrayNumber(string value)
{  
  string[] arrayString = value.Split(",").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
  int[] arrayInt = new int[arrayString.Length];

  for (int i = 0; i < arrayString.Length; i++)
  {
    arrayInt[i] = Convert.ToInt32(arrayString[i]);
  }
  return arrayInt;
}
int CountPositivNumber(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      count++;
    }
  }
  return count;
}

Console.WriteLine($"Пользователь ввел чисел больше 0: {CountPositivNumber(ArrayNumber(InputNumber()))}");
