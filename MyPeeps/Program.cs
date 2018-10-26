using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyPeeps
{
    class Program
    {
        static void Main(string[] args)
        {
            //making a few test objects for the Person class
            Person person1 = new Person("Jon", "Shaw", 26, "Jonshaw@Quickenloans.com");
            Console.WriteLine(  person1.ToString());
            Person person2 = new Person("Jay", "Styles", 30, "Jaystyles@Quickenloans.com");
            Console.WriteLine(person2.ToString());
            //testing the user input for the Person class
            Person test = Person.MakePerson();
            

            //creating a list of Persons 
            List<Person> personList = new List<Person> { person1, person2 };  
            //adding a user input person to the list, will not allow a person under age 18
            Person.ToList(personList, test);
            //using the "Print List" Function, this will print the created list with the new entries
            Console.WriteLine("This is the list of Person in the list (note that people under 18 will not be added)");
            Person.PrintList(personList);
            Console.ReadKey();

            Console.Clear();
            //testing the Team Member class functions
            //making a few test objects for the team member class but  making them persons for the polymorphism 
            Console.WriteLine("Now testing polymorphism and the teammember class.\n");
            Person tm1 = new TeamMember("Jon", "Snow", 26, "JonSnow@FrigidNorth.com",1000000,"Frigid north,westeros");
            Console.WriteLine(tm1.ToString());
            Person tm2 = new TeamMember("Nowhere", "Man", 20, "noWhereman@nowhere.com",000, "Nowwhereland");
            Console.WriteLine(tm2.ToString());
            //testing the user input for the Person class but using the team member class
            Person tmtest = TeamMember.MakeTeamMember();


            //creating a list of Persons but putting team members in the list
            List<Person> tmList = new List<Person> { person1, tm1, tm2 };
            //adding a user input team member to the list, will not allow a person under age 18
            Person.ToList(tmList,tmtest);
            //using the "Print List" Function, this will print the created list with the new entries
            Person.PrintList(tmList);
            Console.ReadKey();


        }

        
        
        
    }
}
