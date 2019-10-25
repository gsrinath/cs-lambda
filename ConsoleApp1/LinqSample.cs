using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class LinqSample
    {
        private static Student[] students = new Student[]
        {
            new Student {Name="Arun",ChemistryMarks = 90, PhysicsMarks = 95, MathsMarks = 100},
            new Student { Name = "Ajay", ChemistryMarks = 32, PhysicsMarks = 23, MathsMarks = 25},
            new Student {Name="Vijay",ChemistryMarks = 70, PhysicsMarks = 75, MathsMarks = 80},
            new Student { Name = "Andy", ChemistryMarks = 55, PhysicsMarks = 60, MathsMarks = 60},
            new Student {Name="Cathey",ChemistryMarks = 90, PhysicsMarks = 95, MathsMarks = 100},
            new Student { Name = "Karey", ChemistryMarks = 93, PhysicsMarks = 83, MathsMarks = 75},
            new Student {Name="Tarun",ChemistryMarks = 90, PhysicsMarks = 95, MathsMarks = 100},
            new Student { Name = "Pranav", ChemistryMarks = 32, PhysicsMarks = 23, MathsMarks = 25},
            new Student {Name="Mayank",ChemistryMarks = 66, PhysicsMarks = 62, MathsMarks = 71},
            new Student { Name = "Latha", ChemistryMarks = 71, PhysicsMarks = 60, MathsMarks = 55},
            new Student {Name="Arjun",ChemistryMarks = 90, PhysicsMarks = 95, MathsMarks = 100},
            new Student { Name = "Anita", ChemistryMarks = 10, PhysicsMarks = 11, MathsMarks = 10},
            new Student {Name="Vinita",ChemistryMarks = 90, PhysicsMarks = 95, MathsMarks = 100},
            new Student { Name = "Vinay", ChemistryMarks = 32, PhysicsMarks = 23, MathsMarks = 25},
        };

        static void Main1(string[] args)
        {
            //print names of students.
            PerformAction(students,(Student x)=> { Debug.WriteLine(x.Name); Console.WriteLine(x.Name); });


            students.Where((x) => ((x.MathsMarks + x.PhysicsMarks + x.ChemistryMarks) / 3 < 40)).Select((s) => s.Name).Count(); ;

            //Use PerformAction

            //print names of students who failed Maths
            Console.WriteLine((students.Where((x) => x.MathsMarks < 40).Select(s => s.Name))
                .Aggregate(0, (result, s) => (result + 1)));

            // Count number of students who failed Maths
            Console.WriteLine(students.Where((x) => x.MathsMarks < 40).Select(s => s.Name)
                .Aggregate(0, (result, x) => (result+1)));

            //students.Aggregate(seed: 0,(func<int,Student>: (result,item)=(result+item.PhysicsMark),)
        }

        static void PrintElements<T>(IEnumerable<T> list)
        {
            foreach(T elem in list)
            {
                Debug.WriteLine(elem);
            }
        }

        static void PerformAction<T>(IEnumerable<T> list, Action<T> act)
        {
            foreach(var elem in list)
            {
                act(elem);
            }
        }

    }

}
