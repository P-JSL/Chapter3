using static System.Console;


/*
  Excerise 01)
 1] 1 / 0  ? 0으로 나눌수없다는 예외
 2] 아무 예외 발생 X
 3] 스택오버플로우 예외발생
 4] 후위연산과 전위연산.먼저 계산 후 가산, 먼저 가산되고 계산의 차이
 5] break > switch 문에서 나가기, countinue > 조건에 맞지않으면 계속 반복, return > 반복,조건문 탈출 및 값 외부로 보내기
 6] 초기화, 조건, 증가/감소 등 추가조건
 7] = 는 초기화, == 는 같은지의 여부. 이퀄과 같음.
 8] for( ; true; ); > 컴파일 됨.
 9] switch 에서 _ 는 default, 무조건 마지막에 나오는것.
 10] foreach문으로 열거하기 위해 객체가 구현해야 하는 인터페이스 : Iterator 과 nextMove
 */

/*
 Excerise02 )
 
int max = 500;
for (byte i =0; i < max; i++)
{
    WriteLine(i);
}
*/
// i가 max값이 되기 전까지 무한반복


/*
 Excerise03 )
 */
int MAX = 100;
for (int y = 1; y<= MAX; y++)
{
    if (y % 3 != 0 && y % 5 != 0)
    {
        Write($"{y} ");
    }
    else
    {
        Write("Fizz ");
    }
    
}

/*
 Excerise04 ) 0에서 255까지의 숫자 중 2가지를 입력받아, 
 첫 번쨰 입력 받은 수를 두 번째 입력 받은 수로 나누어 그 결과 출력하기.
 */
WriteLine();
Write("Enter the number between 0 and 255 : ");
int number1 = int.Parse(ReadLine());
Write("Enter another numbere between 0 and 255 : ");
int number2 = int.Parse(ReadLine());
Write($"{number1} divide by {number2} is {number1 / number2}");