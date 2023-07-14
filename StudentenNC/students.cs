﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentenNC
{
    internal class students
    {
        public List<string> StudentName { get; private set; } = new List<string>();
        public List<float> Durchschnitt { get; private set; } = new List<float>();


        // Anlegen eines neuen Studenten
        public students() { }

        public void AddStudenten(string studentName, float studentNC)
        {
            StudentName.Add(studentName);
            Durchschnitt.Add(studentNC);
        }

        public void ShowNC()
        {
            Console.WriteLine("Der Notendurchschnitt aller Schüler beträgt: " + Durchschnitt.Average());
        }        
    }
}
