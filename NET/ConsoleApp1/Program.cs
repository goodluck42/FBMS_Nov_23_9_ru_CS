// CLR - Common Language Runtime
// CLS - Common Language Specification
// CTS - Common Type System
// BCL/FCL - Base Class Library / Framework Class Libaray

// Top level statements

// 1b
// bool
// byte
// 2b


// 1b
bool _b = false;
byte _bt = 80;

// 2b
char c = '~';
ushort s = 1000;

// 4b
UInt32 value = 42U;
float f = 12.0f;

// 8b

var l = 10L;
ulong ul = 10UL;
double d = 12.0;

// 16b

decimal d1 = 0.1m;
decimal d2 = 0.2m;

Change(d1, d2);

Console.WriteLine(d1 + d2);

void Change(decimal a, decimal b)
{
    a *= 2;
    b *= 2;
}

// NullReference handling 1
// string? lang = Console.ReadLine();
//
// if (lang != null)
// {
//     Console.WriteLine(lang.ToUpper());
// }

// NullReference handling 2

// string lang = Console.ReadLine()!; // <-- not null
//
// Console.WriteLine(lang.ToUpper());


////////////////////////////////////////

// Parsing with Parse method
// string a = Console.ReadLine()!;
// string b = Console.ReadLine()!;
//
// int val1 = int.Parse(a);
// int val2 = int.Parse(b);
//
// Console.WriteLine(val1 + val2);

// Parsing with TryParse method
// string a = Console.ReadLine()!;
// string b = Console.ReadLine()!;
//
// if (int.TryParse(a, out int val1) && int.TryParse(b, out int val2))
// {
//     Console.WriteLine(val1 + val2);
// }

/////////// if vs switch case 
// int a = int.Parse(Console.ReadLine()!);
// string op = Console.ReadLine()!;
// int b = int.Parse(Console.ReadLine()!);

// if (op == "+")
// {
//     Console.WriteLine(a + b);
// }
// else if (op == "-")
// {
//     Console.WriteLine(a - b);
// }
// else
// {
//     Console.WriteLine("Incorrect operation");
// }

// switch (op)
// {
//     case "plus":
//         Console.Write("a + b = ");
//         Console.WriteLine(a + b);
//         break;
//     case "+":
//         goto case "plus";
//     case "-":
//         Console.WriteLine(a - b);
//         break;
// }
/////////// if vs switch case [END]

/////////// loops

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}

int it = 0;

while (true)
{
    if (it++ == 3)
    {
        break;
    }
}

string message = "Hello my friend";

// for (int i = 0; i < message.Length; i++)
// {
//     Console.WriteLine(message[i]);
// }


foreach (var symbol in message)
{
    Console.WriteLine(symbol);
}



Console.Read();
