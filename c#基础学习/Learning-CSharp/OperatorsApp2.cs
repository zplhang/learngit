using System;
namespace OperatorsApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 21;
			int b = 10;
			
			if(a == b)
			{
				Console.WriteLine("a 等于 b ");
			}
			else
			{
				Console.WriteLine("a 不等于 b ");
			}
			
			if(a < b)
			{
				Console.WriteLine("a 小于 b ");
			}
			else
			{
				Console.WriteLine("a 不小于 b ");
			}
			
			if(a > b)
			{
				Console.WriteLine("a 大于 b ");
			}
			else
			{
				Console.WriteLine("a 不大于 b ");
			}
			a = 5;
			b = 20;
			if(a <= b)
			{
				Console.WriteLine("a 小于或等于 b ");
			}
			if(b >= a)
			{
				Console.WriteLine("b 大于或等于 a ");
			}
			
			Console.ReadLine();
		}
	}
}