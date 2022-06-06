using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharpe
{
    internal class Student
    {
        private string name;
        private int age;
        private string gender;

        public Student(string name, int age, string gender)
        {
            this.name = name;
            try
            {
                if (age < 0)
                    throw new AgeException("Age could not be a negative number!!");
                else
                {
                    try
                    {
                    if (age < 18 || age > 26)
                        throw new AgeException("Age could not be less than 18 or over 26!!");
                    this.age = age;
                    }
                    catch (AgeException nx)
                    {
                        Console.WriteLine(nx.Message);
                    }

                }
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            this.gender = gender;
        }

        public string Name { get { return name; } set { name = value; } }   
        public int Age { get { return age; } set { age = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
    }
}
