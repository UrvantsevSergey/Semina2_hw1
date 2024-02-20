using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int num = 1;
    while (num != 0)
    {
      Console.WriteLine("Введите число ");
      num = Convert.ToInt32(Console.ReadLine());
      if (num%7 == 0 && num%2 == 0)
      {
        Console.WriteLine($" {num} ");
      }
    }
    
  }
}