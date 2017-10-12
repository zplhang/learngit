using System;
namespace ArrayApplication
{
	class MyArray
	{
		static void Main(string[] args)
		{
			//声明并默认初始化10个整数的数组
			int[] n = new int[10];
			
			//输出每个数组元素的值
			for(int j = 0; j < 10; j++)
			{
				Console.WriteLine("Element[{0}] = {1}", j, n[j]);
			}
			
			//初始化数组
			for(int i = 0; i < 10; i++)
			{
				n[i] = i + 100;
			}
			
			//输出每个数组元素的值
			/*
			for(j = 0; j < 10; j++)
			{
				Console.WriteLine("Element[{0}] = {1}", j, n[j]);
			}
			*/
			foreach(int j in n)
			{
				int i = j - 100;
				Console.WriteLine("Element[{0}] = {1}", i, j);
			}

			Console.ReadLine();
		}
		
	}
}