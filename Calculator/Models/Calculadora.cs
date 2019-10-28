using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    class Calculadora
    {
        public int currentState { get; set; }
        public int mathOperator { get; set; }
        public int firstNumber { get; set; }
        public int secondnumber { get; set; }
    }
}
