using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)

        {
            Exercise Nutshell = new Exercise("Nutshell", "Javascript");
            Exercise Capston = new Exercise("Capstone", "React");
            Exercise Martins = new Exercise("Martin's Aquarium", "Javascript");
            Exercise Representatives = new Exercise("Representatives", "HTML");
            Exercise Coffee = new Exercise("CoffeeShops", "CSS");
            Exercise KandyKorner = new Exercise("KandyKorner", "Javascript");

            Cohort Cohort35 = new Cohort("Cohort 35");
            Cohort Cohort36 = new Cohort("Cohort 36");
            Cohort Cohort37 = new Cohort("Cohort 37");
            Cohort Cohort38 = new Cohort("Cohort 36");

            Student Coffey = new Student("Coffey", "May", "CMay", Cohort37);
            Student Eli = new Student("Eli", "Tamez", "EliTamez", Cohort37);
            Student Rebecca = new Student("Rebecca", "Patek", "Rpatek", Cohort37);
            Student Melanie = new Student("Melianie", "Brown", "MelB", Cohort35);
            Student Sam = new Student("Sam", "Smith", "SmittySam", Cohort36);
            Cohort37.addStudent(Coffey);
            Cohort37.addStudent(Eli);
            Cohort37.addStudent(Rebecca);
            Cohort35.addStudent(Melanie);
            Cohort36.addStudent(Sam);
            Instructor Adam = new Instructor("Adam", "Sheaffer", "AdamSheaffer", Cohort37, "Vars");
            Instructor Joe = new Instructor("Joe", "Sheppard", "JoeShep", Cohort35, "Voiceovers");
            Instructor Steve = new Instructor("Steve", "Brownlee", "Chortlehort", Cohort38, "Jokes");

            Instructor Rose = new Instructor("Rose", "Witkowsky", "RosieWitWit", Cohort37, "Jumpsuits");
            Instructor Brenda = new Instructor("Brenda", "Long", "BrendaLong", Cohort37, "CSS");
            Instructor Jissie = new Instructor("Jissie", "Bobessie", "Jissiejissie", Cohort36, "Coolness");
            Cohort37.addInstructor(Adam);
            Cohort37.addInstructor(Brenda);
            Cohort37.addInstructor(Rose);
            Cohort35.addInstructor(Joe);
            Cohort38.addInstructor(Steve);
            Steve.assignExercise(Nutshell, Coffey);
            Steve.assignExercise(Coffee, Rebecca);
            Rose.assignExercise(Nutshell, Eli);
            Joe.assignExercise(Capston, Melanie);
            Joe.assignExercise(Capston, Coffey);
            foreach (Student student in Cohort37.Students)
            {
                student.Description();
            }

            foreach (Student student in Cohort36.Students)
            {
                student.Description();
            }
            foreach (Student student in Cohort35.Students)
            {
                student.Description();
            }
            List<Student> Students = new List<Student>();
            Students.Add(Coffey);
            Students.Add(Rebecca);
            Students.Add(Eli);
            Students.Add(Sam);
            Students.Add(Melanie);
            List<Exercise> Exercises = new List<Exercise>();
            Exercises.Add(Nutshell);
            Exercises.Add(Capston);
            Exercises.Add(Martins);
            Exercises.Add(Representatives);
            Exercises.Add(Coffee);
            Exercises.Add(KandyKorner);
            List<Cohort> Cohorts = new List<Cohort>();
            Cohorts.Add(Cohort35);
            Cohorts.Add(Cohort36);
            Cohorts.Add(Cohort37);
            Cohorts.Add(Cohort38);
            List<Instructor> Instructors = new List<Instructor>();
            Instructors.Add(Adam);
            Instructors.Add(Brenda);
            Instructors.Add(Steve);
            Instructors.Add(Rose);
            Instructors.Add(Joe);
            Instructors.Add(Jissie);
            var JavaExercises = Exercises.Where(Ex => Ex.ExerciseLanguage == "Javascript");
            Console.WriteLine("Javascript Exercises:");
            Console.WriteLine("------------------------------");
            foreach (var Ex in JavaExercises)
            {
                Console.WriteLine($"{Ex.ExerciseName}");

            }
            var StudentsByCohort = Students.Where(stu => stu.Cohort == Cohort37);
            Console.WriteLine("Students who are in Cohort 37:");
            foreach (var stu in StudentsByCohort)
            {
                Console.WriteLine($"{stu.FirstName}");
            }
            Console.WriteLine("----------------------");
            var InstructorsByCohort = Instructors.Where(inst => inst.Cohort == Cohort37);
            Console.WriteLine("Instructors who are in Cohort 37:");
            foreach (var inst in InstructorsByCohort)
            {
                Console.WriteLine($"{inst.FirstName}");
            }
            Console.WriteLine("----------------------");
            var SortedStudentsByLastName = Students.OrderBy(stud => stud.LastName);
            foreach (var stud in SortedStudentsByLastName)
            {
                Console.WriteLine($"{stud.LastName}");
            }

            var StudentsWhoArentWorkingOnAnything = Students.Where(student => { return student.Exercises.Count == 0 || student.Exercises == null; });
            Console.WriteLine("Students without exercises:");

            foreach (var student in StudentsWhoArentWorkingOnAnything)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine($"________________________");
            var StudentsOrderedByExereciseCount = Students.OrderByDescending(Student =>
            {
                return Student.Exercises.Count();
            }).FirstOrDefault();
            Console.WriteLine($"First student with the most exercises {StudentsOrderedByExereciseCount.FirstName} {StudentsOrderedByExereciseCount.LastName}");
            var groups = Students.GroupBy(Student => Student.Cohort.CohortName);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Count()} in {group.Key}");

            }


        }
    }
}