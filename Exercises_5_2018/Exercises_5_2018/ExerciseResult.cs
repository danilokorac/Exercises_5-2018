using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Exercises_5_2018
{
    class ExerciseResult
    {
        private int Id;
        private string StudentName;
        private string StudentIndex;
        private int Points;

        public ExerciseResult() { }
        public ExerciseResult(int Id, string StudentName, string StudentIndex, int Points)
        {
            this.Id = Id;
            this.StudentName = StudentName;
            this.StudentIndex = StudentIndex;
            this.Points = Points;
        }
        public int studentId { get { return Id; } set { Id = value; } }
        public string studentName { get { return StudentName; } set { StudentName = value; } }
        public string studentIndex { get { return StudentIndex; } set { StudentIndex = value; } }
        public int studentPoints { get { return Points; } set { Points = value; } }
       
        public override String ToString()
        {
            return "Student ID: " + Id + " StudentName: " + StudentName + " StudentIndex: " + StudentIndex + " Points: " + Points;
        }



    }
}
