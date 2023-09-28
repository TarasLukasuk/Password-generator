namespace Password_generator.Factory_metod.Factory
{
    internal class Generate_completely_random_password_Factory_method : Factory_method
    {
        public Generate_completely_random_password_Factory_method(int Number_characters)
        {
            Number_characters_password = Number_characters;
        }

        private readonly int Number_characters_password;

        public override IPassword GetPassword()
        {
            Completely_random_password completely_Random_Password = new(Number_characters_password);
            return completely_Random_Password;
        }
    }
}
