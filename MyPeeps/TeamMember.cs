using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyPeeps
{
    class TeamMember:Person
    {
        #region Data
        private int Salary;
        private string Address;
        #endregion
        #region Constructor
        public TeamMember(string firstName, string lastName, int age, string emailAddress, int salary, string address):base(firstName,lastName,age,emailAddress)
        {
            Salary = salary;
            Address = address;
        }
        #endregion
        #region Methods
        public int salary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
        public string address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public override string ToString()
        {

            return $"This person's name is {firstName} {lastName}, age: {age}. Email address: {emailAddress}.\nTheir salary is {salary} and their address is {address}.";
        }
        public static void Printist(List<Person>list) 
        {
            foreach (Person i in list)
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine();
            }
        }
        public new void ToList(List<Person> list, Person teamMember)
        {
            
            if (teamMember.age >= 18)
            {
                list.Add(teamMember);
            }
            else
            {
                Console.WriteLine("Sorry this team member is not over 18, will not add them.");
            }
        }
        public static TeamMember MakeTeamMember()
        {
            Console.Write("What is the person's First name: ");
            string firstname = ValidateString();
            Console.Write("What is the person's Last name: ");
            string lastname = ValidateString();
            Console.Write("What is the person's Email address: ");
            var emailAddress = EmailValidation();
            Console.Write("What is the persons Age: ");
            int age = ValidateInt();
            Console.Write("What is the persons Salary: ");
            int salary = ValidateInt();
            Console.Write("What is the person's Address: ");
            //did not validate address as there are other formats that people could put in
            string address = Console.ReadLine();


            TeamMember temp = new TeamMember(firstname, lastname, age, emailAddress,salary,address);
            return temp;
        }
        
           
        #endregion
    }
}
