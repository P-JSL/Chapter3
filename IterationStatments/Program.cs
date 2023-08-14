using static System.Console;

int x = 0;
while(x < 10)
{
    WriteLine(x);
    x++ ;
}

// do roop

string? password;
int count = 0;

do {
    Write("Enter your password : ");
    password = ReadLine();
    if (password != "Pa$$w0rd")
    {
        count++;
    }
    if(count == 10)
    {
        WriteLine("10 times fail your password");
    }
} while (password != "Pa$$w0rd");
WriteLine("correct");

//for loop
