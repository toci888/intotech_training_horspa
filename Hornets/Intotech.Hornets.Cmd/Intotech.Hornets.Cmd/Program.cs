// See https://aka.ms/new-console-template for more information
using Intotech.Hornets.Cmd;

Console.WriteLine("Hello, World!");

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

