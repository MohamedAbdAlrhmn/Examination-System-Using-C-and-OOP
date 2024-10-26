using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OOPProject
{
    internal class PracticeExam<TQuestion, TAnswer> : Exam<TQuestion, TAnswer>
        where TQuestion : Question
        where TAnswer : Answer
    {
        #region Constructor
        public PracticeExam(int time, int numberOfQuestions, Subject examSubject)
            : base(time, numberOfQuestions, examSubject)
        {
        } 
        #endregion

        #region Methods
        //This Method to show exam questions and its answers to make students practise on questions before final exam
        public override void ShowExamInfo()
        {
            Console.WriteLine("Practice Exam Model Answer:");
            Console.WriteLine("-----------------------------------------------");
            foreach (var question in QuestionAnswerDictionary.Keys)
            {
                question.QuestionInfo();
            }
        }

        //This method Notify Students or users That Exam Started
        public override void NotifyStudents()
        {
            base.NotifyStudents();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine($"Notification for students: Practice Exam on {ExamSubject.Name} has been Finshied ");
            Console.WriteLine("-------------------------------------------------------------------------------");
        }

        public override void StartExamTimer()
        {
            examTimer.Start();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Practise Exam started. Timer is running...");
            Console.WriteLine("-----------------------------------------------------");
        }

        public override void OnExamTimeExceeded(object sender, ElapsedEventArgs e)
        {
            examTimer.Stop();
            Mode = ExamMode.Finished;
            NotifyStudents();
        }
        #endregion


    }
}
