Main();

void Main()
{
  Console.Write("Введите число: ");
  int number = int.Parse(Console.ReadLine());

  if(number<100000 && number>10000)
  {
    int thirdDigit = (number / 100) % 10;
    Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}.");
  }
  else if(number>999 && number<10000)
  {
    int thirdDigit = (number / 10) % 10;
    System.Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}.");
  }

  else if(number>99 && number<1000)
  {
    int thirdDigit = number % 10;
    System.Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}.");
  }

  else if(number<100)
  {
    System.Console.WriteLine("Третьей цифры числа нет");
  }
}