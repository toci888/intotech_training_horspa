// See https://aka.ms/new-console-template for more information
using Julia._2._0;

Console.WriteLine("Hello, World!");

for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        Console.Write(((i + j) % 2).ToString() + " ");
    }

    Console.WriteLine();
}

int first = 2;
double second = 2.2;

string alphabet = "abcdef";

int[] someArray = new int[] { 2, 4, 6, 8 };

Juliag julia = new Juliag() { MixedString = StringUtil.GetMixedString(12) };
Juliag julia2 = new Juliag() { MixedString = StringUtil.GetMixedString(12) };

int doopa = 0;