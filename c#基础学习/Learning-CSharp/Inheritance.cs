using System;

namespace InheritanceApplication
{
	class Shape
	{
		protected int width;
		protected int height;
		
		public void setWidth(int w)
		{
			width = w;
		}
		
		public void setHeight(int h)
		{
			height = h;
		}
	}
	
	class Rectangle : Shape
	{
		public int getArea()
		{
			return width * height;
		}
	}
	
	class RectangelTester
	{
		static void Main(string[] args)
		{
			Rectangle rect = new Rectangle();
			rect.setWidth(5);
			rect.setHeight(7);
			Console.WriteLine("×ÜÃæ»ý£º{0}", rect.getArea());
			Console.ReadKey();
		}
	}
}