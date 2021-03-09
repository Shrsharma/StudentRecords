using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRecords
{
    class SubjectClass: TeacherClass
    {
        public string SubjectCode { get; set; }

        public string Info()
        {
            return ("Name:" + Name + " | Subject Code:" + SubjectCode + " | Class and Section:" + ClassNSection);
        }
    }
}
