<Query Kind="Program">
  <Namespace>System.Threading</Namespace>
</Query>

class ThreadTest
{
	bool _done;
	static void Main()
	{
			ThreadTest tt = new ThreadTest (); // Create a common instance.
			new Thread(tt.Go).Start(); // Will print "Done".
			tt.Go(); // Won't print "Done" (usually).
	}

	// Now Go is an instance method.
	void Go()
	{
		if (!_done)
		{
			_done = true;
			Console.WriteLine("Done");
		}
	}
}