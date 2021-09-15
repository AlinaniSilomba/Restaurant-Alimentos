using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAlimentos.Validation
{
    public class RuleHelperForValidation
    {
        public static bool BeAValidName(string name)

        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);

        }

        public static bool BeAValidPhoneNumber(string number)
        {


            return number.All(Char.IsNumber);

        }

        public static bool BeAValidDay(DateTime day)
        {
            int currentDay = DateTime.Now.Day;

            int dateInThePast = day.Day;

            if (dateInThePast > (currentDay - 1))
            {
                return true;
            }
            return false;
        }
    }
}
