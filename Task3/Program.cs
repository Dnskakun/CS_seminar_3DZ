//Программа принимает на вход число N и выдает таблицу кубов чисел от 1 до N

int userInput1 = UserInput();

if(userInput1 > 0)
{
    int count = 1;
    while (count < userInput1)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
        count++;
    }
    Console.Write($"{Math.Pow(userInput1, 3)}.");
}
else
{
    Console.WriteLine("Введенно число должно быть больше нуля. Попробуйте ещё раз!");
}


//Методы
int UserInput()
{
    int number;
    Console.Write("Введите целое число больше нуля: ");
    while (true)
    {
        if(int.TryParse(Console.ReadLine(), out number))
        {
        break;
        }
        Console.WriteLine("Ошибка ввода!");
    }
    return number;
}