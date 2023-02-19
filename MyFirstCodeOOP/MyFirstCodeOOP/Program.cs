using System;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try //Intenta hacer lo que esta por dentro si no funciona salta al catch capturando el error
            {
                var dateObject = new Date(2003, 2, 30);
                Console.WriteLine(dateObject);
            }
            catch (Exception ex) //Message error 
            {

                Console.WriteLine (ex.Message);
            }
       

        }
    }
}
