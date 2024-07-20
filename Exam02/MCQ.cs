using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class MCQ : Question
	{

		public Answer[]? AnswerList { get; set; }

		//public MCQ(string header,string body,int mark, Answer[] ans):base(header,body,mark,ans)
		//{

		//}



		public override void Questions(int qn)
		{
			AnswerList = new Answer[qn];
			int m;

			for (int i = 0; i < AnswerList?.Length; i++)
			{
				Console.WriteLine($"enter header question {i + 1}");
				Header = Console.ReadLine();

				Console.WriteLine($"enter question answer {i + 1}");
				Body = Console.ReadLine();

				Console.WriteLine($"enter mark question {i + 1}");
				int.TryParse(Console.ReadLine(), out m);
				Mark = m;

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
