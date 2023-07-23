// 就是最常见的条件判断，和其他语言差不多
// 这里直接写一个最简单的例子
int a = 10;
if (a > 10)
{
    Console.WriteLine("a > 10");
}
else if(a == 10)
{
    Console.WriteLine("a = 10");
}
else
{
    Console.WriteLine("a < 10");
}

// 嵌套也是可以的
int score = 100;
if (score >= 80)
{
    if(score >= 90)
    {
        Console.WriteLine("优秀");
    }
    else
    {
        Console.WriteLine("良好");
    }
}

// 当然，还有有趣的switch语句
int day = 0;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("None");
        break;
}

// switch也可以嵌套，这里不多说了
// 当然，还有三元运算符
a = 10;
int b = 20;
Console.WriteLine(a > b ? "a > b" : "a <= b");