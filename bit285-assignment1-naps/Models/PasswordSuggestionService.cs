using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bit285_assignment1_naps.Models;

namespace bit285_assignment1_naps.Models
{
    public class PasswordSuggestionService
{
        public string GeneratePassword(User user)
        {
            string pass = "";
            Random random = new Random();
            string[] poss = new string[6];
            poss[0] = user.FirstName;
            poss[1] = user.LastName;
            poss[2] = user.Email;
            poss[3] = user.Program;
            poss[4] = user.Bday;
            poss[5] = user.Color;

           
            for (int i = 0; i < 3; i++)
            {
                pass = string.Concat(poss[random.Next(0, 5)]);
            }

            return pass;
    }
    }
}

