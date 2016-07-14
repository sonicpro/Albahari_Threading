<Query Kind="Program">
  <Namespace>System.Threading</Namespace>
</Query>

static void Main()
{
		Thread t = new Thread(Go);
		t.Start();
		// Join forces the main thread to waint until t finishes.
		t.Join();
		Console.WriteLine("Threaf t has ended!"); // Printed only after the "y"s.
}

static void Go()
{
	for (int i = 0; i < 1000; i++) Console.Write("y");
}
