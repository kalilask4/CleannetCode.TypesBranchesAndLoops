// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Hello, World!");
    
 
 /*Types
Value types                         Reference Types - class, record, delegate, array, or interface
enums                               String
                                    Array
user-defined structs                record
                                    class
tuple                               interface

int
bool 
char
...

*/

Console.WriteLine(1.ToString() + " type - " + 1.GetType());
Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);

var let = 23456.ToString();
Console.WriteLine(let + " type - "+ let.GetType());

int count = 100;
count = ++count;
Console.WriteLine(++count); //102
Console.WriteLine(count++); //102
Console.WriteLine(count); //103

Console.WriteLine(0.1 + 0.2 == 0.3); // false
Console.WriteLine(0.1F + 0.2F == 0.3F); // false  !!! =true
Console.WriteLine(0.1F + 0.1F +0.1F + 0.1F + 0.1F == 0.5F); // ??
Console.WriteLine(0.1M + 0.2M == 0.3M); // true

sbyte bValue = 1;
Console.WriteLine(bValue.ToString() + " type - " + bValue.GetType());
ushort sValue = 1;
Console.WriteLine(sValue.ToString() + " type - " + sValue.GetType());
uint iValue = 1U;
Console.WriteLine(iValue.ToString() + " type - " + iValue.GetType());
uint lValue = 1U;
Console.WriteLine(lValue.ToString() + " type - " + lValue.GetType());

Console.WriteLine($"nint.MinValue = {nint.MinValue}");
Console.WriteLine($"nint.MaxValue = {nint.MaxValue}");

Console.WriteLine(DateTime.Now);
Console.WriteLine(Guid.NewGuid());

// Tuple
(string Name, int Age) person = ("Name", 4);
Console.WriteLine(person.ToString() + " type - " + person.GetType());
(double, int) t = (4.5, 3);
Console.WriteLine($"Tuple with elements {t.Item1} and {t.Item2}.");
Console.WriteLine($"Hash code of {t} is {t.GetHashCode()}.");

//Array
var xs = new[] { 4, 7, 9 };
var limits = FindMinMax(xs);
Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");
var ys = new[] { -9, 0, 67, 100 };
var (minimum, maximum) = FindMinMax(ys);
Console.WriteLine($"Limits of [{string.Join(" ", ys)}] are {minimum} and {maximum}");

(int min, int max) FindMinMax(int[] input)
{
    if (input is null || input.Length == 0)
    {
        throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
    }

    var min = int.MaxValue;
    var max = int.MinValue;
    foreach (var i in input)
    {
        if (i < min)
        {
            min = i;
        }
        if (i > max)
        {
            max = i;
        }
    }
    return (min, max);
}

dynamic dyn = 1;
object obj = 1;
Console.WriteLine(dyn.GetType());
Console.WriteLine(obj.GetType());

// делегаты - "объекты-ссылки" на методы
Operation operations = Add;
var result = operations(4, 5);
Console.WriteLine(result);
operations = Multiply; 
result = operations(4, 5);
Console.WriteLine(result);
int Add(int x, int y) => x + y;
int Multiply(int x, int y) => x * y;

Message message = Hi;
message += HowAreYou;
message();
void Hi() => Console.WriteLine("Hi");
void HowAreYou() => Console.WriteLine("How are you?");
String answer = Console.ReadLine();
switch (answer)
{
    case "Ok":
        Console.WriteLine("( ‾́ ◡ ‾́ )");
        break;
    case "Nice":
        Console.WriteLine("<(￣︶￣)>");
        break;
    case "Good":
        Console.WriteLine("╰(*´︶`*)╯");
        break;
    default:
        Console.WriteLine("( ´ ▽ ` ).｡ｏ♡");
        break;
}

delegate int Operation(int x, int y);
delegate void Message();

// Custom types
// struct, class, interface, enum, and record 

//struct
public struct Coords
{
    public int x, y;

    public Coords(int p1, int p2)
    {
        x = p1;
        y = p2;
    }
}

//enum
public enum FileMode
{
    CreateNew = 1,
    Create = 2,
    Open = 3,
    OpenOrCreate = 4,
    Truncate = 5,
    Append = 6,
}