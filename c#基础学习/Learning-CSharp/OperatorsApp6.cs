using System;
namespace OperatorsApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			//sizeof
			Console.WriteLine("int的大小是：{0}", sizeof(int));
			Console.WriteLine("short的大小是：{0}", sizeof(short));
			Console.WriteLine("double的大小是：{0}", sizeof(double));
			
			//?:
			int a, b;
			a = 10;
			b = (a == 1) ? 20 : 30;
			Console.WriteLine("b的值是：{0}", b);
			b = (a == 10) ? 20 : 30;
			Console.WriteLine("b的值是：{0}", b);
			Console.ReadLine();
		}
	}
}