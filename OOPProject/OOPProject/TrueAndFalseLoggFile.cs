using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    internal class TrueAndFalseLoggFile:List<TrueAndFalseQuestions>
    {
        //This class used to Logg questions from Type of True/False Questions into text file

        #region Properties
        //This property include path of LogFile that includes Questions inside 
        public string PathOfLogFile { get; set; }
        #endregion

        #region Constructor
        public TrueAndFalseLoggFile(string logFilePath)
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
        public new void Add(TrueAndFalseQuestions TandFQuestion)
        {
            base.Add(TandFQuestion);
            LogTandFQuestionToFile(TandFQuestion);
        }

        public void LogTandFQuestionToFile(TrueAndFalseQuestions TrueAndFalsequestion)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(PathOfLogFile, true))
                {

                    writer.WriteLine($"Header: {TrueAndFalsequestion.Header}");
                    writer.WriteLine($"Body: {TrueAndFalsequestion.Body}");
                    writer.WriteLine($"Marks: {TrueAndFalsequestion.Mark}");
                    writer.WriteLine($"Category: {TrueAndFalsequestion.Category}");
                    writer.WriteLine($"Question Correct Answer : {TrueAndFalsequestion.RealAnswer}");
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
