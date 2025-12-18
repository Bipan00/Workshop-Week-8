using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop8.Components.Pages
{
    public partial class Calculator : ComponentBase
    {
        // Two-way bound numbers
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        // Result of calculation
        public double Result { get; set; }

        // Event handlers
        public void Add()
        {
            Result = Num1 + Num2;
        }

        public void Subtract()
        {
            Result = Num1 - Num2;
        }

        public void Multiply()
        {
            Result = Num1 * Num2;
        }

        public void Divide()
        {
            if (Num2 != 0)
                Result = Num1 / Num2;
            else
                Result = double.NaN; // or display error
        }
    }
}