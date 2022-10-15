// See https://aka.ms/new-console-template for more information
using Intotech.Hornets.Cmd;

Console.WriteLine("Hello, World!");

//Console console = new Console();


TextUtils tu = new TextUtils();

string password = tu.GenerateStrongRandomPassword();

Console.WriteLine(password);

//ThisIsASimpleClass tiasc = new ThisIsASimpleClass();

