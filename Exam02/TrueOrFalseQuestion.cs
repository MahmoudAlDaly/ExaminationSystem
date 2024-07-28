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
        public bool Answer { get; set; }
		
		public TrueOrFalseQuestion()
		{

		}

        
        public TrueOrFalseQuestion(int size) 
        {
			Header = "True Or False";
            AnswerList = new Answer[size];
        }


        public override void Questions()
		{
			for (int i = 0; i < AnswerList?.Length; i++)
			{
				Console.WriteLine($"{Header}");

				Console.WriteLine($"enter body question {i+1}");
				Body = Console.ReadLine();

				Console.WriteLine($"enter question answer {i + 1}");
				Answer = bool.Parse(Console.ReadLine());

				Console.WriteLine($"enter mark question {i + 1}");
				Mark = int.Parse(Console.ReadLine());

				

				AnswerList[i].ID = i;
				AnswerList[i].Name = Answer.ToString();
			}

			Console.WriteLine("True False");
		}

	}
}
	
	
	

   
