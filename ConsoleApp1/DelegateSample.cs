using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class DelegateSample
    {
        delegate void ProcessSingleString(string s);
        delegate int FunctionTakingOneIntAndReturningAnInt(int inp);

        static void PrintString(string s)
        {
            Debug.WriteLine(s);
        }

        static int Square(int x)
        {
            return (x*x);
        }

        static int UnitPos(int x)
        {
            return x % 10;
        }

        static int SumWithFunc(int[] elements, FunctionTakingOneIntAndReturningAnInt f)
        {
            int sum = 0;
            foreach(var i in elements)
            {
                sum += f(i);
            }
            return sum;
        }

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
            /*#region Delegate Definition
            ProcessSingleString printingUsingPrintString = PrintString;
            printingUsingPrintString("Hello World explicit");

            ProcessSingleString printByDelegateInstantiation = delegate (string s) { Debug.WriteLine(s); };
            printByDelegateInstantiation("Hello World Delegate Instantiation");
            #endregion
            
            
            #region use of delegates
            int[] arr = new int[] { 11, 12, 13, 14 };
            Debug.WriteLine("Sum of arr square = " + SumWithFunc(arr, Square));
            Debug.WriteLine("Sum of arr unit positions = " + SumWithFunc(arr, UnitPos));
            
            #endregion
            
            
            #region AnonFunc
            ProcessSingleString printingUsingAnonymous = (x) => { Debug.WriteLine(x); };
            printingUsingAnonymous("Hello World Anon");

            //expression vs code block
            FunctionTakingOneIntAndReturningAnInt unitPosAnon = (x) => { return x % 10; };
            FunctionTakingOneIntAndReturningAnInt squareAnon = (x) =>  (x * x); 
            #endregion
            */
            
            #region Func and Action
            Func<int, int> squareFunc = (x) => (x*x);
            Func<int, int, int> add = (a, b) => (a + b);
            Action<string> printAction = (x) => { Debug.WriteLine(x); };
            printAction("Hello world action");
            #endregion

            seqSum(students, (x) => x.ChemistryMarks);
            

        }

        static int seqSum<T>(T[] studs, Func<T, int> GetProp)
        {
            int sum = 0;
            foreach(var s in studs )
            {
                sum += GetProp(s);
            }
            return sum;
        }
    }

    
}
