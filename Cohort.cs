  using System.Collections.Generic;
  using System;

  namespace StudentExercises {
      public class Cohort {
          public string CohortName { get; set; }
          public List<Student> Students = new List<Student> ();

          public void addStudent (Student student) {
              Students.Add (student);
          }
          public List<Instructor> Instructors = new List<Instructor> ();

          public void addInstructor (Instructor instructor) {
              Instructors.Add (instructor);
          }
          //making a cohort constructor 
          public Cohort (string name) {
              CohortName = name;
          }

      }
  }