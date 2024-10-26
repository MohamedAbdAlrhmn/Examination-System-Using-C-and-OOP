using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;

namespace OOPProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Adding Questions With Correct Answers
            ////Make Samples of Questions and put it in a Log File

            ////Create object from QuestionList
            //string TrueFalsePath = @"E:\مبادره رواد مصر الرقميه\C#\C# Project\TrueAndFalseQuestion_LogFile.txt";
            //string ChooseOnePath = @"E:\مبادره رواد مصر الرقميه\C#\C# Project\ChooseOneQuestion_LogFile.txt";
            //string ChooseMorePath = @"E:\مبادره رواد مصر الرقميه\C#\C# Project\ChooseMoreOption_LogFile.txt";
            //TrueAndFalseLoggFile TrueFalseQuestionList = new TrueAndFalseLoggFile(TrueFalsePath);
            //ChooseOneLoggFile ChooseOneOptionQuestionList = new ChooseOneLoggFile(ChooseOnePath);
            //ChooseMoreOptionsLoggFile ChoosemoreOptionQuestionList = new ChooseMoreOptionsLoggFile(ChooseMorePath);

            ////string LoggFile = @"E:\مبادره رواد مصر الرقميه\C#\C# Project\Question_LogFile.txt";
            ////QuestionList ListOfQuestions = new QuestionList(LoggFile);

            ////Create objects of True/False Questions 
            //TrueAndFalseQuestions Q1 = new TrueAndFalseQuestions("This is a true or false question.", "Is Python a statically typed language?", "Programming Languages", 5, false);
            //TrueAndFalseQuestions Q2 = new TrueAndFalseQuestions("This is a true or false question.", "Does HTML stand for HyperText Markup Language?", "Web Develpoment", 5, true);
            //TrueAndFalseQuestions Q3 = new TrueAndFalseQuestions("This is a true or false question.", "Is JavaScript the same as Java?", "Programming Languages", 5, false);
            //TrueAndFalseQuestions Q4 = new TrueAndFalseQuestions("This is a true or false question.", "Does CSS stand for Cascading Style Sheets?", "Web Develpoment", 5, true);
            //TrueAndFalseQuestions Q5 = new TrueAndFalseQuestions("This is a true or false question.", "Is C# a derivative of C++?", "Programming Languages", 5, true);



            ////Create objects of ChooseOneQuestions
            //ChooseOneQuestions Q6 = new ChooseOneQuestions("Choose the correct answer.", "Which language is primarily used for web development?", "Web Develpoment", 5, new List<string> { "Python", "Java", "JavaScript", "C++" }, 2);
            //ChooseOneQuestions Q7 = new ChooseOneQuestions("Choose the correct answer.", "Which of the following is a database management system?", "Databse System", 5, new List<string> { "MySQL", "HTML", "CSS", "Python" }, 0);
            //ChooseOneQuestions Q8 = new ChooseOneQuestions("Choose the correct answer.", "What does RAM stand for?", "Programming Languages", 5, new List<string> { "Random Access Memory", "Read Access Memory", "Readily Available Memory", "Run Active Memory" }, 0);
            //ChooseOneQuestions Q9 = new ChooseOneQuestions("Choose the correct answer.", "Which language is used for creating Android apps ? ", "Mobile Development", 5, new List<string> { "Swift", "Kotlin", "PHP", "Ruby" }, 1);
            //ChooseOneQuestions Q10 = new ChooseOneQuestions("Choose the correct answer.", "Which of the following is a version control system?", "Version Control", 5, new List<string> { "Git", "Docker", "Jenkins", "Node.js" }, 0);

            ////Create objects of ChooseAllQuestions
            //ChooseAllQuestions Q11 = new ChooseAllQuestions("Select all that apply.", "Which of the following are programming languages?", "programming languages", 10, new List<string> { "Python", "HTML", "C#", "CSS" }, new List<int> { 0, 2 });
            //ChooseAllQuestions Q12 = new ChooseAllQuestions("Select all that apply.", "Which of the following are NoSQL databases?", "Databse System", 10, new List<string> { "MongoDB", "MySQL", "Cassandra", "PostgreSQL" }, new List<int> { 0, 2 });
            //ChooseAllQuestions Q13 = new ChooseAllQuestions("Select all that apply.", "Which of the following are frontend frameworks?", "Web Develpoment", 10, new List<string> { "React", "Angular", "Vue", "Django" }, new List<int> { 0, 1, 2 });
            //ChooseAllQuestions Q14 = new ChooseAllQuestions("Select all that apply.", "Which of the following are cloud service providers?", "Cloud systems", 10, new List<string> { "AWS", "Google Cloud", "Azure", "Oracle Cloud" }, new List<int> { 0, 1, 2, 3 });
            //ChooseAllQuestions Q15 = new ChooseAllQuestions("Select all that apply.", "Which of the following are considered as agile methodologies?", "Database System", 10, new List<string> { "Scrum", "Kanban", "Waterfall", "XP" }, new List<int> { 0, 1, 3 });

            ////Adding True/False Quesions to TrueFalseQuestionList
            //TrueFalseQuestionList.Add(Q1);
            //TrueFalseQuestionList.Add(Q2);
            //TrueFalseQuestionList.Add(Q3);
            //TrueFalseQuestionList.Add(Q4);
            //TrueFalseQuestionList.Add(Q5);

            //// Adding choose one option Quesions to ChooseOneOptionQuestionList
            //ChooseOneOptionQuestionList.Add(Q6);
            //ChooseOneOptionQuestionList.Add(Q7);
            //ChooseOneOptionQuestionList.Add(Q8);
            //ChooseOneOptionQuestionList.Add(Q9);
            //ChooseOneOptionQuestionList.Add(Q10);

            //// Adding choose many option Quesions to ChoosemoreOptionQuestionList
            //ChoosemoreOptionQuestionList.Add(Q11);
            //ChoosemoreOptionQuestionList.Add(Q12);
            //ChoosemoreOptionQuestionList.Add(Q13);
            //ChoosemoreOptionQuestionList.Add(Q14);
            //ChoosemoreOptionQuestionList.Add(Q15);


            ////Put these questions into List that called ListOfQuestions

            ////trueFalseQuestions.ForEach(q => TrueFalseQuestionList.Add(q));
            ////ChooseOneOptionQuestions.ForEach(q => ChooseOneOptionQuestionList.Add(q));
            ////ChooseMultipleChoices.ForEach(q => ChoosemoreOptionQuestionList.Add(q));


            //TrueFalseQuestionList.DisplayQuestionsInfo();
            //ChooseOneOptionQuestionList.DisplayQuestionsInfo();
            //ChoosemoreOptionQuestionList.DisplayQuestionsInfo(); 
            #endregion


            #region Test PractiseExam
            //Test Practice Exam

            //Create Exam's Subject that student will take
            Subject ProgLanguage = new Subject("ProgrammingLanguage", "CS50");

            //Create True and false Questions
            TrueAndFalseQuestions Q1 = new TrueAndFalseQuestions("This is a true or false question.", "Is Python a statically typed language?", "Programming Languages", 5, false);
            TrueAndFalseQuestions Q2 = new TrueAndFalseQuestions("This is a true or false question.", "Is JavaScript the same as Java?", "Programming Languages", 5, false);
            TrueAndFalseQuestions Q3 = new TrueAndFalseQuestions("This is a true or false question.", "Is C# a derivative of C++?", "Programming Languages", 5, true);

            //Logging True and False Questions of Practice Exam in SeparatedLoggFile
            string TrueFalsePath_PracticeExam = @"E:\مبادره رواد مصر الرقميه\C#\C# Project\TrueAndFalseQuestion_PracticeExamFile.txt";
            TrueAndFalseLoggFile TrueFalseQuestionList = new TrueAndFalseLoggFile(TrueFalsePath_PracticeExam);
            TrueFalseQuestionList.Add(Q1);
            TrueFalseQuestionList.Add(Q2);
            TrueFalseQuestionList.Add(Q3);


            //Create Choose one Options Questions
            ChooseOneQuestions Q4 = new ChooseOneQuestions("Choose the correct answer.", "Which of the following languages is known for its use in data science and machine learning?", "Programming Languages", 5, new List<string> { "Java", "Python", "C#", "JavaScript" }, 1);
            ChooseOneQuestions Q5 = new ChooseOneQuestions("Choose the correct answer.", "Which language is statically typed?", "Programming Languages", 5, new List<string> { "Python", "Ruby", "Java", "JavaScript" }, 2);
            ChooseOneQuestions Q6 = new ChooseOneQuestions("Choose the correct answer.", "Which programming language is known for its use in developing iOS applications?", "Programming Languages", 5, new List<string> { "Java", "Swift", "PHP", "C#" }, 1);


            //Logging Choose the correct answer Questions of Practice Exam in SeparatedLoggFile
            string ChooseOnePath_PracticeExam = @"E:\مبادره رواد مصر الرقميه\C#\C# Project\ChooseOneQuestion_PracticeExamFile.txt";
            ChooseOneLoggFile ChooseOneOptionQuestionList = new ChooseOneLoggFile(ChooseOnePath_PracticeExam);
            ChooseOneOptionQuestionList.Add(Q4);
            ChooseOneOptionQuestionList.Add(Q5);
            ChooseOneOptionQuestionList.Add(Q6);

            //Create Choose More Options Questions
            ChooseAllQuestions Q7 = new ChooseAllQuestions("Select all that apply.", "Which of the following are programming languages?", "Programming Languages", 10, new List<string> { "Python", "HTML", "C#", "CSS" }, new List<int> { 0, 2 });
            ChooseAllQuestions Q8 = new ChooseAllQuestions("Select all that apply.", "Which of the following are statically typed languages?", "Programming Languages", 10, new List<string> { "Python", "Java", "Ruby", "C#" }, new List<int> { 1, 3 });
            ChooseAllQuestions Q9 = new ChooseAllQuestions("Select all that apply.", "Which of the following are used primarily for web development?", "Programming Languages", 10, new List<string> { "JavaScript", "C++", "PHP", "Java" }, new List<int> { 0, 2 });

            //Logging Choose the More than one answer Questions of Practice Exam in SeparatedLoggFile
            string ChooseMorePath_PracticeExam = @"E:\مبادره رواد مصر الرقميه\C#\C# Project\ChooseMoreOption_PracticeExamFile.txt";
            ChooseMoreOptionsLoggFile ChoosemoreOptionQuestionList = new ChooseMoreOptionsLoggFile(ChooseMorePath_PracticeExam);
            ChoosemoreOptionQuestionList.Add(Q7);
            ChoosemoreOptionQuestionList.Add(Q8);
            ChoosemoreOptionQuestionList.Add(Q9);



            //Create Dictionary That will contain 9 questions of Practise Exam and students Answer For these questions
            PracticeExam<Question, Answer> PracticeProgrammingLanguageExam = new PracticeExam<Question, Answer>(30, 9, ProgLanguage);
            //Adding Questions and Users Answers
            PracticeProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q1, null);
            PracticeProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q2, null);
            PracticeProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q3, null);
            PracticeProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q4, null);
            PracticeProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q5, null);
            PracticeProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q6, null);
            PracticeProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q7, null);
            PracticeProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q8, null);
            PracticeProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q9, null);

            //Calling Method To check Exam Functionality
            // Attach OnExamTimeExceeded to the timer's Elapsed event
            PracticeProgrammingLanguageExam.examTimer.Elapsed += PracticeProgrammingLanguageExam.OnExamTimeExceeded;
            PracticeProgrammingLanguageExam.TakeExam();
            Console.WriteLine("===============================================================");
            // Option 1
            //After student Answer The last question The Exam will end
            PracticeProgrammingLanguageExam.OnExamTimeExceeded(null, null);
            Console.WriteLine("===============================================================");
            //Option 2
            //Exam Timer will Exist after 30 minutes
            //System.Threading.Thread.Sleep(1800000); // Simulating wait time for testing
            //FinalProgrammingLanguageExam.OnExamTimeExceeded(null, null);
            // Console.WriteLine("===============================================================");

            PracticeProgrammingLanguageExam.ShowExamInfo();
            Console.WriteLine("===============================================================");

            //Loop in the dictionary and check if Student Answer quesion correct or not
            //Check student Answers
            Console.WriteLine("Student Answers corrections : ");
            Console.WriteLine("===============================================================");
            foreach (var KeyValueItem in PracticeProgrammingLanguageExam.QuestionAnswerDictionary)
            {
                var question = KeyValueItem.Key;
                var answer = KeyValueItem.Value;

                bool isCorrect = PracticeProgrammingLanguageExam.IsQuestionCorrect(question, answer);
                Console.WriteLine($"Question: {question.Header} - Correct Answer: {isCorrect}");
                Console.WriteLine();
            }
            Console.WriteLine("===============================================================");
            //Calculate Student Mark Percentage in the final Exam
            double grade = PracticeProgrammingLanguageExam.CalculateGrade();
            Console.WriteLine($"Final Exam Grade: {grade}%");
            Console.WriteLine("===============================================================");

            #endregion




            #region Test Final Exam
            //Test Final Exam

            ////Create True and false Questions
            //Subject ProgrammingLanguage = new Subject("ProgrammingLanguage", "CS50");
            //TrueAndFalseQuestions Q1 = new TrueAndFalseQuestions(
            //    "This is a true or false question.",
            //    "Is Python a statically typed language?",
            //    "Programming Languages",
            //    5,
            //    false);

            //TrueAndFalseQuestions Q2 = new TrueAndFalseQuestions(
            //    "This is a true or false question.",
            //    "Is JavaScript the same as Java?",
            //    "Programming Languages",
            //    5,
            //    false);

            //TrueAndFalseQuestions Q3 = new TrueAndFalseQuestions(
            //    "This is a true or false question.",
            //    "Is C# a derivative of C++?",
            //    "Programming Languages",
            //    5,
            //    true);

            //TrueAndFalseQuestions Q4 = new TrueAndFalseQuestions(
            //    "This is a true or false question.",
            //    "Does Python support multiple inheritance?",
            //    "Programming Languages",
            //    5,
            //    true);

            //TrueAndFalseQuestions Q5 = new TrueAndFalseQuestions(
            //    "This is a true or false question.",
            //    "Is Ruby a compiled language?",
            //    "Programming Languages",
            //    5,
            //    false);

            ////Logging True and False Questions of Final Exam in SeparatedLoggFile
            //string TrueFalsePathFinalExam = @"E:\مبادره رواد مصر الرقميه\C#\C# Project\TrueAndFalseQuestion_FinalExamFile.txt";
            //TrueAndFalseLoggFile TrueFalseQuestionList = new TrueAndFalseLoggFile(TrueFalsePathFinalExam);
            //TrueFalseQuestionList.Add(Q1);
            //TrueFalseQuestionList.Add(Q2);
            //TrueFalseQuestionList.Add(Q3);
            //TrueFalseQuestionList.Add(Q4);
            //TrueFalseQuestionList.Add(Q5);


            ////Creating Choose one Questions
            //ChooseOneQuestions Q6 = new ChooseOneQuestions(
            //    "Choose the correct answer.",
            //    "Which of the following languages is known for its use in data science and machine learning?",
            //    "Programming Languages",
            //    5,
            //    new List<string> { "Java", "Python", "C#", "JavaScript" },
            //    1);

            //ChooseOneQuestions Q7 = new ChooseOneQuestions(
            //    "Choose the correct answer.",
            //    "Which language is statically typed?",
            //    "Programming Languages",
            //    5,
            //    new List<string> { "Python", "Ruby", "Java", "JavaScript" },
            //    2);

            //ChooseOneQuestions Q8 = new ChooseOneQuestions(
            //    "Choose the correct answer.",
            //    "Which programming language is known for its use in developing iOS applications?",
            //    "Programming Languages",
            //    5,
            //    new List<string> { "Java", "Swift", "PHP", "C#" },
            //    1);

            //ChooseOneQuestions Q9 = new ChooseOneQuestions(
            //    "Choose the correct answer.",
            //    "Which language is primarily used for web development?",
            //    "Programming Languages",
            //    5,
            //    new List<string> { "Python", "Java", "JavaScript", "C++" },
            //    2);

            //ChooseOneQuestions Q10 = new ChooseOneQuestions(
            //    "Choose the correct answer.",
            //    "Which of the following is a database management system?",
            //    "Programming Languages",
            //    5,
            //    new List<string> { "MySQL", "HTML", "CSS", "Python" },
            //    0);

            ////Logging Choose the correct answer Questions of Practice Exam in SeparatedLoggFile
            //string ChooseOnePath_FinalExam = @"E:\مبادره رواد مصر الرقميه\C#\C# Project\ChooseOneQuestion_FinalExamFile.txt";
            //ChooseOneLoggFile ChooseOneOptionQuestionList = new ChooseOneLoggFile(ChooseOnePath_FinalExam);
            //ChooseOneOptionQuestionList.Add(Q6);
            //ChooseOneOptionQuestionList.Add(Q7);
            //ChooseOneOptionQuestionList.Add(Q8);
            //ChooseOneOptionQuestionList.Add(Q9);
            //ChooseOneOptionQuestionList.Add(Q10);

            //// Create Choose All Option Questions
            //ChooseAllQuestions Q11 = new ChooseAllQuestions(
            //    "Select all that apply.",
            //    "Which of the following are programming languages?",
            //    "Programming Languages",
            //    10,
            //    new List<string> { "Python", "HTML", "C#", "CSS" },
            //    new List<int> { 0, 2 });

            //ChooseAllQuestions Q12 = new ChooseAllQuestions(
            //    "Select all that apply.",
            //    "Which of the following are statically typed languages?",
            //    "Programming Languages",
            //    10,
            //    new List<string> { "Python", "Java", "Ruby", "C#" },
            //    new List<int> { 1, 3 });

            //ChooseAllQuestions Q13 = new ChooseAllQuestions(
            //    "Select all that apply.",
            //    "Which of the following are used primarily for web development?",
            //    "Programming Languages",
            //    10,
            //    new List<string> { "JavaScript", "C++", "PHP", "Java" },
            //    new List<int> { 0, 2 });

            //ChooseAllQuestions Q14 = new ChooseAllQuestions(
            //    "Select all that apply.",
            //    "Which of the following are object-oriented programming languages?",
            //    "Programming Languages",
            //    10,
            //    new List<string> { "Python", "HTML", "Java", "CSS" },
            //    new List<int> { 0, 2 });

            //ChooseAllQuestions Q15 = new ChooseAllQuestions(
            //    "Select all that apply.",
            //    "Which of the following are scripting languages?",
            //    "Programming Languages",
            //    10,
            //    new List<string> { "JavaScript", "Python", "C++", "Ruby" },
            //    new List<int> { 0, 1, 3 });

            ////Logging Choose the More than one answer Questions of Practice Exam in SeparatedLoggFile
            //string ChooseMorePath_FinalExam = @"E:\مبادره رواد مصر الرقميه\C#\C# Project\ChooseMoreOption_FinalExamFile.txt";
            //ChooseMoreOptionsLoggFile ChoosemoreOptionQuestionList = new ChooseMoreOptionsLoggFile(ChooseMorePath_FinalExam);
            //ChoosemoreOptionQuestionList.Add(Q11);
            //ChoosemoreOptionQuestionList.Add(Q12);
            //ChoosemoreOptionQuestionList.Add(Q13);
            //ChoosemoreOptionQuestionList.Add(Q14);
            //ChoosemoreOptionQuestionList.Add(Q15);

            ////Create FinalExam Dictionary 
            //FinalExam<Question, Answer> FinalProgrammingLanguageExam = new FinalExam<Question, Answer>(30, 15, ProgrammingLanguage);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q1, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q2, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q3, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q4, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q5, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q6, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q7, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q8, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q9, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q10, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q11, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q12, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q13, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q14, null);
            //FinalProgrammingLanguageExam.QuestionAnswerDictionary.Add(Q15, null);

            ////Calling Method To check Exam Functionality


            //// Attach OnExamTimeExceeded to the timer's Elapsed event
            //FinalProgrammingLanguageExam.examTimer.Elapsed += FinalProgrammingLanguageExam.OnExamTimeExceeded;
            //FinalProgrammingLanguageExam.TakeExam();
            //Console.WriteLine("===============================================================");
            //// Option 1
            ////After student Answer The last question The Exam will end
            //FinalProgrammingLanguageExam.OnExamTimeExceeded(null, null);
            //Console.WriteLine("===============================================================");
            ////Option 2
            ////Exam Timer will Exist after 30 minutes
            ////System.Threading.Thread.Sleep(1800000); // Simulating wait time for testing
            ////FinalProgrammingLanguageExam.OnExamTimeExceeded(null, null);
            //// Console.WriteLine("===============================================================");


            //FinalProgrammingLanguageExam.ShowExamInfo();
            //Console.WriteLine("===============================================================");

            ////Loop in the dictionary and check if Student Answer quesion correct or not
            ////Check student Answers
            //Console.WriteLine("Student Answers : ");
            //Console.WriteLine("===============================================================");
            //foreach (var KeyValueItem in FinalProgrammingLanguageExam.QuestionAnswerDictionary)
            //{
            //    var question = KeyValueItem.Key;
            //    var answer = KeyValueItem.Value;

            //    bool isCorrect = FinalProgrammingLanguageExam.IsQuestionCorrect(question, answer);
            //    Console.WriteLine($"Question: {question.Header} - Correct Answer: {isCorrect}");
            //    Console.WriteLine();
            //}
            //Console.WriteLine("===============================================================");
            ////Calculate Student Mark Percentage in the final Exam
            //double grade = FinalProgrammingLanguageExam.CalculateGrade();
            //Console.WriteLine($"Final Exam Grade: {grade}%");
            //Console.WriteLine("==============================================================="); 
            #endregion
        }
    }
}
