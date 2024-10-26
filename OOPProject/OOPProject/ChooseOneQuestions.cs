using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    internal class ChooseOneQuestions : Question
    {
        #region Properties
        //List that includes options of choose one question that we will choose from it
        public List<string> QuestionOptions { get; set; }
        //Index of Correct option from option List
        public int IndexOfCorrectOption { get; set; }
        #endregion

        #region Constructor
        //constructor
        public ChooseOneQuestions(string Header, string Body, string Category, int Mark, List<string> Options, int OptionIndex)
            : base(Header, Body, Category, Mark)
        {
            this.QuestionOptions = Options;
            this.IndexOfCorrectOption = OptionIndex;
        }
        #endregion


        #region Methods
        //This method display information about Choose one option questions
        public override void QuestionInfo()
        {
            Console.WriteLine($"Question Header : {Header}");
            Console.WriteLine($"Question Body : {Body}");
            Console.WriteLine($"Question category : {Category}");
            Console.WriteLine($"Question mark : {Mark}");
            Console.WriteLine($"Available options for this question");
            for (int i = 0; i < QuestionOptions.Count; i++)
            {
                Console.WriteLine($"option {i + 1}. {QuestionOptions[i]} ");
            }
            Console.WriteLine($"Correct option for this question :  {QuestionOptions[IndexOfCorrectOption]}");
            Console.WriteLine();
        }

        //This method check if answer that user entered equals to the correct answer or not
        public override bool IsAnswerCorrect(Answer answer)
        {
            if (int.TryParse(answer.InputAnswer, out int userOptionIndex))
            {
                // Check if the provided answer matches the correct option index
                return userOptionIndex -1 == IndexOfCorrectOption;
            }
            return false;
        }

        //New methods are added
        public override void Display()
        {
            Console.WriteLine($"{Header}: ");
            Console.WriteLine($"(Choose one answer only) : {Body} ");
            for (int i = 0; i < QuestionOptions.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {QuestionOptions[i]}");
            }
        }

        public override Answer GetAnswer()
        {

            Console.Write("Enter the number of your choice: ");
            string response = Console.ReadLine();


            return new Answer(response);
        }
        #endregion
    }
}