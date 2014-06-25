using System;
using System.Linq;

namespace Part2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			LetterCounter ('i', "I love biscuits and gravy. It’s the best breakfast ever.");
			LetterCounter ('n', "Never gonna give you up. Never gonna let you down.");
			LetterCounter ('s', "Sally sells seashells down by the seashore. She’s from Sussex.");
		}

		static void LetterCounter(char letter, string instring){
			char letterUp = Char.ToUpper (letter);
			char letterDown = Char.ToLower (letter);
			//hold number of instances of uppercase and lowercase letter
			int upper=0;
			int lower=0;
			//loop through input checking for uppercase instances
			for(int i=0;i<instring.Length;i++){
				if(letterUp==instring[i]){
					upper++;
				}
			}
			//loop through input checking for lowercase instances
			for(int i=0;i<instring.Length;i++){
				if(letterDown==instring[i]){
					lower++;
				}
			}

			Console.WriteLine ("Input: "+instring);
			Console.WriteLine ("Number of lowercase "+letter+"s found: "+lower);
			Console.WriteLine ("Number of uppercase "+letter+"s found: "+upper);
			Console.WriteLine ("Total number of "+letter+"s found: "+(upper+lower));




			Console.WriteLine (lower);
		}
	}
}
