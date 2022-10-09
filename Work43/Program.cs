//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. (b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5))

double InputNumber(string name)
{
  Console.WriteLine($"Введите число {name}: ");
  return Convert.ToDouble(Console.ReadLine());
}
void PrintArray(double[] array)
{
  Console.Write("(");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] +  (i != array.Length-1 ? ", " : ")"));
  }
  Console.WriteLine();
}
void IntersectionPoint(double b1, double k1, double b2, double k2)
{
  double x;  
  double y;
  if (k1 != k2)
  {
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    double[] coordinate = new double[2];
    for (int i = 0; i < coordinate.Length; i++)
    {
      if (i == 0)
      {
        coordinate[i] = x;
      }
      coordinate[i] = y;
    }
    PrintArray(coordinate);
  }
  else
  {
    Console.WriteLine("Точек пересечеия нет, прямые параллельны");
  }
}

double b1 = InputNumber("b1");
double k1 = InputNumber("k1");
double b2 = InputNumber("b2");
double k2 = InputNumber("k2");

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");
IntersectionPoint(b1, k1, b2, k2);
