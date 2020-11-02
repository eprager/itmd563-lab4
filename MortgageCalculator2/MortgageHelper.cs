using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortgageCalculator2
{
    public class MortgageHelper
    {

        public static void WriteToFile()
        {

        }

        public static String ValidateMortgage(String principal, String duration, String rate, String otherDuration)
        {

            string msg1 = "Please enter input for all values";
            string msg2 = "Please enter a number";

            string output = String.Empty;

            // check if input is empty
            if (String.IsNullOrEmpty(principal) || String.IsNullOrWhiteSpace(principal) ||
                String.IsNullOrEmpty(duration) || String.IsNullOrWhiteSpace(duration) ||
                String.IsNullOrEmpty(rate) || String.IsNullOrWhiteSpace(rate))
            {
                 return msg1;
            }

            double princOut;
            // check if input is a number
            if (!double.TryParse(principal, out princOut))
            {
                return msg2 + " for principle amount";
            }

            //if other is chosen
            double dur;
            if (duration == "Other")
            {
                duration = otherDuration;
                if (String.IsNullOrEmpty(otherDuration) || String.IsNullOrWhiteSpace(otherDuration))
                {
                    return msg1;
                }
                if (!double.TryParse(otherDuration, out dur))
                {
                    return msg2 + " for other duration";
                }
            }
            else
            {
                double.TryParse(duration, out dur);
                double.TryParse(rate, out double rateOut);
                return ComputeMonthlyPayment(princOut, dur, rateOut);
            }
            double.TryParse(rate, out double rateOut2);
            return ComputeMonthlyPayment(princOut, dur, rateOut2);
        }

        // use the function to calculate the monthly payment   

        private static String ComputeMonthlyPayment(double principal, double years, double rate)
        {
            double monthly = 0;

            double top = principal * rate / 1200.00;

            double bottom = 1 - Math.Pow(1.0 + rate / 1200.0, -12.0 * years);

            // http://www.bankrate.com/calculators/mortgages/loan-calculator.aspx

            monthly = top / bottom;

            //Console.WriteLine();

            //Console.WriteLine("With a principl of ${0}, duration of {1} years and a interest rate of {2}% the monthly loan payment amount is {3:$0.00}", principal, years, rate, monthly);

            String dollars = monthly.ToString("C");
            String output = "With a principal of $" + principal + ", duration of " + years + " years, and an interest rate of " + rate + "%, the monthly loan payment amount is " + dollars + ".";
            return output;
        }
    }
}