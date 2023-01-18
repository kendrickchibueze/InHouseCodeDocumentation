using AttributeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocumentation
{

    [Document("A class that displays the user details", Input = "It takes a fullname as string", Output = "None")]
    class UserDetails
    {
        public UserDetails(string fullname)
        {
            FirstName = fullname;
        }

        [Document("FirstName of the user Required", Input = "None", Output = "Trainee's fullname")]
        public string FirstName { get; set; }

        [Document("Age of User", Input = "None", Output = "Trainee's age")]
        public int Age { get; set; }

        [Document("Nice one there", Input = "It takes in a something strange as an object", Output = "None")]
        public void Quiet(object somethingStrange)
        {
            Console.WriteLine("Learn to keep quiet in the bank hall");
        }
        

        [Document("What some hoodlums come to do in the bank", Input = "None", Output = "None")]
        enum BankHoodlums
        {
            Steal,
            Shoot,
            Destroy
        }



    }
}

