using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRecords
{
    class StudentClass:RecordClass
    {
        public string Name { get; set; }

        public string ClassNSection { get; set; }

        public string Info()
        {
            return("Name:"+Name+" | Class and Section:"+ClassNSection);
        }
    }
}
