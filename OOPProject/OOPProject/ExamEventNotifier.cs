using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    public enum ExamMode
    {
        Starting,
        Queued,
        Finished
    }
    //Delegate for Project Bonus
    public delegate void ExamModeChangeHandler(ExamMode mode);
    internal class ExamEventNotifier
    {  
        //Creating event from EventHandler that called ExamModeChangeHandler
        public event ExamModeChangeHandler ModeChanged;
        private ExamMode _mode;

        #region Property
        public ExamMode Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                OnModeChanged();
            }
        }
        #endregion


        #region Methods
        //  This method for detect Exam Mode Changing 
        protected virtual void OnModeChanged()
        {
            ModeChanged?.Invoke(_mode);
        } 
        #endregion
    }
}
