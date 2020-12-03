/// Week 11		Lab 
/// File Name: Program.cs
/// @author: Antonio Monteiro


using System;
using System.Collections.Generic;
using System.IO;

namespace Homework11 {
    class Program {
        static void Main(string[] args) {

            //list of students
            List<Student> students = new List<Student>();

            //delimiter character
            char[] delimiterChars = { ' ' };

            //populate students list from file
            using (StreamReader reader = new StreamReader("students.txt")) {
                string line = null;
                while ((line = reader.ReadLine()) != null) {
                    string[] lineData = line.Split(delimiterChars);
                    students.Add(new Student(lineData[0], lineData[1], int.Parse(lineData[2])));
                }
            }

            //sort students list
            students.Sort();

            //get average
            double averageScore = 0;
            foreach (Student student in students) {
                averageScore += student.Score;
            }
            averageScore /= (double)students.Count;

            //get median
            double medianScore;
            if (students.Count % 2 == 0) {
                medianScore = (students[students.Count / 2].Score + students[(students.Count / 2) - 1].Score) / 2.0;
            } else {
                medianScore = students[students.Count / 2].Score;
            }

            //output to file
            using (StreamWriter file = new StreamWriter("studentstats.txt")) {
                file.WriteLine("Average: {0}", averageScore);
                file.WriteLine("Median : {0}", medianScore);
                Console.WriteLine("Succesfuly saved to file.");
            }

            

        }
    }
}
