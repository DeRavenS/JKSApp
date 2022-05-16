using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKSApp.BusinessLayer
{
    class DataValidation
    {
        public bool JustString(string name)
        {
            if (name.Length != 0)
            {
                foreach (char item in name)
                {
                    if (!char.IsLetter(item))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }          
        }
        public bool checkNumber(string number)
        {
            if (number.Length == 10)
            {
                foreach (char item in number)
                {
                    if (!char.IsNumber(item))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public bool checkDate(DateTime date)
        {
            if (date>DateTime.Now)
            {
                return false;
            }
            return true;
        }
    }
}
