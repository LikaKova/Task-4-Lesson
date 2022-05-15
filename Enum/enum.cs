using System;

class Program
{
	enum Errors
	{
		Informational,    // 0
		Success,          // 1
		Redirection,      // 2
		ClientSide,       // 3
		ServerSide        // 4

	}

	public static void Main()
	{
		int myError = (int)Errors.Success;
		Console.WriteLine(myError);

		Errors myError1 = Errors.Success;
		Console.WriteLine(myError1);
	}
}

