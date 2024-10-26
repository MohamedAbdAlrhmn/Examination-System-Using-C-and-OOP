using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPProject.Answer;

namespace OOPProject
{
    internal abstract class Question
    {
        #region Properties
        public string Body { get; set; }
        public int Mark { get; set; }
        public string Header { get; set; }
        public string Category { get; set; }
       
        #endregion

        #region Constructors

        public Question()
        {

        }

        public Question(string _header, string _body, string _category, int _mark)
        {
            this.Body = _body;
            this.Header = _header;
            this.Category = _category;
            this.Mark = _mark;

        }
        #endregion


        #region Methods

        //This method show information about question 
        public abstract void QuestionInfo();

        //This method check if answer of user on this question correct or not correct
        public abstract bool IsAnswerCorrect(Answer answer);

        //New methods added
        public abstract Answer GetAnswer();

        public abstract void Display();
        #endregion



    }
}
