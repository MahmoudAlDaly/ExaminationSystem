using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
	internal class Subject
	{
        public int Id { get; set; }
		public string Name { get; set; }

        public Exam Exam { get; set; }
        public Subject(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public void CreateExam()
        {
            Console.WriteLine("choose exam ==>   1 final / 2 practical");
            int exam;
            int.TryParse(Console.ReadLine(),out exam);

			if (exam == 1)
            {
				Exam final = new FinalExam();
                final.MCQ();
                FinalExam finalExam = new FinalExam();
                finalExam.TFQuestion();
			}
            else
            {
                Exam practical = new PracticalExam();
                practical.MCQ();
            }
            
            

		}
    }
}
