using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator2
{
    interface IDataHelper
    {

        void WriteMortgage(string month);

        String GetAllMortgages();

        String ClearMortgages();

    }
}
