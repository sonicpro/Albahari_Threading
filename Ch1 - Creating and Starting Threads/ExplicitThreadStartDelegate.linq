<Query Kind="Program">
  <Namespace>System.Threading</Namespace>
</Query>

void Main()
{
	// The ThreadStart delegate is defined as "public delegate void ThreadStart();".
	Thread t = new Thread (new ThreadStart (Go));
	
	t.Start(); // Run Go() on the new thread.
	Go(); // Simultaneously run Go() in the main thread.
}

// Define other methods and classes here
static void Go()
{
	Console.WriteLine("hello!");
}

