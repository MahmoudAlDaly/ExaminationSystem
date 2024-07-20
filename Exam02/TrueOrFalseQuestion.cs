using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class TrueOrFalseQuestion  : Question 
	{

        
        public Answer[]? AnswerList { get; set; }

        public TrueOrFalseQuestion()
		{

		}

        public TrueOrFalseQuestion(int a)
        {
            AnswerList = new Answer[a];
        }


        public override void Questions(int a)
		{
			
			for (int i = 0; i < AnswerList?.Length; i++)
			{
				Console.WriteLine($"enter header question {1}");
				Header = Console.ReadLine();

				Console.WriteLine($"enter body question {1}");
				Body = Console.ReadLine();

				Console.WriteLine($"enter mark question {1}");
				Mark = int.Parse(Console.ReadLine());

				AnswerList[i].ID = i;
				AnswerList[i].Name = Console.ReadLine();
			}

			Console.WriteLine("True False");
		}

	}
}
	
	
	

   
