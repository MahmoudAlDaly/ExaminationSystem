using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class MCQ : Question
	{
        public int QNumber { get; set; }
        public int Degree { get; set; }
        public MCQ()
        {
            
        }

        public MCQ(int size) 
		{
			QNumber = size;
			Header = "choose one answer";
			AnswerList = new Answer[size];
			Degree = default;
		}



		public override void Questions()
		{
			Answer[] inputAnswer = new Answer[3];
			int x;

			for (int i = 0; i < QNumber; i++)
			{
				Console.WriteLine(Header);
				Console.WriteLine($"enter question  {i + 1}");
				Body = Console.ReadLine();

				Console.WriteLine($"enter mark question {i + 1}");
				int m;
				int.TryParse(Console.ReadLine(), out m);
				Mark = m;

				for (int j = 0; j < 3; j++)
				{
						Console.WriteLine($"enter 3 answers only ");
						Console.Write($"{j+1} -  ");
						inputAnswer[j] = new Answer();
						inputAnswer[j].ID = j+1;
						inputAnswer[j].Name = Console.ReadLine();
				}

				Console.WriteLine($"choose question {i + 1} answer");
				int a;
				int.TryParse(Console.ReadLine(), out a);

				AnswerList[i] = new Answer();
				AnswerList[i].ID = i+1;
				AnswerList[i].Name = Console.ReadLine();

				Console.WriteLine("user answers");
				int.TryParse(Console.ReadLine(), out x);
				if ((x-1) == AnswerList[i].ID)
				{
					Degree += Mark;
				}

			}

			//for (int k = 0; k < AnswerList?.Length; k++)
			//{
			//	Console.WriteLine($"choose question {k + 1} answer");
			//	int a;
			//	int.TryParse(Console.ReadLine(), out a);

			//	AnswerList[k] = new Answer();
			//	AnswerList[k].ID = k;
			//	AnswerList[k].Name = Console.ReadLine();
			//	
			//}

			Console.WriteLine(Degree);



			Console.WriteLine("MCQ");
        }
	}
}
