using System;
namespace CalculatorApplication
{
	class NumberManipulator
	{
		public void swap(int x, int y)
		{
			//声明局部变量
			int temp;
			
			temp = x;//保存x的值
			x = y;//把y赋值给x
			y = temp;//把temp的值赋值给y
		}
		
		
		static void Main(string[] args)
		{
			//定义局部变量
			int a = 100;
			int b = 200;
			
			NumberManipulator n = new NumberManipulator();
			
			Console.WriteLine("交换之前a的值为：{0}", a);
			Console.WriteLine("交换之前b的值为：{0}", b);
			//调用swap方法来交换值
			n.swap(a, b);
			Console.WriteLine("交换之后a的值为：{0}", a);
			Console.WriteLine("交换之后b的值为：{0}", b);
			Console.ReadLine();
		}
		
	}
}