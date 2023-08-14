using static System.Console;

int a = 3;
int b = a++;
Console.WriteLine($"a is {a}, b is {b }");

int c = 3;
int d = ++c;
Console.WriteLine($"c is {c}, d is {d}");

//이항산술

int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g/f}");

//대입연산자
int p = 6;
p += 3;
p -= 3;
p *= 3;
p /= 3;

