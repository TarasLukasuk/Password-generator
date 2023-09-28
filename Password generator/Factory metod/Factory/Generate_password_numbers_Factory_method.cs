using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_generator.Factory_metod.Factory
{
    internal class Generate_password_numbers_Factory_method : Factory_method
    {
        public Generate_password_numbers_Factory_method(int Number_characters)
        {
            Number_characters_password=Number_characters;
        }

        private readonly int Number_characters_password;

        public override IPassword GetPassword()
        {
            Password_numbers password_Numbers = new(Number_characters_password);
            return password_Numbers;
        }
    }
}
