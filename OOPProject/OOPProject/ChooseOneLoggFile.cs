using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{

    internal class ChooseOneLoggFile:List<ChooseOneQuestions>
    {
        //This class used to Logg questions from Type of Choose One Options Questions into text file

        #region Properties
        //This property include path of LogFile that includes Questions inside 
        public string PathOfLogFile { get; set; } 
        #endregion

        #region Constructor
        public ChooseOneLoggFile(string logFilePath)
        {
            // Ensure the directory exists
            var directory = Path.GetDirectoryName(logFilePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            PathOfLogFile = logFilePath;
        } 
        #endregion

        #region Methods
        // Override Add method to log the question to a file
        public new void Add(ChooseOneQuestions ChooseOneQuestion)
        {
            base.Add(ChooseOneQuestion);
            LogChooseOneToFile(ChooseOneQuestion);
        }


        public void LogChooseOneToFile(ChooseOneQuestions ChooseOnequestion)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(PathOfLogFile, true))
                {

                    writer.WriteLine($"Header: {ChooseOnequestion.Header}");
                    writer.WriteLine($"Body: {ChooseOnequestion.Body}");
                    writer.WriteLine($"Marks: {ChooseOnequestion.Mark}");
                    writer.WriteLine($"Category: {ChooseOnequestion.Category}");
                    writer.WriteLine($"Available options for this question");
                    for (int i = 0; i < ChooseOnequestion.QuestionOptions.Count; i++)
                    {
                        writer.WriteLine($"option {i + 1}. {ChooseOnequestion.QuestionOptions[i]} ");
                    }
                    writer.WriteLine($"Correct option for this question :  {ChooseOnequestion.QuestionOptions[ChooseOnequestion.IndexOfCorrectOption]}");
                    writer.WriteLine("============================================");
                    writer.WriteLine();
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        public void DisplayQuestionsInfo()
        {
            foreach (var question in this)
            {
                question.QuestionInfo(); // Assuming QuestionInfo() method is defined in the Question class or its derived classes
                Console.WriteLine("============================================");
            }
        } 
        #endregion
    }
}
