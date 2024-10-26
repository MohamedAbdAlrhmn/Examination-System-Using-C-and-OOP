using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    internal class Subject
    {
        #region Properties

        public string Name { get; set; }
        public string Code { get; set; }

        #endregion

        #region Constructor

        public Subject(string name, string code)
        {
            Name = name;
            Code = code;
        }

        #endregion
    }
}
