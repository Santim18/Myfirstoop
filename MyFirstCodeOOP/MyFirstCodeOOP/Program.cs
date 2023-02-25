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
                Console.WriteLine("Ingrese el dia");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese el mes");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese  el year");
                int y = Convert.ToInt32(Console.ReadLine());

                var dateObject = new Date(y,m,d);
                Console.WriteLine(dateObject);

                Console.WriteLine("**********Testing latest implementation*********");

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id = 1000,
                    FirstName = " Maria",
                    Lastname = "Posada",
                    BirthDate = new Date(1950, 2, 5),
                    HiringDate = new Date(2022, 12, 31),
                    Isactive = true,
                    Salary = 2000000.34M



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
