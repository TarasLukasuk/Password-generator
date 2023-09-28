namespace Password_generator.Factory_metod.Factory
{
    internal class Generate_password_lowercase_letters_numbers_Factory_method : Factory_method
    {
        public Generate_password_lowercase_letters_numbers_Factory_method(int Number_characters)
        {
            Number_characters_password=Number_characters;
        }

        private readonly int Number_characters_password;

        public override IPassword GetPassword()
        {
            Password_lowercase_letters_numbers password_Lowercase_Letters_Numbers = new(Number_characters_password);
            return password_Lowercase_Letters_Numbers;
        }
    }
}
