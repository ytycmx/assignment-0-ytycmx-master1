using System;

namespace HomeworkTest
{
    public class Student : IStudent
    {
        public string Name => "Zihao";

        public string Surname => "Song";

        public int MetriculationNumber => 1804548;

        public Student(string name, string surname, int metriculationNumber)
        {
            name = Name;
            surname = Surname;
            metriculationNumber = MetriculationNumber;
        } 
    }
}
//name : Zihao Song