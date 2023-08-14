using static System.Console;

int a = 10; // 0000 1010
int b = 6; // 0000 0110;

WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}");
WriteLine($"a | b = {a | b}");
WriteLine($"a ^ b = {a ^ b}");

static string ToBinaryString(int value)
{
    return Convert.ToString(value, toBase:2).PadLeft(8,'0');
}

WriteLine();
WriteLine("Outputting integers as binary");
WriteLine($"a =         {ToBinaryString(a)}");
WriteLine($"b =         {ToBinaryString(b)}");
WriteLine($"a & b =     {ToBinaryString(a & b)}");
WriteLine($"a | b =     {ToBinaryString(a | b)}");
WriteLine($"a ^ b =     {ToBinaryString(a ^ b)}");