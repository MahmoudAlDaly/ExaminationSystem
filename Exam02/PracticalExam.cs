using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class PracticalExam : Exam
	{


        public PracticalExam(int qn, Subject sub) : base(qn, sub) 
        {
            NumberOfQuestion = qn;
			subject = sub;
        }

        public PracticalExam()
        {
            
        }
        public override void MCQ()
		{
			Question trueOrFalseQuestion = new TrueOrFalseQuestion(NumberOfQuestion);
			trueOrFalseQuestion.Questions(NumberOfQuestion);
		}


	}
}
