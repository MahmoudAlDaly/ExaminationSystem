using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal abstract class Question : ICloneable
	{
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        //public Answer[]? AnswerList { get; set; }

  //      protected Question(int lenght)
  //      {

		//}

        protected Question()
        {
            
        }

       
        public abstract void Questions(int qn);

		public object Clone()
		{
			throw new NotImplementedException();
		}
	}
}
