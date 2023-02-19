using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }
        public bool Isactive { get; set; }

        #region Methods

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"-----EMPLOYEE----- \n\t" +
                $"ID: {Id} \n\t" +
                $"First Name: {FirstName} \n\t " +
                $"Last Name: {Lastname} \n\t " +
                $"Birth Date: {BirthDate} \n\t" +
                $" Hiring Date: {HiringDate} \n\t" +
                $" Is Active: {Isactive}";
        }



        #endregion





        #endregion

    }
}
