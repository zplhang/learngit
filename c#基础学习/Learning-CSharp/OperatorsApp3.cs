using System;
namespace OperatorsApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			bool a = true;
			bool b = true;
			
			if(a && b)
			{
				Console.WriteLine("条件为真。");
			}
			if(a || b)
			{
				Console.WriteLine("条件为真。");
			}
			//改变a，b的值
			a = false;
			b = true;
			if(a && b)
			{
				Console.WriteLine("条件为真。");
			}
			else
			{
				Console.WriteLine("条件为假。");
			}
			
			if(!(a && b))
			{
				Console.WriteLine("条件为真。");
			}
			Console.ReadLine();
		}
	}
}