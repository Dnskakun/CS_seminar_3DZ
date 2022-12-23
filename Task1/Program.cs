//Программа принимает на вход пятизначное число и проверяет, является ли оно полиндромом

string res;

int userInput1 = UserInput();
userInput1 = Math.Abs(userInput1);

CheckNum(userInput1, out res);

Console.WriteLine(res);


//Методы
int UserInput()
{
    int number;
    Console.Write("Введите целое пятизначное число: ");
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

void CheckNum(int number, out string result)
{
    if (number > 9999 && number < 100000)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    {
        result = $"{number} -> да (полиндром)";
    }
    else
    {
        result = $"{number} -> нет (не полиндром)";
    }
}

else
{
    result = "Введено не пятизначное число";
}
}

