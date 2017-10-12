using System;

namespace ClassApplication
{
	/*
	class Box
	{
		public double length;
		public double breadth;
		public double height;
	}
	*/
	class Box
	{
		private double length;
		private double breadth;
		private double height;
		
		public void setLength(double len)
		{
			length = len;
		}
		
		public void setBreadth(double bread)
		{
			breadth = bread;
		}
		
		public void setHeight(double hei)
		{
			height = hei;
		}
		
		public double getVolume()
		{
			return length * breadth * height;
		}
	}
	
	class BoxTester
	{
		static void Main(string[] args)
		{
			Box box1 = new Box();
			Box box2 = new Box();
			double volume = 0.0;
			
			//box1
			/*
			box1.height = 5.0;
			box1.length = 6.0;
			box1.breadth = 7.0;
			
			//box2
			box2.height = 10.0;
			box2.length = 12.0;
			box2.breadth = 13.0;
			
			//box1的体积
			volume = box1.height * box1.length * box1.breadth;
			Console.WriteLine("box1的体积: {0}", volume);
			
			//box2的体积
			volume = box2.height * box2.length * box2.breadth;
			Console.WriteLine("box2的体积: {0}", volume);
			*/
			box1.setLength(6.0);
			box1.setBreadth(7.0);
			box1.setHeight(5.0);
			
			box2.setLength(12.0);
			box2.setBreadth(13.0);
			box2.setHeight(10.0);
			
			volume = box1.getVolume();
			Console.WriteLine("box1的体积: {0}", volume);
			volume = box2.getVolume();
			Console.WriteLine("box2的体积: {0}", volume);

			Console.ReadLine();
		}
		
	}
}