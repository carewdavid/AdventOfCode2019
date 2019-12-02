using System;
using System.Collections.Generic;
namespace AOC
{
	class Day2
	{
		public static void Solve(string[] args)
		{
			var input = ReadInput();
			for(int noun = 0; noun < 100; noun++)
			{
				for(int verb = 0; verb < 100; verb++)
				{
					//Run each iteration with a fresh copy of the program
					var program = new List<int>(input);
					program[1] = noun;
					program[2] = verb;
					int result = VM(program);
					if(result == 19690720)
					{
						Console.WriteLine(100 * noun + verb);
						break;
					}
				}
			}

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
						return program[0];
					default:
						Console.Error.WriteLine($"Unknown opcode {op}");
						return -1;
				}
			}
		}

		static List<int> ReadInput()
		{
			string text = System.IO.File.ReadAllText("gravityassist.txt");
			var ints = new List<int>();
			foreach(string i in text.Split(","))
			{
				ints.Add(int.Parse(i));
			}
			return ints;
		}

	}
}
