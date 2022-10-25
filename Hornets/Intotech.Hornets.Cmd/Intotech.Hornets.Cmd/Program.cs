// See https://aka.ms/new-console-template for more information
using Intotech.Hornets.Cmd;
using Intotech.Hornets.Cmd.Kalkulator;

CalculatorKrzysiu.GiveMathOperation();


GenericTypes gtypes = new GenericTypes();
gtypes.AreAnagrams("tomekj", "tmkoei");

Console.WriteLine("Podaj wartosc: ");
string userInput = Console.ReadLine();

int test = 0;
int.TryParse(userInput, out test);

if (test == 0)
{
    test = StringUtils.ExtractDigitsForString(userInput);
}

Console.WriteLine(test);


GenericTypes gt = new GenericTypes();

gt.DivideStringIntoChars("porsche panamera");


//Console console = new Console();


TextUtils tu = new TextUtils();

string month = tu.PeselToMonth("84021211112");

for (; ; )
{
    string password = tu.GenerateStrongRandomPassword();
}

// OOP

//Console.WriteLine(password);

//ThisIsASimpleClass tiasc = new ThisIsASimpleClass();

