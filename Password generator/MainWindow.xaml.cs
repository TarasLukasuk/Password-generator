using Password_generator.Factory_metod.Factory;
using Password_generator.States.CheckBox;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Password_generator
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image.Source = new BitmapImage(new Uri(@"\Resource\Highlight copying.png", UriKind.Relative));
            Message_copy.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Image.Source = new BitmapImage(new Uri(@"\Resource\Copy.png", UriKind.Relative));
            Message_copy.Visibility = Visibility.Hidden;
            Message.Content = "Скопіювати пароль в буфер";
        }

        private int Floating_point = 0;

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Message.Content = "Скопійовано";
            Clipboard.Clear();
            Clipboard.SetText(Password_text.Text);
        }

        private Factory_method factory_Method;

        private Check_boxs check_Boxs;

        private void Generate_password_uppercase_lowercase_letters_numbers_Checked(object sender, RoutedEventArgs e)
        {
            factory_Method = new Generate_password_uppercase_lowercase_letters_numbers_Factory_method(Floating_point);

            check_Boxs = new Check_boxs(new Generate_password_uppercase_lowercase_letters_numbers_state());
            check_Boxs.Ischecked(this);
        }

        private void Generate_password_lowercase_letters_numbers_Checked(object sender, RoutedEventArgs e)
        {
            factory_Method = new Generate_password_lowercase_letters_numbers_Factory_method(Floating_point);

            check_Boxs = new Check_boxs(new Generate_password_lowercase_letters_numbers_state());
            check_Boxs.Ischecked(this);
        }

        private void Generate_password_lowercase_letters_Checked(object sender, RoutedEventArgs e)
        {
            factory_Method = new Generate_password_lowercase_letters_Factory_method(Floating_point);

            check_Boxs = new Check_boxs(new Generate_password_lowercase_letters_state());
            check_Boxs.Ischecked(this);
        }

        private void Generate_password_numbers_Checked(object sender, RoutedEventArgs e)
        {
            factory_Method = new Generate_password_numbers_Factory_method(Floating_point);

            check_Boxs = new Check_boxs(new Generate_password_numbers_state());
            check_Boxs.Ischecked(this);
        }

        private void Generate_completely_random_password_Checked(object sender, RoutedEventArgs e)
        {
            factory_Method = new Generate_completely_random_password_Factory_method(Floating_point);

            check_Boxs = new Check_boxs(new Generate_completely_random_password_state());
            check_Boxs.Ischecked(this);
        }

        private void Generate_password_uppercase_lowercase_letters_numbers_Unchecked(object sender, RoutedEventArgs e)
        {
            check_Boxs = new Check_boxs(new Generate_password_uppercase_lowercase_letters_numbers_state());
            check_Boxs.Isunchecked(this);
        }

        private void Generate_password_lowercase_letters_numbers_Unchecked(object sender, RoutedEventArgs e)
        {
            check_Boxs = new Check_boxs(new Generate_password_lowercase_letters_numbers_state());
            check_Boxs.Isunchecked(this);
        }

        private void Generate_password_lowercase_letters_Unchecked(object sender, RoutedEventArgs e)
        {
            check_Boxs = new Check_boxs(new Generate_password_lowercase_letters_state());
            check_Boxs.Isunchecked(this);
        }

        private void Generate_password_numbers_Unchecked(object sender, RoutedEventArgs e)
        {
            check_Boxs = new Check_boxs(new Generate_password_numbers_state());
            check_Boxs.Isunchecked(this);
        }

        private void Generate_completely_random_password_Unchecked(object sender, RoutedEventArgs e)
        {
            check_Boxs = new Check_boxs(new Generate_completely_random_password_state());
            check_Boxs.Isunchecked(this);
        }

        private const int MIN_VALUE = 3;

        private const int MAX_VALUE = 30;

        private void Increase_number_characters_Click(object sender, RoutedEventArgs e)
        {
            if (Floating_point < MAX_VALUE)
            {
                Floating_point++;
                Value.Content = Floating_point.ToString();
            }

        }

        private void Reduce_number_characters_Click(object sender, RoutedEventArgs e)
        {
            if (Floating_point > MIN_VALUE)
            {
                Floating_point--;
                Value.Content = Floating_point.ToString();
            }
        }

        private void Value_Loaded(object sender, RoutedEventArgs e)
        {
            Floating_point = MIN_VALUE;
            Value.Content = Floating_point;
        }

        private void Show_password_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Password_text.Text = factory_Method.GetPassword().Criate_password();
            }
            catch (Exception)
            {

                MessageBox.Show("Для початку роботи оберіть кількість символів в паролі та режим роботи",
                    "Warning",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }

        private void Move_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();

        private void Exit_MouseEnter(object sender, MouseEventArgs e) => Exit_imag.Source = new BitmapImage(new Uri(@"Resource\Exit black.png", UriKind.Relative));

        private void Exit_MouseLeave(object sender, MouseEventArgs e) => Exit_imag.Source = new BitmapImage(new Uri(@"Resource\Exit white.png", UriKind.Relative));

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();
    }
}
