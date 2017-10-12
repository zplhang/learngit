using System;
namespace OperatorsApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 21;
			int c = 0;
			
			c = a;
			Console.WriteLine("c的值为：{0}", c);
			c += a;
			Console.WriteLine("c的值为：{0}", c);
			c -= a;
			Console.WriteLine("c的值为：{0}", c);
			c *= a;
			Console.WriteLine("c的值为：{0}", c);
			c /= a;
			Console.WriteLine("c的值为：{0}", c);
			c = 200;
			c %= a;
			Console.WriteLine("c的值为：{0}", c);
			c <<= 2;
			Console.WriteLine("c的值为：{0}", c);
			c >>= 2;
			Console.WriteLine("c的值为：{0}", c);
			c &= 2;
			Console.WriteLine("c的值为：{0}", c);
			c ^= 2;
			Console.WriteLine("c的值为：{0}", c);
			c |= 2;
			Console.WriteLine("c的值为：{0}", c);
			Console.ReadLine();
		}
	}
}