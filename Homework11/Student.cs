using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11 {
    class Student : IComparable<Student> {

        //instance variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }

        //contructors
        public Student(string firstName, string lastName, int score) {
            FirstName = firstName;
            LastName = lastName;
            Score = score;
        }

        //implement IComparable interface
        public int CompareTo(Student other) {
            if (Score > other.Score) {
                return 1;
            } else if (Score < other.Score) {
                return -1;
            } else {
                return 0;
            }
        }

    }
}
