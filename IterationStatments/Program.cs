using System.Collections;
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
/*
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
WriteLine("correct");*/

//for loop
for(int y=0; y<10; y++)
{
    WriteLine(y);
}

//foreach loop
// 배열이나 컬렉션 내의 각 아이템에 대해 코드블록 실행
//example
string[] names = { "Adam","Barry","Charlie"};
foreach(string name in names)
{
    WriteLine($"{name} has {name.Length} characters");
}

IEnumerator e = names.GetEnumerator();
while (e.MoveNext())
{
    string name = (string)e.Current;
    WriteLine($"{name} has {name.Length} charactor");
}
