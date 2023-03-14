/// <summary>
/// Выводит все натуральные числа в убывающем порядке начиная с number
/// </summary>
/// <param name="number">Начальное значение ряда</param>
/// <returns>Строка чисел, через запятую</returns>
string Task_64(int number)
{
    if (number == 1) return "1";

    return number.ToString() + "," + Task_64(--number);
}

/// <summary>
/// Суммирует все натуральные числа в промежутке от m до n
/// </summary>
/// <param name="m">Начало отрезка</param>
/// <param name="n">Конец отрезка</param>
/// <returns>Сумма</returns>
int Task_66(int m, int n)
{
    //Нечетное количество чисел - схождение на одном числе
    if (m == n) return m;

    //Четное количество чисел - схождение на соседних
    if (Int32.Abs(m - n) == 1) return m + n;

    // границы промежутка заданы в обратном порядке
    if (m > n) return m + n + Task_66(--m, ++n);

    return m + n + Task_66(++m, --n);
}
/// <summary>
/// Вычисление функции Аккермана
/// </summary>
/// <param name="n">Начало отрезка</param>
/// <param name="m">Конец отрезка</param>
/// <returns>Результат</returns>
int Task_68(int n, int m)
{
    if (n == 0) return m + 1;
    else 
    if (m == 0) return Task_68(n - 1 , 1);
    else return Task_68(n - 1, Task_68(n, m - 1));
}

Console.WriteLine("Задача 64");
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N = {0} -> \"{1}\"",N ,Task_64(N));
Console.WriteLine();

Console.WriteLine("Задача 66");
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("M = {0}, N = {1} -> {2}",M ,N ,Task_66(M, N));
Console.WriteLine();

Console.WriteLine("Задача 68");
Console.Write("Введите M: ");
M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("M = {0}, N = {1} -> A(m, n) = {2}",M ,N ,Task_68(M, N));
Console.WriteLine();