using System;

namespace Password_generator.Factory_metod
{
    internal class Password_uppercase_lowercase_letters_numbers : IPassword
    {
        public Password_uppercase_lowercase_letters_numbers(int Number_characters)
        {
            Number_characters_password = Number_characters;
        }

        private string _Password_characters { get; set; }
        private int Number_characters_password { get; set; }
        private string Generation_result { get; set; }
        private string _Uppercase { get; set; }

        Random random = new Random();

        public string Criate_password()
        {
            string Password_characters = "qwertyQWERTYUIOPASDFGHJKLZXCVBNMuiopasdfghjklzxcvbnm1234567890";
            string Uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            int Number_capital_letters = 1;

            for (int index = 1; index <= Number_capital_letters; index++)
            {
               Generation_result +=_Uppercase= Uppercase[random.Next(Uppercase.Length)].ToString();
            }

            for (int indexs = 0; indexs < Number_characters_password-1; indexs++)
            {
                Generation_result += _Password_characters = Password_characters[random.Next(Number_characters_password)].ToString();
            }

            return Generation_result;
        }
    }

}