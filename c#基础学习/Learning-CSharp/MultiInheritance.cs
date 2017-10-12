using System;

namespace InheritanceApplication
{
	//基类
	class Shape
	{
		protected int height;
		protected int width;
		
		public void setWidth(int wid)
		{
			width = wid;
		}
		
		public void setHeight(int hei)
		{
			height = hei;
		}
	}
	
	//基接口
	public interface PaintCost
	{
		int getCost(int area);
	}
	
	//派生类
	class Rectangle : Shape, PaintCost
	{
		public int getArea()
		{
			return width * height;
		}
		
		public int getCost(int area)
		{
			return area * 70;
		}
	}

	class RectangelTester
	{
		static void Main(string[] args)
		{
			Rectangle rect = new Rectangle();
			int area;
			rect.setWidth(5);
			rect.setHeight(7);
			area = rect.getArea();
			Console.WriteLine("总面积：{0}", area);
			Console.WriteLine("油漆总成本：${0}", rect.getCost(area));
			Console.ReadKey();
		}
	}
}