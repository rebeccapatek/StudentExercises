using System;
using System.Collections.Generic;

namespace StudentExercises {
    public class Student {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        public string Cohort { get; set; }

        public List<Exercise> Exercises = new List<Exercise> ();

        public void Description () {
            Console.WriteLine (this.FirstName + " " + this.LastName);
            Console.WriteLine ($"Slack Handle: {this.SlackHandle}");
            Console.WriteLine ($"Cohort: {this.Cohort}");
            foreach (Exercise exercise in this.Exercises) {
                Console.WriteLine ($"Currently working on {exercise.ExerciseName}");
            }
            Console.WriteLine ($"-------------------");
        }
        //This is the Student Constructor below
        public Student (string first, string last, string slackhandle, string cohort) {
            FirstName = first;
            LastName = last;
            SlackHandle = slackhandle;
            Cohort = cohort;
        }

    }

}