using System;
namespace OperatorsApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 20;
			int b = 10;
			int c = 15;
			int d = 5;
			int e;
			e = (a + b) * c / d;
			Console.WriteLine("(a + b) * c / d的值是：{0}", e);
			e = ((a + b) * c) / d;
			Console.WriteLine("((a + b) * c) / d的值是：{0}", e);
			e = (a + b) * (c / d);
			Console.WriteLine("(a + b) * (c / d)的值是：{0}", e);
			e = a + (b * c) / d;
			Console.WriteLine("a + (b * c) / d的值是：{0}", e);
			Console.ReadLine();
		}
	}
}