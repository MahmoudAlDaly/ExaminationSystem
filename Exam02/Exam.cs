using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal abstract class Exam
	{
        public TimeOnly Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public Subject? Subject { get; set; }

        public abstract void MCQ();


        protected Exam()
        {
            
        }

        
    }
}
