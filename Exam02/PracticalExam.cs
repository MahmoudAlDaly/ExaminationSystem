using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class PracticalExam : Exam
	{


        public PracticalExam(int questionCount, Subject subject,TimeOnly time) : base(questionCount, subject,time) 
        {
            NumberOfQuestion = questionCount;
			Subject = subject;
            Time = time;
        }

        public PracticalExam()
        {
            
        }
        public override void MCQ()
		{
			Question mcq = new MCQ();
			mcq.Questions();
		}


	}
}
