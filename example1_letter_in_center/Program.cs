// Вводим трехзначное число, выводим среднюю цифру
Console.WriteLine("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = number / 10;
int secondNumber =  firstNumber % 10;

System.Console.WriteLine(secondNumber);