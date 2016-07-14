<Query Kind="Program">
  <Namespace>System.Threading</Namespace>
</Query>

static void Main()
{
		new Thread (Go).Start();
		Go();
}

// Local variable cycles is kept separate for each of the threads.
static void Go()
	{
		for (int cycles = 0; cycles < 5; cycles++) Console.Write("?");
	}