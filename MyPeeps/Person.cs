using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyPeeps
{
    class Person
    {
        #region Data
        private string FirstName;
        private string LastName;
        private int Age;
        private string EmailAddress;
        public bool IsAdult;
        #endregion
        #region Constructor
        public Person(string firstName, string lastName, int age, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName; 
            Age = age;
            EmailAddress = emailAddress;
            IsAdult = AdultYesNo(age);
        }
        #endregion
        #region Methods
        public static void ToList(List<Person> list, Person person)
        {
            
            if (person.age >= 18)
            {
                list.Add(person);
            }
            else
            {
                Console.WriteLine("This person is not over 18, we will not add them to the list. Sorry charlie");
            }
        }
        public static Person MakePerson()
        {
            Console.Write("What is the person's first name: ");
            string firstname = ValidateString();
            Console.Write("What is the person's last name: ");
            string lastname = ValidateString();
            Console.Write("What is the person's email address: ");
            var emailAddress = EmailValidation();
            Console.Write("What is the persons Age: ");
            int age = ValidateInt();
             
            
            Person temp = new  Person(firstname,lastname,age,emailAddress);
            return temp;
        }
        public static void PrintList(List<Person> list)
        {
            foreach (Person i in list)
            {
                Console.WriteLine(i.ToString());
            }
        }
        public string firstName
        {
            set
            {
                if (Regex.IsMatch(value, @"^[A-z]{0,29}$"))
                {
                    FirstName = value;
                }
                else
                {
                    Console.WriteLine("Sorry, First Name is not valid!");
                    FirstName = $"Non valid First Name: {value}";
                }
                
            }
            get
            {
                return FirstName;
            }
        }
        public string lastName
        {
            set
            {
                if (Regex.IsMatch(value, @"^[A-z]{0,29}$"))
                {
                    LastName = value;
                }
                else
                {
                    Console.WriteLine("Sorry, Last Name is not valid!");
                    LastName = $"Non valid Last Name: {value}";
                }
            }
            get
            {
                return LastName;
            }
        }
        public int age
        {
            set
            {
                if (value <18)
                {
                    IsAdult = false;
                    Age = value;
                }
                else
                {
                    IsAdult = true;
                    Age = value;
                }
                
            }
            get
            {
                return Age;
            }
        }
        public static bool AdultYesNo(int x)
        {
            if (x < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string emailAddress
        {
            set
            {
                if (Regex.IsMatch(value, @"^[A-z\d]{2,30}[@][A-z\d]{1,10}[.][A-z/d]{2,4}$"))
                {
                    EmailAddress = value;
                }
                else
                {
                    Console.WriteLine("Sorry, Email is not valid!");
                    EmailAddress = $"Non valid email: {value}";
                }
                
            }
            get
            {
                return EmailAddress;
            }
        }

        public override string ToString()
        {

            return $"This person's name is {firstName} {lastName}, age: {age}. Email address: {emailAddress}.";
        }
        public static string ValidateString()
        {
            string Return = Console.ReadLine();
            try
            {
               if (Regex.IsMatch(Return, @"^[A-z]{0,29}$"))
               {
                    return Return;
               }
               else
               {
                   Console.WriteLine("Sorry, that is not valid, try again:");
                   Return = ValidateString();
                }
                                
            }
            catch (FormatException)
            {
                Console.Write("That is not valid, try again: ");
                Return = ValidateString();
            }
            return Return;

        }
        public static string EmailValidation()
        {
            string temp = Console.ReadLine();
            if (Regex.IsMatch(temp, @"^[A-z\d]{2,30}[@][A-z\d]{1,20}[.][A-z/d]{2,4}$"))
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Sorry, Email is not valid. try again:");
                temp = EmailValidation();

            }
            return temp;
        }
        public static int ValidateInt()
        {
            string test = Console.ReadLine();
            int temp;
            try
            {
                int Return = Int32.Parse(test);
                return Return;

            }
            catch (FormatException)
            {
                Console.Write("That is not valid, try again: ");
                temp = ValidateInt();
            }
            return temp;

        }
        #endregion

    }
}

