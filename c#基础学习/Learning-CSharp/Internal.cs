using System;
namespace RectangleApplication
{
	class Rectangle
	{
		//成员变量
		internal double length;
		internal double width;
		
		double GetArea()
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
			r.length = 5.4;
			r.width = 3.2;
			r.Display();
			Console.ReadLine();
		}
	}
}