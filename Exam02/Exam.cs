using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal abstract class Exam
	{
        public int NumberOfQuestion { get; set; }
        public Subject subject { get; set; }
        public abstract void MCQ();


        protected Exam()
        {
            
        }

        protected Exam(int noq,Subject sub)
        {
            subject = sub;
            NumberOfQuestion = noq;
        }
    }
}
