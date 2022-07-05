// Собрать строку с числами от a до b, a >= b.

String NumbersFor(int a, int b)      // Итеративный подход.
{
    string result = String.Empty;
    for(int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumbersFor(10,1));

//Метод рекурсии
string NumbersRec(int a, int b)
{
    if(a >= b) return  $"{a} " + NumbersRec(a-1, b);  
    else return String.Empty;
}
Console.WriteLine(NumbersRec(10,1));

//вариант 2 тут сначала происходят вычисления в рекурсии, а затем выводятся значения переменной в обратном порядке от максим до мин.
string NumbersRec1(int a, int b)
{
    if(a <= b) return NumbersRec1(a+1, b) + $"{a} ";
    else return String.Empty;
}
string res = NumbersRec1(1,10);
System.Console.WriteLine(res);
