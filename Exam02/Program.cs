namespace Exam02
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Subject sub = new Subject(1, "c#");
			//Exam exam = new PracticalExam(2,sub);
			//sub.CreateExam(exam);


			Subject subject = new Subject(1,"c#");
			subject.CreateExam();



		}
	}
}
