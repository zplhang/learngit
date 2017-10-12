using System;
namespace CalculatorApplication
{
	class NullableAtShow
	{
		static void Main(string[] args)
		{
			double? num1 = null;
			double? num2 = 3.14159;
			double num3;
			num3 = num1 ?? 5.34;
			
			Console.WriteLine("num3的值为：{0}", num3);
			num3 = num2 ?? 5.34;
			Console.WriteLine("num3的值为：{0}", num3);
			Console.ReadLine();
		}
		
	}
}