using System;

namespace Password_generator.Factory_metod
{
    internal class Completely_random_password : IPassword
    {
        public Completely_random_password(int Number_characters)
        {
            Number_characters_password = Number_characters;
        }

        private string Password_characters { get; set; } = "QWERTYUIIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
        private int Number_characters_password { get; set; }
        private string Generation_result { get; set; }

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
