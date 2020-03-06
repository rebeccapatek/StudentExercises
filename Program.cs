using System;

namespace StudentExercises {
    class Program {
        static void Main (string[] args)

        {
            Exercise Nutshell = new Exercise ("Nutshell", "Javascript");
            Exercise Capston = new Exercise ("Capstone", "React");
            Exercise Martins = new Exercise ("Martin's Aquarium", "Javascript");
            Exercise Representatives = new Exercise ("Representatives", "HTML");
            Exercise Coffee = new Exercise ("CoffeeShops", "CSS");
            Exercise KandyKorner = new Exercise ("KandyKorner", "Javascript");

            Cohort Cohort35 = new Cohort ("Cohort 35");
            Cohort Cohort36 = new Cohort ("Cohort 36");
            Cohort Cohort37 = new Cohort ("Cohort 37");
            Cohort Cohort38 = new Cohort ("Cohort 36");

            Student Coffey = new Student ("Coffey", "May", "CMay", "Cohort 37");
            Student Eli = new Student ("Eli", "Tamez", "EliTamez", "Cohort 37");
            Student Rebecca = new Student ("Rebecca", "Patek", "Rpatek", "Cohort 37");
            Student Melanie = new Student ("Melianie", "Brown", "MelB", "Cohort 35");
            Student Sam = new Student ("Sam", "Smith", "SmittySam", "Cohort 36");
            Cohort37.addStudent (Coffey);
            Cohort37.addStudent (Eli);
            Cohort37.addStudent (Rebecca);
            Cohort35.addStudent (Melanie);
            Cohort36.addStudent (Sam);
            Instructor Adam = new Instructor ("Adam", "Sheaffer", "AdamSheaffer", "Cohort 37", "Vars");
            Instructor Joe = new Instructor ("Joe", "Sheppard", "JoeShep", "Cohort 35", "Voiceovers");
            Instructor Steve = new Instructor ("Steve", "Brownlee", "Chortlehort", "Cohort 38", "Jokes");

            Instructor Rose = new Instructor ("Rose", "Witkowsky", "RosieWitWit", "Cohort 37", "Jumpsuits");
            Instructor Brenda = new Instructor ("Brenda", "Long", "BrendaLong", "Cohort 37", "CSS");
            Instructor Jissie = new Instructor ("Jissie", "Bobessie", "Jissiejissie", "Cohort 36", "Coolness");
            Cohort37.addInstructor (Adam);
            Cohort37.addInstructor (Brenda);
            Cohort37.addInstructor (Rose);
            Cohort35.addInstructor (Joe);
            Cohort38.addInstructor (Steve);
            Steve.assignExercise (Nutshell, Coffey);
            Steve.assignExercise (Coffee, Rebecca);
            Rose.assignExercise (Nutshell, Eli);
            Joe.assignExercise (Capston, Melanie);
            foreach (Student student in Cohort37.Students) {
                student.Description ();
            }

            foreach (Student student in Cohort36.Students) {
                student.Description ();
            }
            foreach (Student student in Cohort35.Students) {
                student.Description ();
            }

        }
    }
}