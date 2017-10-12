using System;
namespace RectangleApplication
{
	class Rectangle
	{
		//成员变量
		private double length;
		private double width;
		
		public void AcceptDetails()
		{
			Console.WriteLine("请输入长度：");
			length = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("请输入宽度：");
			width = Convert.ToDouble(Console.ReadLine());
		}
		
		public double GetArea()
		{
			return length * width;
		}
		
		public void Display()
		{
			Console.WriteLine("长度：{0}", length);
			Console.WriteLine("宽度：{0}", width);
			Console.WriteLine("面积：{0}", GetArea());
		}
	}
	
	class ExecuteRectangle
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle();
			//r.length = 5.4;
			//r.width = 3.2;//报错
			r.AcceptDetails();
			r.Display();
			Console.ReadLine();
		}
	}
}