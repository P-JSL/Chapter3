using static System.Console;

checked
{
    try
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value : {x}");
        x++;
        WriteLine($"After incrementing : {x}");
        x++;
        WriteLine($"After incrementing : {x}");
        x++;
        WriteLine($"After incrementing : {x}");
    } catch (OverflowException)
    {
        WriteLine("오버플로 예외가 발생했지만 여기서 처리했음.");
    }
}
unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value : {y}");
    y--;
    WriteLine($"After incrementing : {y}");
    y--;
    WriteLine($"After incrementing : {y}");
    y--;
    WriteLine($"After incrementing : {y}");
}
