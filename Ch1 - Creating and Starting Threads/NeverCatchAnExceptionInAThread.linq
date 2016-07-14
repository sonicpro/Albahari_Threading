<Query Kind="Program" />

void Main()
{
	try
	{
		new Thread (Go).Start();
	}
	catch (Exception ex)
	{
		// We'll never get here!
		Console.WriteLine("Exception!");
	}
}

// Define other methods and classes here
static void Go() { throw null; } // Throws a NullReferenceException.