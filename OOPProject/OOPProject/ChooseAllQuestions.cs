using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPProject
{
    internal class ChooseAllQuestions:Question
    {
        #region Properties
        //This List includes available options of choose all questions
       public List<string> ChooseAllOptions { get; set; }

        //This List includes indecies of correct options of choose all questions
       public List<int> IndexOfCorrectOptions { get; set; }
        #endregion

        #region Constructor
        public ChooseAllQuestions(string Header, string Body, string Category, int Mark, List<string> ChooseOptions, List<int> IndexOfOptions)
           : base(Header, Body, Category, Mark)
        {
            this.ChooseAllOptions = ChooseOptions;
            this.IndexOfCorrectOptions = IndexOfOptions;
        }
        #endregion

        #region Methods
        public override void QuestionInfo()
        {
            Console.WriteLine($"Question Header : {Header}");
            Console.WriteLine($"Question Body : {Body}");
            Console.WriteLine($"Question category : {Category}");
            Console.WriteLine($"Question mark : {Mark}");
            Console.WriteLine($"Available options for this question");
            for (int i = 0; i < ChooseAllOptions.Count; i++)
                Console.WriteLine($"Option {i + 1}. {ChooseAllOptions[i]} ");
            Console.WriteLine($"Correct options for this question : ");
            foreach (var index in IndexOfCorrectOptions)
                Console.WriteLine($" Option {index + 1}. {ChooseAllOptions[index]}");
            Console.WriteLine();
        }

        //This method check if answer that user entered equals to the correct answer or not
        public override bool IsAnswerCorrect(Answer answer)
        {
            // Parse the user’s selected option indices from the answer string
            var selectedIndices = answer.InputAnswer.Split(',')
                .Select(part => part.Trim())
                .Where(part => int.TryParse(part, out _)) // Ensure valid integers
                .Select(int.Parse)
                .Select(index => index - 1) // Convert to zero-based index
                .ToList();

            // Sort and compare the selected indices with the correct option indices
            selectedIndices.Sort();
            var sortedCorrectIndices = IndexOfCorrectOptions.OrderBy(i => i).ToList();

            return selectedIndices.SequenceEqual(sortedCorrectIndices);
        }

        //New methods are added

        public override void Display()
        {
            Console.WriteLine($"{Header}: ");
            Console.WriteLine($"(Choose All correct answers) : {Body}  ");
            for (int i = 0; i < ChooseAllOptions.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {ChooseAllOptions[i]}");
            }

        }

        public override Answer GetAnswer()
        {
            Console.WriteLine();
            Console.Write("Enter the numbers of your choices  ");
            string response = Console.ReadLine();
            return new Answer(response);

        }

        #endregion
    }
}
