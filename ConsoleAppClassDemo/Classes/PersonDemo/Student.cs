using ConsoleAppClassDemo.Utils;
using System.Security.Cryptography;

namespace ConsoleAppClassDemo.Classes.PersonDemo
{
    public class Student : Person
    {
        public void GenerateStudentIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("STU");

        }
    }
}
