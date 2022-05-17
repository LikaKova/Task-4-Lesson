using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextReadTask

	{
		class ReadText
		{
			static void Main(string[] args)

			{
				string writeText = "ENV=QA";
				File.WriteAllText("input.txt", writeText);

				string readText = File.ReadAllText("input.txt");
				Console.WriteLine(readText);

			string writeTextNew = "I will run test on " + writeText;
			File.WriteAllText("output.txt", writeTextNew);

			string readTextNew = File.ReadAllText("output.txt");
			Console.WriteLine(readTextNew);



			}

		}
	}

