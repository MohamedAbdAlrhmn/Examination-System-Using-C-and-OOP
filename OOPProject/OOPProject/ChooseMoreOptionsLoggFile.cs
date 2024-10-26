using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    internal class ChooseMoreOptionsLoggFile:List<ChooseAllQuestions>
    {
        //This class used to Logg questions from Type of Choose More Options Questions into text file

        #region Properties
        //This property include path of LogFile that includes Questions inside 
        public string PathOfLogFile { get; set; }
        #endregion

        #region Constructor
        public ChooseMoreOptionsLoggFile(string logFilePath)
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
        public new void Add(ChooseAllQuestions ChooseMoreQuestion)
        {
            base.Add(ChooseMoreQuestion);
            LogChooseMoreOptionsToFile(ChooseMoreQuestion);
        }

        public void LogChooseMoreOptionsToFile(ChooseAllQuestions ChooseMoreOptionquestion)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(PathOfLogFile, true))
                {

                    writer.WriteLine($"Header: {ChooseMoreOptionquestion.Header}");
                    writer.WriteLine($"Body: {ChooseMoreOptionquestion.Body}");
                    writer.WriteLine($"Marks: {ChooseMoreOptionquestion.Mark}");
                    writer.WriteLine($"Category: {ChooseMoreOptionquestion.Category}");
                    writer.WriteLine($"Available options for this question :");
                    for (int i = 0; i < ChooseMoreOptionquestion.ChooseAllOptions.Count; i++)
                        writer.WriteLine($"Option {i + 1}. {ChooseMoreOptionquestion.ChooseAllOptions[i]} ");
                    writer.WriteLine($"Correct options for this question : ");
                    foreach (var index in ChooseMoreOptionquestion.IndexOfCorrectOptions)
                        writer.WriteLine($" Option {index + 1}. {ChooseMoreOptionquestion.ChooseAllOptions[index]}");
                    writer.WriteLine();
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
