// 简单说，就是这个类型修饰的内容是可以为空的
// 如果我直接int a，不想给任何初始值，那么null类型是很好的选择
// 比如这个下面的int
int a = 0; // 默认是0
int? b = null; //默认是null
Console.WriteLine("a is {0}, b is {1}", a, b);

// 当然，也可以用new关键字创建一个空的类型
double? name = new double?();
Console.WriteLine("name is {0}", name);

// 当然也有null合并运算符
// 怎么说呢，和三元运算符很相似，只是用两个问号链接
// 如果一个为空，那么返回另外一个不为空的
int? num1 = 10;
int? num2 = null;
Console.WriteLine("{0}", num1 ?? num2);
int? num3 = 200;
// 都不为空返回第一个传入的值
Console.WriteLine("{0}", num1 ?? num3);