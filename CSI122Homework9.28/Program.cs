using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI122Homework9._28
{
    internal class Program
       
    {
        static void Main(string[] args)
        {

          

            bool isRunning = true;

            do
            {
                int userInput;

                Console.WriteLine("ENTER 1 TO DISPLAY ALL STUDENTS");
                Console.WriteLine("ENTER 2 TO ENTER A NEW STUDENT");
                Console.WriteLine("ENTER 3 TO EXIT APP");

                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number");
                }
                Console.WriteLine(userInput);



                switch (userInput)
                {
                    case 1:
                        PreLoadNames();
                        break;

                    case 2:
                        Console.WriteLine("Please enter student name:");

                        string nameInput = Console.ReadLine();

                        bool conversion = string.IsNullOrEmpty(nameInput);
                        if (conversion)
                        {
                            Console.WriteLine("Please enter a name");
                            nameInput = Console.ReadLine();
                        }

                        int compSci;

                        Console.WriteLine("Please enter a CompSciGrade:");
                        while (!int.TryParse(Console.ReadLine(), out compSci))
                        {
                            Console.WriteLine("Please enter a  valid CompSci grade");
                        }

                        int genEG;
                        Console.WriteLine("Please enter a GenEd grade");

                        while (!int.TryParse(Console.ReadLine(), out genEG))
                        {
                            Console.WriteLine("Please enter a valid GenEd grade");
                        }

                        Console.WriteLine($"Name: {nameInput}");
                        Console.WriteLine($"CompSciGrade: {compSci}");
                        Console.WriteLine($"GenEDGrade: {genEG}");
                        double average = (compSci + genEG) / 2;
                        Console.WriteLine($"Average: {average}\n");
                        break;

                    case 3:

                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again");
                        break;
                }

            } while (isRunning);
           // bool isRunning = true;

            // do
            // {

            //} while (isRunning);



            Console.ReadLine();
           
           

        }



        public static void PreLoadNames()
        {
            Student stuName = new Student("Sam", 100, 80);
            Student stuName2 = new Student("Jay", 90, 70);
            Student stuName3 = new Student("Kat", 78, 75);
            //i did the average here bc i could not create a method 
            double average=(stuName.GenEdGrade+ stuName.CompSciGrade)/2;
            double average2 = (stuName2.GenEdGrade + stuName2.CompSciGrade) / 2;
            double average3 = (stuName3.GenEdGrade + stuName3.CompSciGrade) / 2;
            Console.WriteLine(
                $"Name:{stuName.Name}\n" +
                $"GenEd Grade:{stuName.GenEdGrade}\n" +
                $"compSci Grade:{stuName.CompSciGrade}\n"+
                $"Average:{average}\n");
          
            Console.WriteLine( 
                $"Name:{stuName2.Name}\n" +
                $"GenEd Grade:{stuName2.GenEdGrade}\n" +
                $"CompSci Grade:{stuName2.CompSciGrade}\n"+
                 $"Average:{average2}\n");


            Console.WriteLine(
                $"Name:{stuName3.Name}\n" +
               $"GenEd Grade:{stuName3.GenEdGrade}\n" +
               $"CompSci Grade:{stuName3.CompSciGrade}\n"+
                $"Average:{average3}\n");

            Console.WriteLine();

        }





       
        




    }
}
