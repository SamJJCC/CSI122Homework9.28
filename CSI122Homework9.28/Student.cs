using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI122Homework9._28
{
    internal class Student
    {
        //fields

        public string _name;
        public int _genEdGrade;
        public int _compSciGrade;

        public Student(string name, int genEdGrade , int compSciGrade)
        {
            _name = name;
            _genEdGrade = genEdGrade;
            _compSciGrade = compSciGrade;
        }  


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }

        }



        public int GenEdGrade
        {
            get
            { 
                return _genEdGrade;
            } 
            set
            {
                if (value > 0 && value <= 100)
                {
                    _genEdGrade = value;
                }
                else
                {
                    throw new Exception("Enter a valid number");
                }
            }
        }
        

        public int CompSciGrade
        {
          
            get
            {
                return _compSciGrade;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _compSciGrade = value;
                }
                else
                {
                    throw new Exception("Enter a valid number");
                }
            }
        }



      



       


    }
}