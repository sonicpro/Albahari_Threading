<Query Kind="Program">
  <Namespace>System.Threading</Namespace>
</Query>

void Main()
{
	// The lambda takes "unit" and executes Print() in its body.
	Thread t = new Thread ( () => Print ("Hello from t!") );
	t.Start(); // Run Go() on the new thread.
}

// Define other methods and classes here
static void Print(string message)
{
	Console.WriteLine(message);
}

