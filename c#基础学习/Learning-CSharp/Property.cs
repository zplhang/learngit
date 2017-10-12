using System;
namespace PropertyApplication
{
	public abstract class Person
	{
		public abstract string Name
		{
			get;
			set;
		}
		public abstract int Age
		{
			get;
			set;
		}
	}
	
	class Student : Person
	{
		//成员变量
		private string code = "N.A";
		private string name = "not known";
		private int age = 0;
		
		//声明类型为string的Code属性
		public string Code
		{
			get
			{
				return code;
			}
			set
			{
				code = value;
			}
		}
		
		//声明类型为string的Name属性
		//public string Name
		public override string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		
		//声明类型为int的Age属性
		//public int Age
		public override int Age
		{
			get
			{
				return age;
			}
			set
			{
				age = value;
			}
		}
		
		public override string ToString()
		{
			return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
		}
	}
	
	class ExecuteDemo
	{
		public static void Main(string[] args)
		{
			//创建一个新的Student对象
			Student s = new Student();
			
			//设置student的code，name和age
			s.Code = "001";
			s.Name = "Zara";
			s.Age = 9;
			Console.WriteLine("Student Info: {0}", s);
			
			//增加年龄
			s.Age += 1;
			Console.WriteLine("Student Info: {0}", s);
			
			Console.ReadLine();
		}
	}
}