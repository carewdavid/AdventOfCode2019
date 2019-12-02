using System;
using System.Collections.Generic;
namespace AOC
{
	class Day2
	{
		public static void Solve(string[] args)
		{
			var input = ReadInput();
			VM(input);

		}

		static int VM(List<int> program)
		{
			int pc = 0;
			int operand1;
			int operand2;
			int resultaddr;
			while(true)
			{
				//Console.WriteLine(string.Join(",", program.ToArray()));
				int op = program[pc];
				switch(op)
				{
					case 1:
						operand1 = program[pc + 1];
						operand2 = program[pc + 2];
						resultaddr = program[pc + 3];
						program[resultaddr] = program[operand1] + program[operand2];
						pc += 4;
						break;
					case 2:
						operand1 = program[pc + 1];
						operand2 = program[pc + 2];
						resultaddr = program[pc + 3];
						program[resultaddr] = program[operand1] * program[operand2];
						pc += 4;
						break;
					case 99:
						Console.WriteLine(program[0]);
						return 0;
				}
			}
		}

		static List<int> ReadInput()
		{
			string text = System.IO.File.ReadAllText("gravityassist.txt");
			//string text = "1,9,10,3,2,3,11,0,99,30,40,50";
			var ints = new List<int>();
			foreach(string i in text.Split(","))
			{
				ints.Add(int.Parse(i));
			}
			return ints;
		}

	}
}
