using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class PracticalExam : Exam
	{


        public PracticalExam() 
        {
            
            
        }

        
        public override void MCQ()
		{
            Console.WriteLine("how many question ?");
            int q;
			int.TryParse(Console.ReadLine(), out q);
			NumberOfQuestion = q;
			Question mcq = new MCQ(NumberOfQuestion);
			mcq.Questions();

		}


	}
}
