using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRecords
{
    class RecordClass
    {
        public string Name;
        public string ClassNSection;
        public virtual (string,string) Info()
        {
            return (Name, ClassNSection);
        }
    }
}
