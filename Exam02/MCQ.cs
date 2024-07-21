using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class MCQ : Question
	{
        public MCQ()
        {
            
        }

        public MCQ(Answer[] answers, int size) : base(answers)
		{
			Header = "choose one answer";
			AnswerList = new Answer[size];
		}



		public override void Questions()
		{

			for (int i = 0; i < AnswerList?.Length; i++)
			{
				
				Console.WriteLine($"enter question  {i + 1}");
				Body = Console.ReadLine();

				Console.WriteLine($"enter mark question {i + 1}");
				int m;
				int.TryParse(Console.ReadLine(), out m);
				Mark = m;

				for (int j = 0; j < 2; j++)
				{
					Console.WriteLine($"enter answers {j + 1}");

				}

				if (AnswerList != null)
				{
					AnswerList[i].ID = i;
					AnswerList[i].Name = Console.ReadLine();
				}
			}

			Console.WriteLine("MCQ");
        }
	}
}
