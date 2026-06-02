using Neckington.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Services
{
    public class AverageCalculatorServices
    {
        public static void InitializeAverageCalculator()
        {
            var average = new AverageCalculator();
            average.ProcessingData();
        }
    }
}
