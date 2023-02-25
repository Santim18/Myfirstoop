using System;
using System.Net.Http.Headers;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
      
            try 
            {
                Console.WriteLine("Please put your birth date day");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Please put your birth date month");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Please put your birth date year");
                int year = Convert.ToInt32(Console.ReadLine());

                var dateObject = new Date(year,month,day);
                Console.WriteLine(dateObject);

                Console.WriteLine("**********Testing latest implementation*********");
                Console.WriteLine(" ");
                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = Convert.ToInt32(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    Lastname = Console.ReadLine(),
                    BirthDate = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022, 3, 4),
                    Isactive = Convert.ToBoolean(Console.ReadLine()),
                    Salary = Convert.ToDecimal(Console.ReadLine()),



                };
                Console.WriteLine(salaryEmployee);    

            }
            catch (Exception ex) //Message error 
            {

                Console.WriteLine (ex.Message);
            }
       

        }
    }
}
