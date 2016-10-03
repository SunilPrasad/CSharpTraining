using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            Student student = new Student();
            student.Name = "John";
            student.Age = 23;
            student.SpeakingLanguage = SpeakingLanguage.Hindi;

            Nullable<int> count = new Nullable<int>();
            count = 12;


        }
     
    }
    
    //English , Hindi , Marathi , Benagli

    public class Student
    {
        public string Name;

        public int Age;

        public SpeakingLanguage SpeakingLanguage;

    }

    public enum SpeakingLanguage
    {
        English, Hindi, Marathi, Benagli
    }
}
