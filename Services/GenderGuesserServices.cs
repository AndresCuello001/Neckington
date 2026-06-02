using Neckington.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neckington.Services
{
    public class GenderGuesserServices
    {
        public static void InitiliazeGenderGuessser()
        {
            GenderGuesser genderGuesserObject = new GenderGuesser();
            genderGuesserObject.GetData();
        }
    }
}
