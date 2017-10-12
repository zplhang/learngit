using System;
namespace OperatorsApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 60;
			int b = 13;
			int c = 0;
			
			c = a & b;
			Console.WriteLine("c的值为：{0}", c);
			c = a | b;
			Console.WriteLine("c的值为：{0}", c);
			c = a ^ b;
			Console.WriteLine("c的值为：{0}", c);
			c = ~a;
			Console.WriteLine("c的值为：{0}", c);
			c = a << 2;
			Console.WriteLine("c的值为：{0}", c);
			c = a >> 2;
			Console.WriteLine("c的值为：{0}", c);
			Console.ReadLine();
		}
	}
}