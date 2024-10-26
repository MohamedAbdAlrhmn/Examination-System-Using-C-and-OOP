using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace OOPProject
{
    internal abstract class Exam<TQuestion, TAnswer> : ICloneable, IComparable<Exam<TQuestion, TAnswer>>
         where TQuestion : Question
         where TAnswer : Answer
    {

        #region Properties
        public int ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        //This dictionary includes Questions and user's Answers of these questions 
        public Dictionary<TQuestion, TAnswer> QuestionAnswerDictionary { get; set; }
        //This Property for Question Subject
        public Subject ExamSubject { get; set; }
        public ExamMode Mode { get; set; }
        public ExamEventNotifier Notifier { get; set; }
        //Exam timer to track Exam time
        public Timer examTimer;
        #endregion

        #region Constructor
        protected Exam(int time, int numberOfQuestions, Subject _examSubject)
        {
            ExamTime = time;

            NumberOfQuestions = numberOfQuestions;

            QuestionAnswerDictionary = new Dictionary<TQuestion, TAnswer>();

            ExamSubject = _examSubject;

            //This default value of Exam Mode and means that Exam not Started for yet
            Mode = ExamMode.Queued;
            
            Notifier = new ExamEventNotifier();

            examTimer = new Timer(time * 60 * 1000); // Time in milliseconds
            examTimer.Elapsed += OnExamTimeExceeded;
            examTimer.AutoReset = false;
        }
        #endregion


        #region Methods
        //This Method will implemented in derived classes to show Information about exam type
        public abstract void ShowExamInfo();

        //This method will notify students if exam mode chanaged and exam mode changed from queued to start
        public virtual void NotifyStudents()
        {
            Notifier.Mode = ExamMode.Starting;
            Notifier.ModeChanged += (mode) => Console.WriteLine($"Exam mode changed to: {mode}");
        }


        public object Clone()
        {
            return MemberwiseClone();
        }

        //This Method Compares Exam Time
        public int CompareTo(Exam<TQuestion, TAnswer> other)
        {
            return ExamTime.CompareTo(other.ExamTime);
        }

        public override string ToString()
        {
            return $"{ExamSubject} Exam - Time: {ExamTime} mins, Questions: {NumberOfQuestions}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Exam<TQuestion, TAnswer> other)
            {
                return ExamTime == other.ExamTime && NumberOfQuestions == other.NumberOfQuestions && ExamSubject.Equals(other.ExamSubject);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ExamTime, NumberOfQuestions, ExamSubject);
        }


        //This method check if answer of user is equal to correct answer or not by using IsAnswerCorrect method inside three types of questions
        public bool IsQuestionCorrect(TQuestion question, TAnswer answer)
        {
            // Check if the provided question and answer are valid and not null
            if (question == null || answer == null)
            {
                throw new ArgumentNullException("Question or answer cannot be null.");
            }

            return question.IsAnswerCorrect(answer);
        }

        //This Method for calculating how many questions that user answered correct and return total mark of his Exam
        public double CalculateGrade()
        {
            int totalMarks = 0;
            int obtainedMarks = 0;

            foreach (var entry in QuestionAnswerDictionary)
            {
                totalMarks += entry.Key.Mark;
                if (entry.Key.IsAnswerCorrect(entry.Value))
                {
                    obtainedMarks += entry.Key.Mark;
                }
            }

            return (double)obtainedMarks / totalMarks * 100;
        }

        //New Method added

        //This method Show Questions to student to answer questions
        public void TakeExam()
        {

            Console.WriteLine($"Time is: {ExamTime} minutes");
            StartExamTimer();
            foreach (var x in QuestionAnswerDictionary.Keys)
            {
                x.Display();
                TAnswer answer = (TAnswer)x.GetAnswer();
                QuestionAnswerDictionary[x] = answer;
            }
        }

        //This Method for make exam timer to start 
        public abstract void StartExamTimer();


        //This Method for Stop exam timer and make Exam Mode be finished and notify student that exam has been ended
        public abstract void OnExamTimeExceeded(object sender, ElapsedEventArgs e); 
        #endregion

    }
}
