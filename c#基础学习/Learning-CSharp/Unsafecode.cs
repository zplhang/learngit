using System;

 namespace UnsafecodeApplication
 {
	 class Program
	 {
		 /*
		 static unsafe void Main(string[] args)
		 {
			 int varr = 20;
			 int* p = &varr;
			 Console.WriteLine("Data is: {0}", varr);
			 Console.WriteLine("Address is: {0}", (int)p);
			 
			 Console.ReadKey();
		 }
		 */
		 
		 /*
		 public static void Main(string[] args)
		 {
			 unsafe
			 {
				 int varr = 20;
				 int* p = &varr;
				 Console.WriteLine("Data is: {0}", varr);
				 Console.WriteLine("Data is: {0}", p->ToString());
				 Console.WriteLine("Address is: {0}", (int)p);
			 }
			 Console.ReadKey();
		 }
		 */
		 
		 public unsafe void swap(int* p, int* q)
		 {
			 int temp = *p;
			 *p = *q;
			 *q = temp;
		 }
		 
		 public unsafe static void Main(string[] args)
		 {
			 Program p = new Program();
			 int var1 = 10;
			 int var2 = 20;
			 int* x = &var1;
			 int* y = &var2;
			 Console.WriteLine("Before swap: var1 = {0}, var2 = {1}", var1, var2);
			 p.swap(x, y);
			 Console.WriteLine("After swap: var1 = {0}, var2 = {1}", var1, var2);
			 
			 int[] list = {10, 20, 30};
			 fixed(int *ptr = list)
			 for(int i = 0; i < 3; i++)
			 {
				 Console.WriteLine("Address of list[{0}] = {1}", i, (int)(ptr + i));
				 Console.WriteLine("Value of list[{0}] = {1}", i, *(ptr + i));
			 }
			 
			 Console.ReadKey();
		 }
	 }
 }