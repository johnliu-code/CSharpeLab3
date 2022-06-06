using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Lab3CSharpe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab3 Excercice!");
           
            Console.WriteLine("Excercie 1: \n--------------------");
            //1- Créer une collection de type ArrayList.
            ArrayList members = new ArrayList();

            // a.Ajouter "Aline", "Micheline", "Jeanine" à la collection.
            members.Add("Aline");
            members.Add("Micheline");
            members.Add("Jeanine");

            // b.Afficher le premier élément de la collection puis le dernier. 
            Console.WriteLine("Premier member : " + members[0]);

            // c.Enlever le second.
            members.RemoveAt(1);

            // d.Si la collection contient "Aline", ajouter "Tania" à la position où est "Aline".
            if (members.Contains("Aline"))
                members.Insert(members.IndexOf("Aline"), "Tania");
            // e.Créer une boucle qui affiche tous les éléments de la collection.
            Console.WriteLine("All of the members: ");
            foreach(var member in members)
            {
                Console.WriteLine(member);
            }

            // 2 - Créer une collection contenant des entiers.
            Console.WriteLine("Excercie 2: \n--------------------");
            ArrayList intList = new ArrayList();
            // a.Ajouter 12, 24 et 32 à la collection.
            intList.Add(12);
            intList.Add(24);
            intList.Add(32);
            // b.Afficher le troisième élément. 
            Console.WriteLine("Troisième élément : " + intList[2]);
            // c.Créer une boucle pour afficher successivement tous les éléments de la collection.
            Console.WriteLine("All of the int : ");
            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);

            // 3- Créer une instance d'une collection SortedList dans laquelle on va ranger des instances de la classe Salarié
            SortedList<int, Employee> employeeList = new SortedList<int, Employee>();

            // b.Créer cinq instances de la classe Salarié et les insérer dans la collection.
            var employee1 = new Employee(1001, "Tom", 15f);
            employeeList.Add(employee1.EmployeeId, employee1);

            var employee2 = new Employee(1005, "Mary", 25f);
            employeeList.Add(employee2.EmployeeId, employee2);

            var employee3 = new Employee(1003, "John", 35f);
            employeeList.Add(employee3.EmployeeId, employee3);

            var employee4 = new Employee(1004, "Anna", 45f);
            employeeList.Add(employee4.EmployeeId, employee4);

            var employee5 = new Employee(1002, "Mark", 20f);
            employeeList.Add(employee5.EmployeeId, employee5);

            // c. Faire le parcours de la collection pour afficher les salariés par ordre croissant des numéros de matricule.
             Console.WriteLine("    Employee ID    Employee Name  ");
            foreach (var emp in employeeList.Values)
            {
                Console.WriteLine("    \t{0}          \t{1}", emp.EmployeeId, emp.Name);
            }

            // d. Choisir une clé (un matricule) et afficher le salarié ayant cette clé.

            Console.WriteLine("Which ID number you want to find?");
            int id = int.Parse(Console.ReadLine());
            bool findEmp = false;

            foreach (var pairemp in employeeList)
            {
                if (pairemp.Key == id)
                {
                    Console.WriteLine(" Employee ID:   \t{0};    Employee Name:   \t{1}", pairemp.Value.EmployeeId, pairemp.Value.Name);
                    findEmp = true;
                }
                else
                    findEmp = false;

            }
            if (!findEmp)
                Console.WriteLine("Employee ID: " + id + " n'est pas trouver !");

            //4 
            float hours = 40f;
            employee1.CalculateSalary(hours);
            employee2.CalculateSalary(hours);
            employee3.CalculateSalary(hours);
            employee4.CalculateSalary(hours);
            employee5.CalculateSalary(hours);

            //5
            int inputvalue = 0;
            inputvalue = ValidInt(inputvalue);

           
            //6
            //a.
            //b.
            //c.
            Student stu1 = new Student("John", 23, "M");
            Console.WriteLine("Age of student " + stu1.Name + " is: " + stu1.Age);
            Console.ReadLine();

            Student stu2 = new Student("Tom", -20, "M");
            Console.WriteLine("Age of student " + stu2.Name + " is: " + stu2.Age);
            Console.ReadLine();

            Student stu3 = new Student("Anna", 45, "F");
            Console.WriteLine("Age of student " + stu3.Name + " is: " + stu3.Age);
            Console.ReadLine();

            Student stu4 = new Student("Mary", 12, "F");
            Console.WriteLine("Age of student " + stu4.Name + " is: " + stu4.Age);           
            Console.ReadLine();

             

            //7
            DateTime departure = DateTime.Now;
            DateTime arrival = DateTime.Now; 
            Booking(departure, arrival);

             Console.ReadLine();
            

            //8
            int age = 0;
            DateTime birthdate = DateTime.Now;
            age = GetAge(birthdate);
        }

        //5
        public static int ValidInt(int inputvalue)
        {
            try
            {

                Console.WriteLine("Entrez un int valeur : ");
                inputvalue = int.Parse(Console.ReadLine());
                if (inputvalue < 0)
                    Console.WriteLine("You have entre a negative int number: " + inputvalue);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("This is not a int number, please entre a int number!" + ex);
                return ValidInt(inputvalue);
            }

            Console.WriteLine("You have entre a int number : " + inputvalue);
            return inputvalue;
        }

        //7.
        public static void Booking(DateTime departure, DateTime arrival)
        {
            string datedepart;
            string datearrival;
            IFormatProvider culture = new CultureInfo("en-US", true);
            
            Console.WriteLine("Please entre a Departure date: yyyy-mm-dd ");
            datedepart = Console.ReadLine();
            departure = DateTime.ParseExact(datedepart, "yyyy-MM-dd", culture);

            Console.WriteLine("Please entre a Departure date: yyyy-mm-dd ");
            datearrival = Console.ReadLine();
            arrival = DateTime.ParseExact(datearrival, "yyyy-MM-dd", culture);

            try
            {
                if (departure == null || arrival == null)
                    throw new DateArrDepartException("Deprture or Arrival date could not be null!!");
                try
                {
                    if (DateTime.Compare(arrival, departure) < 0)
                        throw new DateArrDepartException("The Arrival date should be after the Departure date!!");
                    Console.WriteLine("Your Departure date is : " + departure + " and Arrival date is : " + arrival);
                }
                catch (DateArrDepartException nx)
                {
                    Console.WriteLine(nx.Message);
                }
            }
            catch (DateArrDepartException ex)
            {
                Console.WriteLine(ex.Message);
            }     
        }

        //8
        public static int GetAge(DateTime birthdate)
        {
            int age = 0;
            string inputDateofBirth;
            IFormatProvider culture = new CultureInfo("en-US", true);


            try
            {
                Console.WriteLine("Please entre your date of birth: yyyy-mm-dd");
                inputDateofBirth = Console.ReadLine();

                if (inputDateofBirth == null || inputDateofBirth == "")
                {
                    throw new AgeInputException("BirthDate could not be null, please entre one: yyyy-mm-dd !!");
                    return GetAge(birthdate);
                }
                birthdate = DateTime.ParseExact(inputDateofBirth, "yyyy-MM-dd", culture);
                age = 2022 - Convert.ToInt32(birthdate.Year);

                Console.WriteLine("Your date of birth: " + birthdate.ToString() + ". Your age is : " + age);
            }
            catch (AgeInputException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return age;
        }
    }
}
