using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public float CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        #endregion



        #region Methods
        public override decimal GetValueToPay()
        {
            return (Sales * (decimal)ConvertPercentage(CommissionPercentage));
        }
        public override string ToString()
        {
            return $"{base.ToString()} " +
                $" \n\tComission Percentage........{ConvertPercentage(CommissionPercentage):P2}" +
                $" \n\tSales.......................{Sales:C2}" +
                $" \n\tValue to pay................{GetValueToPay():C2}" ;
        }

        public float ConvertPercentage(float CommissionPercentage)
        {
            return (CommissionPercentage/100);
        }
        #endregion

    }
}
