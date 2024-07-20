using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class Answer
	{
        public int ID { get; set; }
		public string? Name { get; set; }

        public Answer()
        {
            
        }

        public Answer(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
