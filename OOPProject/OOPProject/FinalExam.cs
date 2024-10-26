using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OOPProject
{
    internal class FinalExam<TQuestion, TAnswer> : Exam<TQuestion, TAnswer>
        where TQuestion : Question
        where TAnswer : Answer
    {
        #region Property
        
        #endregion

        #region Constructor
        public FinalExam(int time, int numberOfQuestions, Subject examSubject)
            : base(time, numberOfQuestions, examSubject)
        {
            
        }
        #endregion

        #region Methods
        //This method show Questions only for students to answer on it on the exam and start Exam Timer
        public override void ShowExamInfo()
        {
            Console.WriteLine("Final Exam Model Answer:");
            Console.WriteLine("-----------------------------------------------");
            foreach (var question in QuestionAnswerDictionary.Keys)
            {
                question.QuestionInfo();
            }
            
        }

       

        //This Method Notify student that Final Exam has been ended
        public override void NotifyStudents()
        {
            Console.WriteLine($" Notification for student: Final Exam on {ExamSubject.Name} has been ended .");
        }

        public override void StartExamTimer()
        {
            examTimer.Start();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Final Exam started. Timer is running...");
            Console.WriteLine("-----------------------------------------------------");
        }

        //This Method for Stop exam timer and make Exam Mode be finished and notify student that exam has been ended
        public override void OnExamTimeExceeded(object sender, ElapsedEventArgs e)
        {
            examTimer.Stop();
            Mode = ExamMode.Finished;
            NotifyStudents();
        }


        #endregion

    }
}
