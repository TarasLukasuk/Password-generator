using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_generator.Factory_metod
{
    internal class Password_lowercase_letters:IPassword
    {
        public Password_lowercase_letters(int Number_characters)
        {
            Number_characters_password = Number_characters;
        }

        private string Password_characters { get; set; } = "qwertyuiopasdfghjklzxcvbnm";
        private int Number_characters_password { get ; set ; }
        public string Generation_result { get ; set ; }

        public string Criate_password()
        {
            Random random = new Random();

            for (int Index = 1; Index <= Number_characters_password; Index++)
            {
                Generation_result += Password_characters[random.Next(Password_characters.Length)];
            }
            return Generation_result;
        }
    }
}
