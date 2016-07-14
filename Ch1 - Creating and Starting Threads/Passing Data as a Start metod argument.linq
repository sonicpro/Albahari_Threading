<Query Kind="Program">
  <Namespace>System.Threading</Namespace>
</Query>

void Main()
{
	// The constructor takes ParameterizedThreadStart(object obj) delegate instead of ThreadStart() delegate
	// in "Passing Data to a Thread through Lambda.linq".
	Thread t = new Thread (Print);
	t.Start("Hello from t!"); // Run Go() on the new thread.
}

// Define other methods and classes here
static void Print(object messageObj)
{
	string message = (string)messageObj; // We need the cast here.
	Console.WriteLine(message);
}

