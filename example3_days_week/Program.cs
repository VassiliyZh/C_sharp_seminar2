// Вводим трехзначное число, выводим последнюю цифру или сообщает об ее отсутствии
Console.WriteLine("Введите число от 1 до 7 для вывода выходного дня недели");

int number = Convert.ToInt32(Console.ReadLine());


if (number == 6 || number == 7)
{
    System.Console.WriteLine($"{number} это число является днем недели выходного дня");
}
if (number < 1 || number > 7)
{
    System.Console.WriteLine($"{number} это число не является днем недели");
}
if (number >= 1 && number <= 5)
{
    System.Console.WriteLine($"{number} это число является днем недели");
}