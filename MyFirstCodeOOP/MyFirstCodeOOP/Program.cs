using System;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            int d = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());


            try //Intenta hacer lo que esta por dentro si no funciona salta al catch capturando el error
            {
                var dateObject = new Date(d,m,y);
                Console.WriteLine(dateObject);
            }
            catch (Exception ex) //Message error 
            {

                Console.WriteLine (ex.Message);
            }
       

        }
    }
}
