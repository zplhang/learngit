using System;

namespace PolymorphismApplication
{
	abstract class Shape
	{
		public abstract int area();
	}
	
	class Rectangle : Shape
	{
		private int length;
		private int width;
		
		public Rectangle(int len = 0, int wid = 0)
		{
			length = len;
			width = wid;
		}
		
		public override int area()
		{
			Console.WriteLine("Rectangle类的面积为：");
			return (length * width);
		}
	}
	class RectangleTester
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle(10,5);
			double a = r.area();
			Console.WriteLine("面积：{0}", a);
			Console.ReadKey();
		}
	}
	
}