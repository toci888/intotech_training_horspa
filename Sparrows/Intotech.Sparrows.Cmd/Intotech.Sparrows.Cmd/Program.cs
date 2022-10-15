// See https://aka.ms/new-console-template for more information

// klasa, obiekt klasy, statyczne , metoda/funkcja, parametr plain text string
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

string[] womenNames = new string[] { "Ania", "Julia", "Asia" };

Console.WriteLine(nationalIdentityNumber[8]);


if (womenNames[0] == "Ania")
{
    // ??
}

//for (int i = ?; ; )
