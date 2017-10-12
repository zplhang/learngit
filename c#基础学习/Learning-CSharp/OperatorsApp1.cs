using System;
namespace OperatorsApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 21;
			int b = 10;
			int c;
			
			c = a + b;
			Console.WriteLine("a + b = {0}", c);
			c = a - b;
			Console.WriteLine("a - b = {0}", c);
			c = a * b;
			Console.WriteLine("a * b = {0}", c);
			c = a / b;
			Console.WriteLine("a / b = {0}", c);
			c = a % b;
			Console.WriteLine("a % b = {0}", c);
			
			//++a 先进行自增运算再赋值。c = a++,先将a赋值给c，再对a进行自增。
			c = ++a;
			Console.WriteLine("++a = {0}", c);
			//此时a为22，--a先进行自减再赋值
			c = --a;
			Console.WriteLine("--a = {0}", c);
			
			a = 1;
			b = a++;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();
			
			a = 1;
			b = ++a;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();
			
			a = 1;
			b = a--;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();
			
			a = 1;
			b = --a;
			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.ReadLine();
		}
	}
}