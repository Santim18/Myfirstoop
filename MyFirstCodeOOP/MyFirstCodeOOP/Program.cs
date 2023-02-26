using MyFirstCodeOOP.Helper;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("****************");
                Console.WriteLine("* OOP CONCEPTS *");
                Console.WriteLine("****************");
                Console.WriteLine(" ");

                Console.WriteLine("Please put your birth date year");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Please put your birth date month");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Please put your birth date day");
                int day = Convert.ToInt32(Console.ReadLine());

                var dateObject = new Date(year, month, day);
                Console.WriteLine(dateObject);

                Console.WriteLine("*******************");
                Console.WriteLine("* SALARY EMPLOYEE *");
                Console.WriteLine("*******************");
                Console.WriteLine(" ");

                Console.WriteLine("Type your ID");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type your first name");
                string firstname = Console.ReadLine();
                Console.WriteLine("Type your last name");
                string lastname = Console.ReadLine();
                Console.WriteLine("Are you Active¨?");
                bool isactive = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Enter your salary");
                int salary = Convert.ToInt32(Console.ReadLine());



                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    Lastname = lastname,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    Isactive = isactive,
                    Salary = salary,



                };
                //Console.WriteLine(salaryEmployee);



                Console.WriteLine(" ");
                Console.WriteLine("***********************");
                Console.WriteLine("* COMMISSION EMPLOYEE *");
                Console.WriteLine("***********************");
                Console.WriteLine(" ");

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type your first name");
                firstname = Console.ReadLine();
                Console.WriteLine("Type your last name");
                lastname = Console.ReadLine();
                Console.WriteLine("Are you Active¨?");
                isactive = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Enter your commission percentage");
                float commissionpercentage = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter your sales");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    Lastname = lastname,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    Isactive = isactive,
                    CommissionPercentage = commissionpercentage,
                    Sales = sales,
                };
                //Console.WriteLine(commissionEmployee);

                Console.WriteLine(" ");
                Console.WriteLine("***********************");
                Console.WriteLine("* CONTRACTOR EMPLOYEE *");
                Console.WriteLine("***********************");
                Console.WriteLine(" ");

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type your first name");
                firstname = Console.ReadLine();
                Console.WriteLine("Type your last name");
                lastname = Console.ReadLine();
                Console.WriteLine("Are you Active¨?");
                isactive = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Enter your number of hours");
                float hours = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter your value per hour ");
                decimal hourValue = Convert.ToDecimal(Console.ReadLine());

                Employee contractorEmployee = new ContractorEmployee()
                {
                    Id = id,
                    FirstName = firstname,
                    Lastname = lastname,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    Isactive = isactive,
                    Hours = hours,
                    HourValue = hourValue,
                };
                //Console.WriteLine(contractorEmployee);

                Console.WriteLine(" ");
                Console.WriteLine("***********************");
                Console.WriteLine("* BASE & COMMISSION EMPLOYEE *");
                Console.WriteLine("***********************");
                Console.WriteLine(" ");

                Console.WriteLine("Type your ID");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type your first name");
                firstname = Console.ReadLine();
                Console.WriteLine("Type your last name");
                lastname = Console.ReadLine();
                Console.WriteLine("Are you Active¨?");
                isactive = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Enter your commission percentage");
                 commissionpercentage = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter your sales");
                 sales = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter your salary base");
                decimal salaryBase = Convert.ToDecimal(Console.ReadLine());
            

                Employee baseCommissionEmployee = new BaseCommissionEmployee() 
                {
                    Id = id,
                    FirstName = firstname,
                    Lastname = lastname,
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    Isactive = isactive,
                    CommissionPercentage= commissionpercentage,
                    Sales = sales,  
                    Base = salaryBase,
                };
                //Console.WriteLine(baseCommissionEmployee);


                EmployeeHelper employeeHelper = new EmployeeHelper(salaryEmployee, commissionEmployee, contractorEmployee, baseCommissionEmployee);
                Console.WriteLine($"Total payroll:................{employeeHelper.GetPayrollFromActiveEmployees():C2}");



            }
            catch (Exception ex) //Message error 
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}
