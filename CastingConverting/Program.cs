using static System.Console;
using static System.Convert;

int a = 10;
double b = a;
WriteLine(b);

double c = 9.8;
int d = (int)c;
WriteLine(d);

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g:N} and h is {h:N}");

//반올림
double[] doubles = new[]
{
    9.49, 9.5, 9.51, 10.49, 10.5, 10.51
};
foreach( double n in doubles)
{
    WriteLine($"ToInt({n}) is {ToInt32(n)}");
}

foreach(double n in doubles)
{
    WriteLine(
        format: "Math.Round({0}), 0, MidpointRounding.AwayFromZero is  {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero)
        );
}

//바이너리 객체 -> string 변환
//ToBase64String 및 FormBase64String

//128bit array
byte[] binaryObject = new byte[128];

//무작위
(new Random()).NextBytes(binaryObject);
WriteLine("Binary Object as bytes : ");
for(int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X}");
}
WriteLine();

string encoded = Convert.ToBase64String(binaryObject);
WriteLine($"binary Ojbect as Base64 : {encoded}");

//string -> number, date, time

int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");
WriteLine($"I was born {age} years ago.");
WriteLine($"My Birthday is {birthday}");
WriteLine($"My Birthday is {birthday:D}");

//tryParse
WriteLine("How many eggs are there?");
int count;
string input = ReadLine();
if (int.TryParse(input, out count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse  the input.");
}