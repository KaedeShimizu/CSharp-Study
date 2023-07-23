// 其实就是最常见的几种循环，这里直接展示
int i = 0;
while(i < 10)
{
    Console.WriteLine(i); i++;
}
Console.WriteLine("===");
for(int j = 0; j < 10; j++)
{
    Console.WriteLine(j); 
}

// foreach是用来遍历元素用的，很好用
List<string> nameList = new List<string>();
nameList.Add("Kaede");
nameList.Add("Shimizu");
nameList.Add("Link");
foreach (string s in nameList)
{
    Console.WriteLine(s);
}

// dowhile用的少，这里不多说了，和while差不多

// 可以用break退出循环，continue就是继续，跳过本次循环
while (true)
{
    string input = Convert.ToString(Console.ReadLine());
    if(input == "quit")
    {
        break;
    }
}