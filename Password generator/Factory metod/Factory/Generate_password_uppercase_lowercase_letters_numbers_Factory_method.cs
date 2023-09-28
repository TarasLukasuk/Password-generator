namespace Password_generator.Factory_metod.Factory
{
    internal class Generate_password_uppercase_lowercase_letters_numbers_Factory_method : Factory_method
    {
        public Generate_password_uppercase_lowercase_letters_numbers_Factory_method(int Number_characters)
        {
            Number_characters_password = Number_characters;
        }

        private readonly int Number_characters_password;

        public override IPassword GetPassword()
        {
            Password_uppercase_lowercase_letters_numbers password_Uppercase_Lowercase_Letters_Numbers = new(Number_characters_password);
            return password_Uppercase_Lowercase_Letters_Numbers;
        }
    }
}
