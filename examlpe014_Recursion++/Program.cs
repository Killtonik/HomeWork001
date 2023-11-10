string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for(int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

//Факториал числа

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 0; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if(n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800

// Вычислить а(n - степень)

int PowerFor(inta a, int b)
{
    int result = 1;
    for (int i = 0; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int b)
{
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if(n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}


Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024