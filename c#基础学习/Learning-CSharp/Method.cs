using System;
namespace CalculatorApplication
{
	class NumberManipulator
	{
		public int FindMax(int num_a, int num_b)
		{
			//声明局部变量
			int result;
			
			if(num_a > num_b)
			{
				result = num_a;
			}
			else
			{
				result = num_b;
			}
			return result;
		}
		
		/*
		static void Main(string[] args)
		{
			//定义局部变量
			int a = 100;
			int b = 200;
			int ret;
			NumberManipulator n = new NumberManipulator();
			
			//调用FindMax方法
			ret = n.FindMax(a, b);
			Console.WriteLine("最大值是：{0}", ret);
			Console.ReadLine();
		}
		*/
	}
	class Test
	{
		static void Main(string[] args)
		{
			//定义局部变量
			int a = 100;
			int b = 200;
			int ret;
			NumberManipulator n = new NumberManipulator();
			
			//调用FindMax方法
			ret = n.FindMax(a, b);
			Console.WriteLine("最大值是：{0}", ret);
			Console.ReadLine();
		}
	}
}