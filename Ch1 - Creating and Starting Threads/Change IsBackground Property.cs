using System;
using System.Threading;

class PriorityTest
{
    static void Main (string[] args)
    {
	Thread worker = new Thread ( () => Console.ReadLine() );
	// Exit immediately and terminate ReadLine() been provided and argument in the command line.
	if (args.Length > 0)
	{
	    worker.IsBackground = true;
	}

	worker.Start();
    }
}
