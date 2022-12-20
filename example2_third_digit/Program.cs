// Вводим трехзначное число, выводим последнюю цифру или сообщает об ее отсутствии
Console.WriteLine("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = number / 100;
if (firstNumber == 0)
{
    System.Console.WriteLine("Ввели не трехначное число");
}
else
{
    int secondNumber =  number % 10;
    System.Console.WriteLine(secondNumber);
}
