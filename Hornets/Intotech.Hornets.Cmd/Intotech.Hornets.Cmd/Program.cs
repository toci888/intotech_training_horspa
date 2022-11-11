// See https://aka.ms/new-console-template for more information
using Intotech.Hornets.Bll.Sketches.Json;
using Intotech.Hornets.Cmd;
using Intotech.Hornets.Cmd.Delegates;
using Intotech.Hornets.Cmd.Kalkulator;


JsonLogic jl = new JsonLogic();

List<DevsModel> resultDevs = jl.RunDeserialization();

List<DevsModel> resultDevsRob = jl.RunDeserializationRob();






DelegateExample delex = new DelegateExample();

delex.CollectionsDemistified();

CalculatorRob.GetUserData();

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

