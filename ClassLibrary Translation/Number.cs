using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Translation
{
    public class NumberTraslate
    {
        private int system;
        private string number;

        public NumberTraslate(int system, string number)
        {
            this.system = system;
            this.number = number;
        }
        public void translateToSystem(int value)
        {
            int decimalNumber = Convert.ToInt32(number, system);
            string result = Convert.ToString(decimalNumber, value);
            this.number = result;
        }
        public string Number { get { return number; } }
    }
}
