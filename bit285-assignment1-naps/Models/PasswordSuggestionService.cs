using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bit285_assignment1_naps.Models;

namespace bit285_assignment1_naps.Models
{
    public class PasswordSuggestionService
{
        public string GeneratePassword()//Injection services wont take an object as a parameter, dont know why. 
        {                               //Subbed in no parameter to make sure logic is sound in random password maker
            string pass = "";
            Random random = new Random();
            string[] poss = new string[6];
            poss[0] = "FirstName";//user.FirstName;
            poss[1] = "LastName"; //user.LastName;
            poss[2] = "Email"; //user.Email;
            poss[3] = "Program";//user.Program;
            poss[4] = "Bday"; //user.Bday;
            poss[5] = "Color"; //user.Color;


            for (int i = 0; i < 3; i++)
            {
                string l = poss[random.Next(0, 5)];
                pass = pass + l.Substring(1, random.Next(l.Length));
            }

            return pass;
    }
    }
}

