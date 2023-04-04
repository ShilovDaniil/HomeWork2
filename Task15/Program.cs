Main();

void Main()
{
  System.Console.WriteLine("Введите число от 1 до 7: ");
  int number = int.Parse(System.Console.ReadLine());

  if(number>0 && number<6)
  {
    System.Console.WriteLine("No");
  }
  else if(number>5 && number<8)
  {
    System.Console.WriteLine("Yes");
  }
  else if(number<1 && number>7)
  {
    System.Console.WriteLine("Error!");
  }
}