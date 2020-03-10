using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        public Cohort Cohort { get; set; }

        public string Specialty { get; set; }
        //a method to assign an exercise to a student
        public void assignExercise(Exercise exercise, Student student)
        {
            student.Exercises.Add(exercise);
        }
        //creating a instructor constructor
        public Instructor(string first, string last, string handle, Cohort cohort, string specialty)
        {
            FirstName = first;
            LastName = last;
            SlackHandle = handle;
            Cohort = cohort;
            Specialty = specialty;

        }

    }
}