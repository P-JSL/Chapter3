using static System.Console;
Write("Before pasing\nWhat is your age? ");
string input = ReadLine();
try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old.");
}
catch(FormatException ex )
{
    WriteLine("The age you entered is not a vaild number format.");
}
catch (OverflowException)
{
    WriteLine("Your age is a vaild number foramt but it is either too big or samll");
}
catch(Exception ex)
{
    Write($"{ex.GetType} says {ex.Message}");
}
WriteLine("After pasing");


Write("Enter the amount : ");
string? amount = ReadLine();
try
{
    decimal amountValue = decimal.Parse(amount);
}
catch(FormatException) when (amount.Contains("$"))
{
    WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
    WriteLine("Amounts must only contain digits!.");
}