// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Введите число M");
double M = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число N");
double N = Convert.ToDouble(Console.ReadLine());
if (M < 0 & N < 1) Console.WriteLine("на заданном числовом интервале натуральные числа отсутствуют)");

string result = NaturalsNumber(M , N);
Console.WriteLine();
Console.WriteLine(result);

string NaturalsNumber(double leftValue, double rightValue)
{
    int nFirstNaturalNumber = 1;
    string naturals = String.Empty;
    int nLastNaturalNumber = Convert.ToInt32(Math.Round(rightValue, 0));
    if (leftValue < 1 & rightValue > 1)
    {
        for (int i = 1; i <= nLastNaturalNumber; i++)
        {
            string j = Convert.ToString(i);
            naturals = naturals + j + " ";
        }
    }
    if (leftValue > 1 & rightValue > 1)
    {
        nFirstNaturalNumber = Convert.ToInt32(Math.Round(leftValue, 0));
        for (int i = nFirstNaturalNumber; i <= nLastNaturalNumber; i++)
        {
            string j = Convert.ToString(i);
            naturals = naturals + j + " ";
        }
    }
    return naturals;
}

   