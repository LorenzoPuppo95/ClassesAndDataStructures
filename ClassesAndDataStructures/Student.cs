﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndDataStructures
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }

        private int _yob;
        public int Yob
        {
            get => _yob;
            set
            {
                if (value < 1920)
                {
                    _yob = 1920;
                }
                else
                {
                    _yob = value;
                }
            }
        }

        public Student(string name, string surname, string gender, int yob)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Yob = yob;
        }

        public Student(string name, string surname, int yob)
        {
            Name = name;
            Surname = surname;
            Gender = "neutral";
            Yob = yob;
        }
    }
}
