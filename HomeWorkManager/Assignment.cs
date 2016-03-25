using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkManager
{
    class Assignment : IComparable
    {
        //members
        private string _courseName;
        private string _assignmentName;
        //properties
        public string CourseName
        {
            get
            {
                return _courseName;
            }
            set
            {
                if (value != "")
                    _courseName = value;
                else
                    _courseName = "חסר שם קורס";
            }
        }
        public string AssignmentName
        {
            get
            {
                return _assignmentName;
            }
            set
            {
                if (value != "")
                    _assignmentName = value;
                else
                    _assignmentName = "חסר שם קורס";
            }
        }
        public bool IsFinished { get; set; }
        public DateTime SubmissionDeadline { get; set; }
        //methods
        public Assignment(DateTime submissionDeadline, string courseName, string assignmentName)
        {
            SubmissionDeadline = submissionDeadline;
            CourseName = courseName;
            AssignmentName = assignmentName;
            IsFinished = false;
        }

        public Assignment(DateTime submissionDeadline, string courseName, string assignmentName, bool isFinished) : this(submissionDeadline, courseName, assignmentName)
        {
            this.IsFinished = isFinished;
        }

        public int CompareTo(object obj)
        {
            Assignment other = (Assignment)obj;
            return DateTime.Compare(SubmissionDeadline, other.SubmissionDeadline);
        }
        public override string ToString()
        {
            return CourseName + " - " + AssignmentName;
        }
    }
}
