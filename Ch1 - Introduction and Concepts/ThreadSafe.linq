<Query Kind="Program">
  <Namespace>System.Threading</Namespace>
</Query>

class ThreadSafe
{
	static bool _done;
	static readonly object locker = new object();
	
	static void Main()
	{
			new Thread(Go).Start(); // Will print "Done".
			Go(); // Won't print "Done" (usually).
	}

	static void Go()
	{
		lock (locker)
		{
			if (!_done)
			{
				Console.WriteLine("Done");
				_done = true;
			}
		}
	}
}