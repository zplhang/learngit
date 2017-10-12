using System;
using System.Threading;

namespace MultithreadingApplication
{
	class MainThreadProgram
	{
		public static void CallToChildThread()
		{
			try
			{
				Console.WriteLine("Chlid thread starts");
			
				//int sleepfor = 5000;
				//Console.WriteLine("Child thread paused for {0} seconds", sleepfor / 1000);
				//Thread.Sleep(sleepfor);
				//计数到10
				for(int counter = 0; counter <= 10; counter++)
				{
					Thread.Sleep(500);
					Console.WriteLine(counter);
				}
				Console.WriteLine("Child thread Completed");
			}
			catch(ThreadAbortException e)
			{
				Console.WriteLine("Thread Abort Exception");
			}
			finally
			{
				Console.WriteLine("Couldn't catch the thread exception");
			}
		}
		
		static void Main(string[] args)
		{
			/*
			Thread th = Thread.CurrentThread;
			th.Name = "MainThread";
			Console.WriteLine("This is {0}", th.Name);
			*/
			ThreadStart childref = new ThreadStart(CallToChildThread);
			Console.WriteLine("In Main: Creating the child thread");
			Thread childThread = new Thread(childref);
			childThread.Start();
			//停止主线程一段时间
			Thread.Sleep(2000);
			//中止子线程
			Console.WriteLine("In Main: Aborting the child thread");
			childThread.Abort();
			Console.ReadKey();
		}
	}
}
