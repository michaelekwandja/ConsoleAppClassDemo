using ConsoleAppClassDemo.Utils;

namespace ConsoleAppClassDemo.Classes.PersonDemo
{
    public class Teacher : Person
    {
        public void GenerateTeacherIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("TCH");

        }
    }
}
