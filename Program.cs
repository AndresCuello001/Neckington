using Neckington.Helpers;
using System.Collections;
using System.ComponentModel.Design;

namespace Neckington
{
    public class Program
    {
        static void Main(string[] args)
        {
            int menuUtilityValue = MenuUtils.MenuDialog();
            MenuUtils.OptionMethod(menuUtilityValue);
        }
    }
}