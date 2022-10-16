// See https://aka.ms/new-console-template for more information

// klasa, obiekt klasy, statyczne , metoda/funkcja, parametr plain text string
using Intotech.Sparrows.Cmd;

Console.WriteLine("Hello, World!");

int peselLength = 11;

// struktura, typ wartosciowy    0123456789
string nationalIdentityNumber = "84080818074"; //camel case

bool exists = nationalIdentityNumber.Contains("9");

if (nationalIdentityNumber.Length == peselLength && nationalIdentityNumber.StartsWith("84")) // && 
{
    Console.WriteLine("Polish, aged 38");
}

// typ tablicowy, kolekcja
                                      //0       1       2
string[] womenNames = new string[] { "Ania", "Bartek", "Julia", "Asia" };

for (int i = 0; i < womenNames.Length; i++)
{
    Console.WriteLine(womenNames[i]);

    char isA = womenNames[i][womenNames[i].Length - 1];

    if (isA == 'a')
    {
        Console.WriteLine(womenNames[i] + " to imię kobiece. ");
    }
}

                  //0123
//womenNames[0][3] ->    a
//womenNames.Length
Console.WriteLine(nationalIdentityNumber[8]);
             //0123
string anna = womenNames[0];
             //0123
string asia = "Asia"; // length = 4
             // 01234
string julia = "Julia"; //length = 5

//char isA = anna[anna.Length - 1];

if (womenNames[0] == "Ania")
{
    // ??
}

//string[][][] fsqd       = new string[2][][];

//3                                                                             4
string[] programingLangs = new string[] { "Javascript", "Php", "C++", "C#", "Java" };

string[][] hahaha = new string[5][];

hahaha[0] = new string[10];

hahaha[4] = new string[4];

//string[0-7][0-7] 
string java = programingLangs[4];
  //2
//Java
//01
// "C#"
char wtf = programingLangs[4][2]; //v
//programingLangs[3] -> C#, c#[1] -> "#"
//for (int i = ?; ; )
string dfasd = "";

string intotech = "Intotech";
//int i = 7;
Console.WriteLine("Julia"[2]); // ? 

// w pionie

string vertical = "w pionie";


for (int i = 0; i < vertical.Length; i++) // > < >= <= && ||
{
    Console.WriteLine(vertical[i]);
}

//int test = + - * / = == < > <= >= || && & | ! !=;

//Math.Pow(2, 10);

//Console.WriteLine("console log xd " + test);

Dictionary<string, string> map;
//null
//if (map != null && map.ContainsKey)

if (2 < 3 || 7 < 8)
{
   
}

CollectionUtils cu = new CollectionUtils();

cu.GetMonthNameFromPesel("89101112345");