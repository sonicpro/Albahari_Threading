<Query Kind="Program">
  <Namespace>System.Threading</Namespace>
</Query>

void Main()
{
	// Thread.CurrentThread.Name = "main"; This causes invalid operation exception in LinqPad query.
	// LinkPad itself sets the name to "Main Query Thread".
	Thread worker = new Thread(Go);
	worker.Name = "worker";
	worker.Start();
	Go();
}

// Define other methods and classes here
static void Go()
{
	Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
}

