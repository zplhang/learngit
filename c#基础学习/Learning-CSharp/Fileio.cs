using System;
using System.IO;

namespace FileIOApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			FileStream f = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			
			for(int i = 1; i <= 20; i++)
			{
				f.WriteByte((byte)i);
			}
			f.Position = 0;
			for(int i = 0; i <= 20; i++)
			{
				Console.Write(f.ReadByte() + " ");
			}
			f.Close();
			
			/*
			* 通过File类设置文件属性
			Console.WriteLine(File.GetAttributes("test.dat"));
			File.SetAttributes("test.dat", FileAttributes.Hidden | FileAttributes.ReadOnly);
			Console.WriteLine(File.GetAttributes("test.dat"));
			*/
			
			/*
			* 通过FileInfo类设置文件属性
			FileInfo fi = new FileInfo("test.dat");
			Console.WriteLine(fi.Attributes.ToString());
			fi.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
			Console.WriteLine(fi.Attributes.ToString());
			*/
			
			//文件路径相关操作
			string dirPath = @"D:\TestDir";
			string filePath = @"D:\TestDir\TestFile.txt";
			Console.WriteLine("<<<<<<<<<<<<<<<{0}>>>>>>>>>>>>>>>", "文件路径");
			
			//获取当前路径
			Console.WriteLine(Environment.CurrentDirectory);
			//文件或文件夹所在目录
			Console.WriteLine(Path.GetDirectoryName(filePath));
			Console.WriteLine(Path.GetDirectoryName(dirPath));
			//文件扩展名
			Console.WriteLine(Path.GetExtension(filePath));
			//文件名
			Console.WriteLine(Path.GetFileName(filePath));
			Console.WriteLine(Path.GetFileName(dirPath));
			Console.WriteLine(Path.GetFileNameWithoutExtension(filePath));
			
			//绝对路径
			Console.WriteLine(Path.GetFullPath(filePath));
			Console.WriteLine(Path.GetFullPath(dirPath));
			
			//更改扩展名
			Console.WriteLine(Path.ChangeExtension(filePath, ".jpg"));
			//根目录
			Console.WriteLine(Path.GetPathRoot(dirPath));
			
			
			Console.ReadLine();
		}
	}
}
