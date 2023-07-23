// 从这里开始，为了方便，省略顶级语句
// 直接写代码就好
// 会直接运行里面的代码，相当于默认就是main函数了
// 下面直接展示各种运算符的使用方法
Console.WriteLine("1 + 1 = {0}", 1 + 1);
Console.WriteLine("1 - 1 = {0}", 1 - 1);
Console.WriteLine("1 * 5 = {0}", 1 * 5);
Console.WriteLine("6 / 2 = {0}", 6 / 2);
// 取余数
Console.WriteLine("5 % 2 = {0}", 5 % 2);
int a = 10;
// 自增
a++;
Console.WriteLine("a = {0}", a);
// 自减
a--;
Console.WriteLine("a = {0}", a);
/*
c = a++: 先将 a 赋值给 c，再对 a 进行自增运算。
c = ++a: 先将 a 进行自增运算，再将 a 赋值给 c 。
c = a--: 先将 a 赋值给 c，再对 a 进行自减运算。
c = --a: 先将 a 进行自减运算，再将 a 赋值给 c 。
*/

// 关系运算符
//其实就是比较一下两个数据的关系
Console.WriteLine("1 == 0, {0}", 1 == 0);
Console.WriteLine("1 != 0, {0}", 1 != 0);
Console.WriteLine("1 > 0, {0}", 1 > 0);
Console.WriteLine("1 < 0, {0}", 1 < 0);
Console.WriteLine("1 >= 0, {0}", 1 >= 0);
Console.WriteLine("1 <= 0, {0}", 1 <= 0);

// 逻辑运算符
// 其实就是与或非，三大关系
Console.WriteLine(true && true);
Console.WriteLine(false && true);

Console.WriteLine(true || true);
Console.WriteLine(false || true);

Console.WriteLine(true && !true);
Console.WriteLine(false && !true);

// 位运算
// 用的少，但是挺高端的
/*
&	如果同时存在于两个操作数中，二进制 AND 运算符复制一位到结果中。	(A & B) 将得到 12，即为 0000 1100
|	如果存在于任一操作数中，二进制 OR 运算符复制一位到结果中。	(A | B) 将得到 61，即为 0011 1101
^	如果存在于其中一个操作数中但不同时存在于两个操作数中，二进制异或运算符复制一位到结果中。	(A ^ B) 将得到 49，即为 0011 0001
~	按位取反运算符是一元运算符，具有"翻转"位效果，即0变成1，1变成0，包括符号位。	(~A ) 将得到 -61，即为 1100 0011，一个有符号二进制数的补码形式。
<<	二进制左移运算符。左操作数的值向左移动右操作数指定的位数。	A << 2 将得到 240，即为 1111 0000
>>	二进制右移运算符。左操作数的值向右移动右操作数指定的位数。	A >> 2 将得到 15，即为 0000 1111
 */
int A = 60;
int B = 13;
Console.WriteLine("A is {0}",Convert.ToString(A, 2));
Console.WriteLine("A is {0}",Convert.ToString(B, 2));
Console.WriteLine(Convert.ToString(A & B, 2));
Console.WriteLine(Convert.ToString(A | B, 2));
Console.WriteLine(Convert.ToString(A ^ B, 2));
Console.WriteLine(Convert.ToString(~ A, 2));

// 赋值运算符
a = 21;
int c;
c = a;
Console.WriteLine("Line 1 - =  c 的值 = {0}", c);
c += a;
Console.WriteLine("Line 2 - += c 的值 = {0}", c);
c -= a;
Console.WriteLine("Line 3 - -=  c 的值 = {0}", c);
c *= a;
Console.WriteLine("Line 4 - *=  c 的值 = {0}", c);
c /= a;
Console.WriteLine("Line 5 - /=  c 的值 = {0}", c);
c = 200;
c %= a;
Console.WriteLine("Line 6 - %=  c 的值 = {0}", c);
c <<= 2;
Console.WriteLine("Line 7 - <<=  c 的值 = {0}", c);
c >>= 2;
Console.WriteLine("Line 8 - >>=  c 的值 = {0}", c);
c &= 2;
Console.WriteLine("Line 9 - &=  c 的值 = {0}", c);
c ^= 2;
Console.WriteLine("Line 10 - ^=  c 的值 = {0}", c);
c |= 2;
Console.WriteLine("Line 11 - |=  c 的值 = {0}", c);


// 其他运算符
/*
sizeof()	返回数据类型的大小。	sizeof(int)，将返回 4.
typeof()	返回 class 的类型。	typeof(StreamReader);
&	返回变量的地址。	&a; 将得到变量的实际地址。
*	变量的指针。	*a; 将指向一个变量。
? :	条件表达式	如果条件为真 ? 则为 X : 否则为 Y
is	判断对象是否为某一类型。	If( Ford is Car) // 检查 Ford 是否是 Car 类的一个对象。
as	强制转换，即使转换失败也不会抛出异常
*/
// 不展示了，反正正常就好；优先级的话反正小括号大于一切