using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
	class Program
	{
		static int score = 0;
		static int Lives = 3;
		static bool Alive = true; // true if alive, false if dead


		static void Main(string[] args)
		{
			Console.WriteLine("Conditionals2");

			Lives = Lives - 1; // player lost life
			if (Lives < 0)
			{
				Lives = 0; // range check it to 0
				Alive = false;

			}


			if (Lives == 0)
			{

				Alive = false;

			}

			Console.ReadKey(true);
		}


	}
}
