using System;
namespace CalculatorApplication
{
	class NumberManipulator
	{
		public void getValue(out int x)
		{
			int temp = 5;
			x = temp;
		}
		
		public void getValues(out int x, out int y)
		{
			Console.WriteLine("请输入第一个值：");
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("请输入第二个值：");
			y = Convert.ToInt32(Console.ReadLine());
		}
		/*
		public void swap(ref int x, ref int y)
		{
			//声明局部变量
			int temp;
			
			temp = x;//保存x的值
			x = y;//把y赋值给x
			y = temp;//把temp的值赋值给y
		}
		*/
		
		static void Main(string[] args)
		{
			//定义局部变量
			//int a = 100;
			int a, b;

			NumberManipulator n = new NumberManipulator();
			
			//Console.WriteLine("方法调用之前a的值为：{0}", a);
			//调用swap方法来交换值
			//n.getValue(out a);
			n.getValues(out a, out b);
			Console.WriteLine("方法调用之后a的值为：{0}", a);
			Console.WriteLine("方法调用之后b的值为：{0}", b);
			Console.ReadLine();
		}
		
	}
}