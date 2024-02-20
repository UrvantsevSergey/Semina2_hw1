using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number%7 == 0 && number%23 == 0)
    {
      Console.WriteLine($"Число {number} делится на 7 и 23");
    }
    else Console.WriteLine($"Число {number} НЕ делится на 7 и 23");
  }
}