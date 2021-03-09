using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRecords
{
    class GivenRecordClass
    {
        public static void Do()
        {

            List<StudentClass> stud= new List<StudentClass>();
            List<SubjectClass> subj = new List<SubjectClass>();

            StudentClass s1 = new StudentClass() { Name = "ABC" , ClassNSection="1st A" };
            StudentClass s2 = new StudentClass() { Name = "XYZ" , ClassNSection="2nd B" };
            stud.Add(s1); 
            stud.Add(s2);

            SubjectClass subj1 = new SubjectClass() { Name = "DEF", SubjectCode = " 001", ClassNSection="1st A"};
            SubjectClass subj2 = new SubjectClass() { Name = "MNO", SubjectCode = " 002", ClassNSection="2nd B"};
            subj.Add(subj1); 
            subj.Add(subj2); 

            Console.WriteLine("Students in a Class:- ");
            foreach (StudentClass s in stud)
                Console.WriteLine(s.Info());
            Console.WriteLine("\nSubjects taught by a Teacher:- ");
            foreach (SubjectClass s in subj)
                Console.WriteLine(s.Info());
        }
    }
}
