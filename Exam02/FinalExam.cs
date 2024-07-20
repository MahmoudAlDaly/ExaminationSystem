using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class FinalExam : Exam
	{
        public FinalExam(int qn,Subject sub) : base(qn,sub)
        {
			NumberOfQuestion = qn;
			subject = sub;

		}

        public FinalExam()
        {
            
        }
        public override void MCQ()
		{
			Question question = new MCQ();
			question.Questions(NumberOfQuestion);
		}

		public void TFQuestion()
		{

			Question question = new TrueOrFalseQuestion(NumberOfQuestion);
			question.Questions(NumberOfQuestion);
		}
	}
}
