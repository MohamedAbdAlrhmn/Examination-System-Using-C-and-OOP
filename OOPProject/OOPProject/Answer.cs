using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOPProject
{
    internal class Answer
    {
        #region Properties
        //This property that take Answer of question from user
       public string InputAnswer { get; set; }
        //This property for check if Answer correct or not
        

        #endregion


        #region Constructor
        public Answer(string text)
        {
            InputAnswer = text;
          
        }
        #endregion

        


    }
}
