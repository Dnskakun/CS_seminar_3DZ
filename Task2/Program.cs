//Программа принимает на вход координаты двух точек и находит между ними расстояние в 3D пространстве

int x1=0, y1=0, z1=0, x2=0, y2=0, z2=0;

Console.WriteLine("Введите координаты первой точки:");
InitCoordinatesByUser(ref x1, ref y1, ref z1);

Console.WriteLine("Введите координаты второй точки:");
InitCoordinatesByUser(ref x2, ref y2, ref z2);

double res = Result(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {Math.Round(res, 2)}");


//Методы
static void InitCoordinatesByUser(ref int x, ref int y, ref int z)
{
    try
    {
        Console.Write("Введите X: ");
        x = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите Y: ");
        y = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите Z: ");
        z = int.Parse(Console.ReadLine() ?? "");
    }

    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

double Result(int a, int b, int c, int d, int e, int f)
{
    double result = Math.Sqrt(Math.Pow((d-a), 2) + Math.Pow((e-b), 2) + Math.Pow((f-c), 2));
    return result;
}
