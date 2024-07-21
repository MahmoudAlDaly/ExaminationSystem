using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class FinalExam : Exam
	{
        public FinalExam(int questionCount, Subject subject, TimeOnly time) : base(questionCount,subject,time)
        {
			NumberOfQuestion = questionCount;
			Subject = subject;
			Time = time;

		}

        public FinalExam()
        {
            
        }
        public override void MCQ()
		{
			Question question = new MCQ();
			question.Questions();
		}

		public void TFQuestion()
		{

			Question question = new TrueOrFalseQuestion();
			question.Questions();
		}
	}
}
