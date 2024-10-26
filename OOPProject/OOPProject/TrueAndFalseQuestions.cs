using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    internal class TrueAndFalseQuestions:Question
    {
        #region Properties
        //Property for correct Answer
        public bool RealAnswer { get; set; }
        #endregion

        #region Constructor
        //Constructor 
        public TrueAndFalseQuestions()
        {
            
        }
        public TrueAndFalseQuestions(string Header, string Body, string Category, int mark, bool _realAnswer) :
            base(Header, Body, Category, mark)

        {
            this.RealAnswer = _realAnswer;
        }
        #endregion

        #region Methods
        //This method display information of True/False Question
        public override void QuestionInfo()
        {
            Console.WriteLine($"Question Header : {Header}");
            Console.WriteLine($"Question Body : {Body}");
            Console.WriteLine($"Question category : {Category}");
            Console.WriteLine($"Question mark : {Mark}");
            Console.WriteLine($"Question Correct Answer : {RealAnswer}");
            Console.WriteLine();
        }

        //This method check if answer that user entered equals to correct answer or not
        public override bool IsAnswerCorrect(Answer answer)
        {
            return bool.TryParse(answer.InputAnswer, out bool userAnswer) && userAnswer == RealAnswer;
        }

        //New methods are added
        public override void Display()
        {
            Console.WriteLine($"{Header} :");
            Console.WriteLine($"{Body} (True or flase) :");
        }

        public override Answer GetAnswer()
        {
            Console.Write("Enter True or False: ");
            string response = Console.ReadLine();
            return new Answer(response);

        }
        #endregion
    }
}
