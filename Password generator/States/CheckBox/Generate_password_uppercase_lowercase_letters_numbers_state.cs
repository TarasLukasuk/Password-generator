namespace Password_generator.States.CheckBox
{
    class Generate_password_uppercase_lowercase_letters_numbers_state : IState
    {
        public void Ischecked(MainWindow mainWindow)
        {
            mainWindow.Generate_password_lowercase_letters_numbers.IsEnabled = false;
            mainWindow.Generate_password_lowercase_letters.IsEnabled = false;
            mainWindow.Generate_password_numbers.IsEnabled = false;
            mainWindow.Generate_completely_random_password.IsEnabled = false;
            mainWindow.Increase_number_characters.IsEnabled = false;
            mainWindow.Reduce_number_characters.IsEnabled = false;
        }

        public void Isunchecked(MainWindow mainWindow)
        {
            mainWindow.Generate_password_lowercase_letters_numbers.IsEnabled = true;
            mainWindow.Generate_password_lowercase_letters.IsEnabled = true;
            mainWindow.Generate_password_numbers.IsEnabled = true;
            mainWindow.Generate_completely_random_password.IsEnabled = true;
            mainWindow.Increase_number_characters.IsEnabled = true;
            mainWindow.Reduce_number_characters.IsEnabled = true;
        }
    }
}
