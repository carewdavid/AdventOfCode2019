using System;

namespace AOC
{
    class Day1
    {
        public static void Solve(string[] args)
        {
		int totalFuel = 0;
		string[] lines = System.IO.File.ReadAllLines("modulemass.txt");
		foreach (string module in lines)
		{
			int mass = int.Parse(module);
			//Part 1
			totalFuel += ModuleFuel(mass);
		}
		Console.WriteLine(totalFuel);
        }

	static int ModuleFuel(int mass)
	{
		int fuel = (mass / 3) - 2;

		if(fuel <= 0)
		{
			return 0;
		}
		else
		{
			return fuel + ModuleFuel(fuel);
		}
	}

    }
}
